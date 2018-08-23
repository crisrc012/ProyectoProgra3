using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using Proyecto_call_DAL.BD;
using Proyecto_call_BLL.BD;

namespace Proyecto_call_BLL.Catalogos_Mantenimientos
{

    public class Cls_activos_BLL
    {
        public void listar_activos(ref Cls_activos_DAL Obj_activos_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Activos";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_ACTIVOS";

            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_activos_DAL.smsjError = string.Empty;
                Obj_activos_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_activos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void filtrar_activos(ref Cls_activos_DAL Obj_activos_DAL, string sfiltro)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Activos";
            Obj_bd_DAL.ssentencia = "SP_FILTRAR_ACTIVOS";

            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Activo", "1", sfiltro);


            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_activos_DAL.smsjError = string.Empty;
                Obj_activos_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_activos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void modificar_activos(ref Cls_activos_DAL Obj_activos_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Activos";
            Obj_bd_DAL.ssentencia = "SP_MODIFICAR_ACTIVO";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);

            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_TipoActivo", 3, Obj_activos_DAL.iId_TipoActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Activo", 1, Obj_activos_DAL.sDesc_Activo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_MarcaActivo", 3, Obj_activos_DAL.iId_MarcaActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Departamento_Responsable", 3, Obj_activos_DAL.iId_Departamento_Responsable);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Prioridad_SLA", 5, Obj_activos_DAL.dPrioridad_SLA);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", 2, Obj_activos_DAL.cId_Estado);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@FecCreacion", 4, Obj_activos_DAL.dFecCreacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@UsuCreacion", 1, Obj_activos_DAL.sUsuCreacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@FecModificacion", 4, Obj_activos_DAL.dFecModificacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@UsuModificacion", 1, Obj_activos_DAL.sUsuModificacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Placa_Activo", 3, Obj_activos_DAL.iPlaca_Activo);

            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_activos_DAL.smsjError = string.Empty;
                Obj_activos_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_activos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void insertar_activos(ref Cls_activos_DAL Obj_activos_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Activos";
            Obj_bd_DAL.ssentencia = "SP_INSERTAR_ACTIVO";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);

            //Obj_bd_DAL.Obj_dtparam.Rows.Add("@Placa_Activo",3,Obj_activos_DAL.iPlaca_Activo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_TipoActivo",3,Obj_activos_DAL.iId_TipoActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Activo",1,Obj_activos_DAL.sDesc_Activo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_MarcaActivo",3,Obj_activos_DAL.iId_MarcaActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Departamento_Responsable",3,Obj_activos_DAL.iId_Departamento_Responsable);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Prioridad_SLA",5,Obj_activos_DAL.dPrioridad_SLA);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado",2,Obj_activos_DAL.cId_Estado);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@FecCreacion",4,Obj_activos_DAL.dFecCreacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@UsuCreacion",1,Obj_activos_DAL.sUsuCreacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@FecModificacion",4,Obj_activos_DAL.dFecModificacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@UsuModificacion",1,"");

            Obj_bd_BLL.Exe_Scalar(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_activos_DAL.iPlaca_Activo = Obj_bd_DAL.ivalorscalar;
                Obj_activos_DAL.smsjError = string.Empty;
                Obj_activos_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_activos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void eliminar_activos(ref Cls_activos_DAL Obj_activos_DAL, string svalor)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Activos";
            Obj_bd_DAL.ssentencia = "SP_ELIMINAR_ACTIVOS";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Placa_Activo","3",svalor);

            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_activos_DAL.smsjError = string.Empty;
                Obj_activos_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_activos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_activos_DAL.Ds = null;
            }
            
            
        }
    }
}
