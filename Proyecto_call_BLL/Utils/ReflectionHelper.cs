using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Uam.Programacion.Proyecto.Models.Attributes;

namespace Proyecto_call_BLL.Utils
{
    internal static class ReflectionHelper
    {
        internal static IEnumerable<PropertyInfo> GetSelectParameters<T>()
        {
            return typeof(T).GetProperties().Where(p => p.GetCustomAttributes(typeof(SelectParameterAttribute), false).Any()).ToList();
        }

        internal static IEnumerable<PropertyInfo> GetInsertParameters<T>()
        {
            return typeof(T).GetProperties().Where(p => p.GetCustomAttributes(typeof(InsertParameterAttribute), false).Any()).ToList();
        }

        internal static IEnumerable<PropertyInfo> GetUpdateParameters<T>()
        {
            return typeof(T).GetProperties().Where(p => p.GetCustomAttributes(typeof(UpdateParameterAttribute), false).Any()).ToList();
        }

        internal static IEnumerable<PropertyInfo> GetDeleteParameters<T>()
        {
            return typeof(T).GetProperties().Where(p => p.GetCustomAttributes(typeof(DeleteParameterAttribute), false).Any()).ToList();
        }
    }
}