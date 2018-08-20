using System;
using System.Data;

namespace Uam.Programacion.Proyecto.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DeleteParameterAttribute : Attribute
    {
        public string ParamName { get; set; }

        public DbType Type { get; set; }
    }
}