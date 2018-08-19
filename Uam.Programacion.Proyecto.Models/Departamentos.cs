using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Uam.Programacion.Proyecto.Models.Attributes;
using Uam.Programacion.Proyecto.Models.Enums;
using Uam.Programacion.Proyecto.Models.Interfaces;

namespace Uam.Programacion.Proyecto.Models
{
    public class Departamentos : IEntity<int>
    {
        [DeleteParameter(ParamName = "Id", Type = DbType.Int32)]
        [SelectParameter(ParamName = "Id", Type = DbType.Int32)]
        [UpdateParameter(ParamName = "Id", Type = DbType.Int32)]
        public int Id { get; set; }

        [SelectParameter(ParamName = "Desc", Type = DbType.String)]
        [InsertParameter(ParamName = "Descripcion", Type = DbType.String)]
        [UpdateParameter(ParamName = "Descripcion", Type = DbType.String)]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [InsertParameter(ParamName = "IdEstado", Type = DbType.String)]
        [UpdateParameter(ParamName = "IdEstado", Type = DbType.String)]
        [DisplayName("ID del Estado")]
        public string Estado { get; set; }

        [DisplayName("Creado Por Usuario")]
        public string CreadoUsuario { get; set; }

        [InsertParameter(ParamName = "FechaCreacion", Type = DbType.DateTime)]
        [DisplayName("Fecha Creación")]
        public DateTime? FechaCreacion { get; set; }

        [DisplayName("Modificado Por Usuario")]
        public string ModificadoUsuario { get; set; }

        [UpdateParameter(ParamName = "FechaModificacion", Type = DbType.DateTime)]
        [DisplayName("Fecha Modificación")]
        public DateTime? FechaModificacion { get; set; }

        [Browsable(false)]
        public Dictionary<Command, string> Mappings => new Dictionary<Command, string>
        {
            { Command.Select, "SP_LISTAR_DEPARTAMENTOS" },
            { Command.Update, "SP_MODIFICAR_DEPARTAMENTO" },
            { Command.Insert, "SP_INSERTAR_DEPARTAMENTO" },
            { Command.Delete, "SP_BORRAR_DEPARTAMENTOS" }
        };
    }
}
