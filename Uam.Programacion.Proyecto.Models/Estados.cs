using System.Collections.Generic;
using Uam.Programacion.Proyecto.Models.Enums;
using Uam.Programacion.Proyecto.Models.Interfaces;

namespace Uam.Programacion.Proyecto.Models
{
    public class Estados : IEntity<string>
    {
        public string Id { get; set; }

        public string Descripcion { get; set; }

        public Dictionary<Command, string> Mappings => new Dictionary<Command, string> { { Command.Select, "SP_GET_ESTADOS" } };
    }
}