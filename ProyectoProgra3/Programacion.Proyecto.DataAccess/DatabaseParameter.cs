using System.Data;
using System.Data.SqlClient;

namespace Programacion.Proyecto.DataAccess
{
    public sealed class DatabaseParameter
    {
        #region Fields & Constants
        /// <summary>
        /// Internal SqlParameter so that in/out, out, and return value parameter types work.
        /// </summary>
        private readonly SqlParameter _sqlParameter;
        #endregion

        #region Constructors
        /// <summary>
        /// Prevents a default instance of the <see cref="DatabaseParameter"/> class from being created.
        /// Use factory methods instead.
        /// </summary>
        private DatabaseParameter()
        {
            _sqlParameter = new SqlParameter();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the parameter's value.
        /// </summary>
        public object Value
        {
            get { return _sqlParameter.Value; }
            private set { _sqlParameter.Value = value; }
        } 

        /// <summary>
        /// Gets the parameter's type.
        /// </summary>
        public DbType Type
        {
            get
            {
                return _sqlParameter.DbType;
            }

            private set
            {
                _sqlParameter.DbType = value;
            }
        }

        /// <summary>
        /// Gets the parameter name.
        /// </summary>
        public string Name
        {
            get
            {
                return _sqlParameter.ParameterName;
            }
            private set
            {
                _sqlParameter.ParameterName = value;
            }
        }

        /// <summary>
        /// Gets the parameter's direction.
        /// </summary>
        public ParameterDirection Direction
        {
            get { return _sqlParameter.Direction; }
            private set { _sqlParameter.Direction = value; }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Factory method for creating an input parameter.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The parameter's type.</param>
        /// <param name="value">the parameter's value.</param>
        /// <returns>A <see cref="DatabaseParameter"/> that is initialized to function as an
        /// input value to a stored procedure.</returns>
        public static DatabaseParameter InParam(string name, DbType type, object value)
        {
            return new DatabaseParameter
            {
                Direction = ParameterDirection.Input,
                Name = name,
                Value = value,
                Type = type
            };
        }

        /// <summary>
        /// Factory method for creating an output parameter.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The parameter's type.</param>
        /// <returns>A <see cref="DatabaseParameter"/> that is initialized to function as an
        /// output value to a stored procedure.</returns>
        public static DatabaseParameter OutParam(string name, DbType type)
        {
            return new DatabaseParameter
            {
                Direction = ParameterDirection.Output,
                Name = name,
                Type = type,
            };
        }

        /// <summary>
        /// Factory method for creating an input/output parameter.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The parameter's type.</param>
        /// <param name="value">the parameter's value.</param>
        /// <returns>A <see cref="DatabaseParameter"/> that is initialized to function as an
        /// input/output value to a stored procedure.</returns>
        public static DatabaseParameter InOutParam(string name, DbType type, object value)
        {
            return new DatabaseParameter
            {
                Direction = ParameterDirection.InputOutput,
                Name = name,
                Type = type,
                Value = value
            };
        }

        /// <summary>
        /// Factory method for creating a return value parameter.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The parameter's type.</param>
        /// <returns>A <see cref="DatabaseParameter"/> that is initialized to function as a
        /// return value to a stored procedure.</returns>
        public static DatabaseParameter ReturnValue(string name, DbType type)
        {
            return new DatabaseParameter
            {
                Direction = ParameterDirection.ReturnValue,
                Name = name,
                Type = type
            };
        }

        #endregion
    }
}