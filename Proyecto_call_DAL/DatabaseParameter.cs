using System.Data;
using System.Data.SqlClient;

namespace Proyecto_call_DAL
{
    public sealed class DatabaseParameter
    {
        #region Fields & Constants
        /// <summary>
        /// SqlParameter de tipo interno para permitir que los parámetros de tipo in/out, out, y los que retornan valor funcionen.
        /// </summary>
        private readonly SqlParameter _sqlParameter;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor privado para evitar que se creen clases de tipo <see cref="DatabaseParameter"/> usando el constructor por defecto.
        /// Se deben utilizar los métodos proveídos para la creación del parámetro.
        /// </summary>
        private DatabaseParameter()
        {
            _sqlParameter = new SqlParameter();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Obtiene el valor del parámetro.
        /// </summary>
        public object Value
        {
            get { return _sqlParameter.Value; }
            private set { _sqlParameter.Value = value; }
        }

        /// <summary>
        /// Obtiene el tipo de dato del parámetro.
        /// </summary>
        public DbType Type
        {
            get { return _sqlParameter.DbType; }
            private set { _sqlParameter.DbType = value; }
        }

        /// <summary>
        /// Obtiene el nombre del parámetro.
        /// </summary>
        public string Name
        {
            get { return _sqlParameter.ParameterName; }
            private set { _sqlParameter.ParameterName = value; }
        }

        /// <summary>
        /// Obtiene la dirección del parámetro, posibles valores: Input, Output, InputOutput, ReturnValue.
        /// </summary>
        public ParameterDirection Direction
        {
            get { return _sqlParameter.Direction; }
            private set { _sqlParameter.Direction = value; }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Permite convertir objetos de tipo <see cref="DatabaseParameter"/> a tipo <see cref="SqlParameter"/>.
        /// </summary>
        /// <param name="parameter">El objeto de tipo <see cref=" DatabaseParameter"/> que se va a convertir.</param>
        /// <returns>Una instancia de objeto compatible con la clase SqlParameter.</returns>
        public static implicit operator SqlParameter(DatabaseParameter parameter)
        {
            return parameter._sqlParameter;
        }

        /// <summary>
        /// Método para crear un parámetro de tipo input.
        /// </summary>
        /// <param name="name">Nombre del parámetro, como es esperado en la base de datos.</param>
        /// <param name="type">Tipo de dato del parámetro, como es esperado en la base de datos.</param>
        /// <param name="value">Valor del parámetro, que se le va a pasar a la base de  datos.</param>
        /// <returns>Un nuevo objeto de tipo <see cref="DatabaseParameter"/> inicializado para trabajar como un parámetro de tipo Input.</returns>
        public static DatabaseParameter CreateInParam(string name, DbType type, object value)
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
        /// Método para crear un parámetro de tipo output.
        /// </summary>
        /// <param name="name">Nombre del parámetro, como es esperado en la base de datos.</param>
        /// <param name="type">Tipo de dato del parámetro, como es esperado en la base de datos.</param>
        /// <returns>Un nuevo objeto de tipo <see cref="DatabaseParameter"/> inicializado para trabajar como un parámetro de tipo output.</returns>
        public static DatabaseParameter CreateOutParam(string name, DbType type)
        {
            return new DatabaseParameter
            {
                Direction = ParameterDirection.Output,
                Name = name,
                Type = type,
            };
        }

        /// <summary>
        /// Método para crear un parámetro de tipo input/output.
        /// </summary>
        /// <param name="name">Nombre del parámetro, como es esperado en la base de datos.</param>
        /// <param name="type">Tipo de dato del parámetro, como es esperado en la base de datos.</param>
        /// <param name="value">Valor del parámetro, que se le va a pasar a la base de  datos.</param>
        /// <returns>Un nuevo objeto de tipo <see cref="DatabaseParameter"/> inicializado para trabajar como un parámetro de tipo input/output.</returns>
        public static DatabaseParameter CreateInOutParam(string name, DbType type, object value)
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
        /// Método para crear un parámetro que retorna un valor desde la base de datos.
        /// </summary>
        /// <param name="name">Nombre del parámetro, como es esperado en la base de datos.</param>
        /// <param name="type">Tipo de dato del parámetro, como es esperado en la base de datos.</param>
        /// <returns>
        /// Un nuevo objeto de tipo <see cref="DatabaseParameter"/> inicializado para trabajar como un parámetro que retorna un valor
        /// desde la base de datos.
        /// </returns>
        public static DatabaseParameter CreateReturnValueParam(string name, DbType type)
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
