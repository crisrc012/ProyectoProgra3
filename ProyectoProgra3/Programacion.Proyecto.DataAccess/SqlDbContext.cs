using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Programacion.Proyecto.DataAccess
{
    public class SqlDbContext : IDisposable
    {
        private bool _isDisposed;

        #region Constructors and Destructors
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDbContext"/> class.
        /// </summary>
        /// <param name="sqlConnection">The SQL Database connection that is going to be used.</param>
        protected SqlDbContext(SqlConnection sqlConnection)
        {
            _isDisposed = false;
            Connection = sqlConnection;
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="SqlDbContext"/> class.
        /// </summary>
        ~SqlDbContext()
        {
            OnDispose(false);
        }
        #endregion

        #region Properties
        public SqlConnection Connection { get; private set; }

        /// <summary>
        /// Gets the current connection state for the context.
        /// </summary>
        public ConnectionState State => this.Connection.State;
        #endregion

        #region Public Methods
        /// <summary>
        /// Closes the SQL Database connection.
        /// </summary>
        public void Close()
        {
            Connection.Close();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="SqlDbContext"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string to use when connecting to the target SQL instance.</param>
        /// <returns>A new <see cref="SqlDbContext"/> instance pointed to the target database.</returns>
        public static SqlDbContext Create()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Win_Aut"].ToString().Trim();
            var dbConn = new SqlConnection(connectionString);
            var context = new SqlDbContext(dbConn);
            context.ValidateConnectionState();
            return context;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            OnDispose(true);
            GC.SuppressFinalize(this);
        }

        public DataTable ExecuteDataTable(string procName, IEnumerable<DatabaseParameter> parameters = null)
        {
            var commandToExecute = GetCommand(procName, parameters);
            return ExecuteTransaction(commandToExecute, LoadDataTable);
        }

        public SqlDataReader ExecuteReader(string procName, IEnumerable<DatabaseParameter> parameters = null)
        {
            var commandToExecute = GetCommand(procName, parameters);
            return ExecuteTransaction(commandToExecute, command => command.ExecuteReader());
        }

        /// <inheritdoc />
        public override string ToString()
        {
            const string currenConnectionState = "Connection State => {0}";
            return string.Format(currenConnectionState, Connection != null ? Connection.State.ToString() : "Null");
        }
        #endregion

        #region Internal Methods 
        /// <summary>
        /// Executes the target function inside a transaction against the context's target database. If the connection
        /// is not open, this method will attempt to open it before performing the operation. Use this method to perform
        /// units of work against the database.
        /// </summary>
        /// <typeparam name="T">The type of command to execute. This parameter must be a subclass of the DbCommand type.</typeparam>
        /// <typeparam name="TR">The type of result that the operation should return.</typeparam>
        /// <param name="command">The command instance to execute.</param>
        /// <param name="function">A function containing some business logic to execute against the database.</param>
        /// <returns>A result of type Tres, returned by the target operation f executed against the database.</returns>
        internal TR ExecuteTransaction<T, TR>(T command, Func<T, TR> function) where T : IDbCommand
        {
            ValidateConnectionState();

            var transaction = Connection.BeginTransaction();
            command.Transaction = transaction;

            try
            {
                var result = function(command);
                transaction.Commit();
                return result;
            }
            catch (Exception)
            {
                if (State == ConnectionState.Open)
                    transaction.Rollback();

                throw;
            }
        }

        /// <summary>
        /// Retrieves a SqlCommand instance for the target stored procedure name and parameter list.
        /// </summary>
        /// <param name="procName">The name of the stored procedure to execute.</param>
        /// <param name="parameters">A list of parameters to pass to the stored procedure.</param>
        /// <returns>A SqlCommand instance ready to execute.</returns>
        internal SqlCommand GetCommand(string procName, IEnumerable<DatabaseParameter> parameters)
        {
            if (parameters == null) 
                parameters = new DatabaseParameter[0];

            var command = new SqlCommand(procName, Connection)
            {
                CommandType = CommandType.StoredProcedure,
            };

            foreach (var param in parameters)
                command.Parameters.Add(param);

            return command;
        }

        internal DataTable LoadDataTable(SqlCommand command)
        {
            var table = new DataTable();
            var reader = command.ExecuteReader();

            table.Load(reader);

            return table;
        }

        /// <summary>
        /// Called when the context is disposing. Override for more specific teardown behavior.
        /// </summary>
        /// <param name="disposing">Is the context disposing?</param>
        internal virtual void OnDispose(bool disposing)
        {
            if (_isDisposed || !disposing)
                return;

            Close();
            Connection = null;
            _isDisposed = true;
        }

        /// <summary>
        /// Validates the state of the database connection. If something's wrong it will throw an InvalidOperationException,
        /// else it will attempt to open the connection if it's closed.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the connection is in a bad state.</exception>
        internal void ValidateConnectionState()
        {
            if (Connection == null)
                throw new InvalidOperationException("El estado de la conexión a base de datos es incorrecto." + ToString());

            if (Connection.State == ConnectionState.Broken || Connection.State == ConnectionState.Closed)
                Connection.Open();
        }
        #endregion
    }
}
