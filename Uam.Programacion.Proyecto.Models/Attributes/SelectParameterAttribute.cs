using System;
using System.Data;

namespace Uam.Programacion.Proyecto.Models.Attributes
{
    /// <summary>
    /// Atributo custom para indicar que el campo es utilizado como parámetro para las operaciones de tipo Select.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SelectParameterAttribute : Attribute
    {
        public string ParamName { get; set; }

        public DbType Type { get; set; }
    }
}