using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Uam.Programacion.Proyecto.Models.Attributes;
using Uam.Programacion.Proyecto.Models.Enums;
using Uam.Programacion.Proyecto.Models.Interfaces;

namespace Uam.Programacion.Proyecto.Models
{
    public class Encabezado : IEntity<int>
    {
        [DeleteParameter(ParamName = "Id", Type = DbType.Int32)]
        [UpdateParameter(ParamName = "Id", Type = DbType.Int32)]
        [SelectParameter(ParamName = "Id", Type = DbType.Int32)]
        [DisplayName("ID Encabezado")]
        public int Id { get; set; }

        [InsertParameter(ParamName = "FechaCaso", Type = DbType.DateTime)]
        [UpdateParameter(ParamName = "FechaCaso", Type = DbType.DateTime)]
        [DisplayName("Fecha Caso")]
        public DateTime? FechaCaso { get; set; }

        [InsertParameter(ParamName = "Descripcion", Type = DbType.String)]
        [UpdateParameter(ParamName = "Descripcion", Type = DbType.String)]
        [SelectParameter(ParamName = "Desc", Type = DbType.String)]
        [DisplayName("Comentarios Reporte")]
        public string Comentarios { get; set; }

        [InsertParameter(ParamName = "IdOperador", Type = DbType.String)]
        [UpdateParameter(ParamName = "IdOperador", Type = DbType.String)]
        [DisplayName("ID Operador")]
        public string Operador { get; set; }

        [InsertParameter(ParamName = "IdSemaforo", Type = DbType.String)]
        [UpdateParameter(ParamName = "IdSemaforo", Type = DbType.String)]
        [DisplayName("ID Estado Semáforo")]
        public string EstadoSemaforo { get; set; }

        [InsertParameter(ParamName = "IdEstado", Type = DbType.String)]
        [UpdateParameter(ParamName = "IdEstado", Type = DbType.String)]
        [DisplayName("ID Estado")]
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
            { Command.Select, "SP_LISTAR_ENCABEZADO" },
            { Command.Update, "SP_MODIFICAR_ENCABEZADOS" },
            { Command.Insert, "SP_INSERTAR_ENCABEZADOS" },
            { Command.Delete, "SP_BORRAR_ENCABEZADOS" }
        };
    }
}