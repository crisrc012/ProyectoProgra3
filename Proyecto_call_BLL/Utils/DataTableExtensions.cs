using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Proyecto_call_BLL.Utils
{
    public static class DataTableExtensions
    {
        /// <summary>
        /// Convierte los resultados almacenados en un objeto de tipo <see cref="DataTable"/> a una implementación de la interfaz IList de tipo <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos al que van a ser convertidas las filas almacenas en <paramref name="table"/>.</typeparam>
        /// <param name="table">Objeto de tipo <see cref="DataTable"/> con los valores almacenados que van a ser convertidos.</param>
        /// <returns>Implementación de la interfaz IList del tipo <typeparamref name="T"/>.</returns>
        public static IList<T> ToList<T>(this DataTable table) where T : new()
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();

            return (from object row in table.Rows select CreateItemFromRow<T>((DataRow)row, properties)).ToList();
        }


        private static T CreateItemFromRow<T>(DataRow row, IEnumerable<PropertyInfo> properties) where T : new()
        {
            var item = new T();

            foreach (var property in properties)
            {
                if (!row.Table.Columns.Contains(property.Name))
                    continue;

                var value = row[property.Name] != DBNull.Value ? row[property.Name] : null;
                property.SetValue(item, value, null);
            }

            return item;
        }
    }
}