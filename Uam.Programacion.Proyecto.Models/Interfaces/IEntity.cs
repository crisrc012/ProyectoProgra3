using System.Collections.Generic;
using Uam.Programacion.Proyecto.Models.Enums;

namespace Uam.Programacion.Proyecto.Models.Interfaces
{
    public interface IEntity<T>
    {
        /// <summary>
        /// Campo para identificar a la instancia única.
        /// </summary>
        T Id { get; set;  }

        /// <summary>
        /// Campo para hacer un mapeo entre una operación de base de datos con un stored procedure.
        /// </summary>
        Dictionary<Command, string> Mappings { get; }
    }
}