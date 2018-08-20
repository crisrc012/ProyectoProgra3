using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Proyecto_call_DAL.Interfaces;

namespace Proyecto_call_DAL
{
    /// <summary>
    /// Envuelve las funciones que se necesitan para interactuar con la base de datos.
    /// Implementa la interfaz IDisposable para poder ser utilizada dentro de sentencias using.
    /// </summary>
    /// <inheritdoc cref="IDisposable"/>
    public sealed class SqlDbContext : IDbContext
    {
        private bool _isDisposed;
        private readonly Func<SqlCommand, int> _executeNonQueryFunction = command => command.ExecuteNonQuery();
        private readonly Func<SqlCommand, object> _executeScalarFunction = command => command.ExecuteScalar();

        #region Constructors and Destructors
        /// <summary>
        /// Constructor que crea una nueva instancia de la clase <see cref="SqlDbContext"/>.
        /// Para poder ejecutar instrucciones se deben de utilizar los métodos proveídos para la creación de la conexión a SQL Server.
        /// </summary>
        public  SqlDbContext()
        {
            _isDisposed = false;
        }

        /// <summary>
        /// Termina la instancia actual de la clase <see cref="SqlDbContext"/> y libera sus recursos.
        /// </summary>
        ~SqlDbContext()
        {
            OnDispose(false);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Obtiene la conexión al servidor de SQL Server de la clase.
        /// </summary>
        public SqlConnection Connection { get; private set; }

        /// <inheritdoc />
        public ConnectionState State => Connection.State;
        #endregion

        #region Public Methods
        /// <summary>
        /// Cierra la actual conexión a la instancia del servidor de SQL Server.
        /// </summary>
        public void Close()
        {
            Connection.Close();
        }

        /// <inheritdoc />
        public IDbContext Create()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Win_aut"].ToString().Trim();
            var dbConn = new SqlConnection(connectionString);

            Connection = dbConn;
            ValidateConnectionState();

            return this;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            OnDispose(true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc />
        public DataTable ExecuteDataTable(string procName, IEnumerable<DatabaseParameter> parameters = null)
        {
            var commandToExecute = GetCommand(procName, parameters);
            return ExecuteTransaction(commandToExecute, LoadDataTable);
        }

        /// <inheritdoc />
        public int ExecuteNonQuery(string procName, IEnumerable<DatabaseParameter> parameters)
        {
            var commandToExecute = GetCommand(procName, parameters);
            return ExecuteTransaction(commandToExecute, _executeNonQueryFunction);
        }

        /// <inheritdoc />
        public SqlDataReader ExecuteReader(string procName, IEnumerable<DatabaseParameter> parameters = null)
        {
            var commandToExecute = GetCommand(procName, parameters);
            return ExecuteTransaction(commandToExecute, command => command.ExecuteReader());
        }

        /// <inheritdoc />
        public object ExecuteScalar(string procName, IEnumerable<DatabaseParameter> parameters)
        {
            var commandToExecute = GetCommand(procName, parameters);
            return ExecuteTransaction(commandToExecute, _executeScalarFunction);
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
        /// Ejecuta la transacción contra la base de datos indicada en el parámetro <paramref name="command"/> y va a procesar los resultados
        /// utilizando la función dada en el parámetro <paramref name="function"/>. Si la conexión de la base de datos no está abierta
        /// esta función va a intentar abrir la conexión antes de ejecutar la operación dada.
        /// </summary>
        /// <typeparam name="T">
        /// Tipo de comando que va a ser ejecutado. El parámetro debe ser un objeto instanciado que implemente la interfaz IDbCommand.</typeparam>
        /// <typeparam name="TR">The type of result that the operation should return.</typeparam>
        /// <param name="command">Instancia del comando que va a ser ejecutado.</param>
        /// <param name="function">
        /// Función que contiene una lógica de negocios que va a ser utilizada contra los resultados de la base de datos.</param>
        /// <returns>
        /// Resultado de tipo TR, devuelto por la función pasada en el parámetro <paramref name="function"/> al ser ejecutada usando
        /// los resultados obtenidos de ejecutar el parámetro <paramref name="command"/>.
        /// </returns>
        internal TR ExecuteTransaction<T, TR>(T command, Func<T, TR> function) where T : IDbCommand, new()
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
        /// Crea una instancia de tipo <see cref="SqlCommand"/> con los parámetros requeridos para ejecutar el stored procedure.
        /// </summary>
        /// <param name="procName">Nombre del stored procedure que va a ser ejecutado.</param>
        /// <param name="parameters">Lista de los parámetros que son necesarios para la ejecución del stored procedure.</param>
        /// <returns>Una instancia de tipo <see cref="SqlCommand"/> lista para ser utilizada.</returns>
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

        /// <summary>
        /// Carga un objeto de tipo <see cref="DataTable"/> con los resultados de la operación del parámetro <paramref name="command"/>.
        /// </summary>
        /// <param name="command">Objeto de tipo <see cref="SqlCommand"/> con la operación que va a ser ejecutada contra la base de datos.</param>
        /// <returns>Nueva instancia del tipo <see cref="DataTable"/> con los valores devueltos por la operación.</returns>
        internal DataTable LoadDataTable(SqlCommand command)
        {
            var table = new DataTable();
            var reader = command.ExecuteReader();

            table.Load(reader);

            return table;
        }

        /// <summary>
        /// Función que se va a encargar de cerrar la conexión a la base de datos y liberar los recursos de esta instancia.
        /// Override para poder tener el manejo deseado de este evento.
        /// </summary>
        /// <param name="disposing">Variable para saber si la instancia esta siendo finalizada.</param>
        internal void OnDispose(bool disposing)
        {
            if (_isDisposed || !disposing)
                return;

            Close();
            Connection = null;
            _isDisposed = true;
        }

        /// <summary>
        /// Valida el estado de la conexión de la base de datos, si la conexión estuviera cerrada se va a intentar abrir. En caso de encontrar
        /// algún error una excepción de tipo <see cref="InvalidOperationException"/> va a ser lanzada.
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