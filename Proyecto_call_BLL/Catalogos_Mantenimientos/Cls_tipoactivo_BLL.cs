using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using Proyecto_call_DAL.BD;
using Proyecto_call_BLL.BD;

namespace Proyecto_call_BLL.Catalogos_Mantenimientos
{
    public class Cls_tipoactivo_BLL
    {
        public void listar_Tipoactivo(ref Cls_tipoactivo_DAL Obj_TipoActivo_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "TipoActivos";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_TIPOACTIVO";

            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_TipoActivo_DAL.smsjError = string.Empty;
                Obj_TipoActivo_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_TipoActivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }
        public void filtrar_Tipoactivos(ref Cls_tipoactivo_DAL Obj_TipoActivo_DAL, string sfiltro)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Activos";
            Obj_bd_DAL.ssentencia = "SP_FILTRAR_TIPOACTIVO";

            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_TipoActivo", "1", sfiltro);


            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_TipoActivo_DAL.smsjError = string.Empty;
                Obj_TipoActivo_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_TipoActivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }
        public void eliminar_Tipoactivos(ref Cls_tipoactivo_DAL Obj_TipoaAtivos_DAL, string valor)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Activos";
            Obj_bd_DAL.ssentencia = "SP_ELIMINAR_TIPOACTIVOS";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_TipoActivo", "3", valor);

            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_TipoaAtivos_DAL.smsjError = string.Empty;
                Obj_TipoaAtivos_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_TipoaAtivos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_TipoaAtivos_DAL.Ds = null;
            }


        }
        public void insertar_Tipoactivos(ref Cls_tipoactivo_DAL Obj_tipoActivo_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();
            Obj_bd_DAL.snombretabla = "TipoActivo";
            Obj_bd_DAL.ssentencia = "SP_INSERTAR_TIPOACTIVO";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_tipoActivo", 1, Obj_tipoActivo_DAL.sDesc_TipoActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", 2, Obj_tipoActivo_DAL.cId_Estado);
            Obj_bd_BLL.Exe_Scalar(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_tipoActivo_DAL.bbandera = true;
                Obj_tipoActivo_DAL.smsjError = string.Empty;
                Obj_tipoActivo_DAL.Ds = Obj_bd_DAL.dst;
                Obj_tipoActivo_DAL.cAxn = 'U';
            }
            else
            {
                Obj_tipoActivo_DAL.bbandera = false;
                Obj_tipoActivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_tipoActivo_DAL.Ds = null;
                Obj_tipoActivo_DAL.cAxn = 'I';
            }
        }
        public void modificar_Tipoactivos(ref Cls_tipoactivo_DAL Obj_TipoActivo_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();
            Obj_bd_DAL.snombretabla = "TIPOACTIVOS";
            Obj_bd_DAL.ssentencia = "SP_MODIFICAR_TIPOACTIVOS";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_TipoActivo", 3, Obj_TipoActivo_DAL.iId_TipoActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_TipoActivo", 1, Obj_TipoActivo_DAL.sDesc_TipoActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", 2, Obj_TipoActivo_DAL.cId_Estado);
            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_TipoActivo_DAL.bbandera = true;
                Obj_TipoActivo_DAL.smsjError = string.Empty;
                Obj_TipoActivo_DAL.Ds = Obj_bd_DAL.dst;
                Obj_TipoActivo_DAL.cAxn = 'U';
            }
            else
            {
                Obj_TipoActivo_DAL.bbandera = false;
                Obj_TipoActivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_TipoActivo_DAL.Ds = null;
                Obj_TipoActivo_DAL.cAxn = 'I';
            }
        }

    }
}
