using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_call_DAL.Interfaces
{
    /// <summary>
    /// Contrato para las clases que implementan conexiones a base de datos.
    /// </summary>
    /// <inheritdoc />
    public interface IDbContext : IDisposable
    {
        /// <summary>
        /// Obtiene el estado actual de la conexión al servidor de SQL Server.
        /// </summary>
        ConnectionState State { get; }

        /// <summary>
        /// Cierra la actual conexión a la instancia del servidor de SQL Server.
        /// </summary>
        void Close();

        /// <summary>
        /// Crea a una nueva instancia de la clase <see typeparamref="T"/> utilizando la cadena de conexión del archivo de configuración
        /// con nombre DbContext.
        /// </summary>
        /// <returns>
        /// Una nueva instancia del tipo  <see typeparamref="T"/> con la conexión al servidor de SQL Server localizada en el
        /// archivo de configuración de la aplicación.
        /// </returns>
        IDbContext Create();

        /// <summary>
        /// Ejecuta un stored procedure que llena una tabla desde la base de datos.
        /// </summary>
        /// <param name="procName">Nombre del stored procedure que va a ser ejecutado.</param>
        /// <param name="parameters">Parámetros requeridos para la ejecución del stored procedure.</param>
        /// <returns>
        /// Devuelve una instancia de tipo  <see cref="DataTable"/> con los resultados obtenidos de la ejecución del stored procedure.
        /// </returns>
        DataTable ExecuteDataTable(string procName, IEnumerable<DatabaseParameter> parameters = null);

        /// <summary>
        /// Ejecuta un stored procedure que no devuelve resultados y devuelve la cantidad de filas que fueron modificadas.
        /// </summary>
        /// <param name="procName">Nombre del stored procedure que va a ser ejecutado.</param>
        /// <param name="parameters">Parámetros requeridos para la ejecución del stored procedure.</param>
        /// <returns>Cantidad de filas que fueron modificadas por el stored procedure.</returns>
        int ExecuteNonQuery(string procName, IEnumerable<DatabaseParameter> parameters);

        /// <summary>
        /// Crea un nuevo objeto de tipo <see cref="SqlDataReader"/> para poder recorrer los resultados del stored procedure.
        /// </summary>
        /// <param name="procName">Nombre del stored procedure que va a ser ejecutado.</param>
        /// <param name="parameters">Parámetros requeridos para la ejecución del stored procedure.</param>
        /// <returns>
        /// Devuelve una instancia de tipo <see cref="SqlDataReader"/> con los resultados obtenidos de la ejecución del stored procedure.
        /// </returns>
        SqlDataReader ExecuteReader(string procName, IEnumerable<DatabaseParameter> parameters = null);

        /// <summary>
        /// Ejecuta un stored procedure que devuelve el objeto retornado en la primer celda de la primer fila devuelta por el stored procedure.
        /// </summary>
        /// <param name="procName">Nombre del stored procedure que va a ser ejecutado.</param>
        /// <param name="parameters">Parámetros requeridos para la ejecución del stored procedure.</param>
        /// <returns>Valor devuelto en la primer celda de la primera fila después de la ejecución del stored procedure.</returns>
        object ExecuteScalar(string procName, IEnumerable<DatabaseParameter> parameters);
    }
}