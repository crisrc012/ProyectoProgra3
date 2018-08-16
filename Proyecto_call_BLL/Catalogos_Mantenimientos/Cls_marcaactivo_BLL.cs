using Proyecto_call_BLL.BD;
using Proyecto_call_DAL.BD;
using Proyecto_call_DAL.Catalogos_Mantenimientos;

namespace Proyecto_call_BLL.Catalogos_Mantenimientos
{
    public class Cls_marcaactivo_BLL
    {
        #region Variables Globales
        Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
        Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();
        #endregion
        public void listar_marcaactivo(ref Cls_marcaactivo_DAL Obj_marcaactivo_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();
            Obj_bd_DAL.snombretabla = "marcaactivo";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_MARCAACTIVO";
            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_marcaactivo_DAL.smsjError = string.Empty;
                Obj_marcaactivo_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_marcaactivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void filtrar_marcaactivo(ref Cls_marcaactivo_DAL Obj_marcaactivo_DAL, string sfiltro)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();
            Obj_bd_DAL.snombretabla = "marcaactivo";
            Obj_bd_DAL.ssentencia = "SP_FILTRAR_MARCAACTIVO";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_MarcaActivo", "1", sfiltro);
            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_marcaactivo_DAL.smsjError = string.Empty;
                Obj_marcaactivo_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_marcaactivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void modificar_marcaactivo(ref Cls_marcaactivo_DAL Obj_marcaactivo_DAL)
        {
            Obj_bd_DAL = new Cls_BD_DAL();
            Obj_bd_DAL.snombretabla = "marcaactivo";
            Obj_bd_DAL.ssentencia = "SP_MODIFICAR_MARCAACTIVO";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_MarcaActivo", 3, Obj_marcaactivo_DAL.iId_MarcaActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_MarcaActivo", 1, Obj_marcaactivo_DAL.sDesc_MarcaActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", 2, Obj_marcaactivo_DAL.cId_Estado);
            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_marcaactivo_DAL.bbandera = true;
                Obj_marcaactivo_DAL.smsjError = string.Empty;
                Obj_marcaactivo_DAL.Ds = Obj_bd_DAL.dst;
                Obj_marcaactivo_DAL.cAxn = 'U';
            }
            else
            {
                Obj_marcaactivo_DAL.bbandera = false;
                Obj_marcaactivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_marcaactivo_DAL.Ds = null;
                Obj_marcaactivo_DAL.cAxn = 'I';
            }
        }

        public void insertar_marcaactivo(ref Cls_marcaactivo_DAL Obj_marcaactivo_DAL)
        {
            Obj_bd_DAL = new Cls_BD_DAL();
            Obj_bd_DAL.snombretabla = "marcaactivo";
            Obj_bd_DAL.ssentencia = "SP_INSERTAR_MARCAACTIVO";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_MarcaActivo", 1, Obj_marcaactivo_DAL.sDesc_MarcaActivo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", 2, Obj_marcaactivo_DAL.cId_Estado);
            Obj_bd_BLL.Exe_Scalar(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_marcaactivo_DAL.bbandera = true;
                Obj_marcaactivo_DAL.smsjError = string.Empty;
                Obj_marcaactivo_DAL.Ds = Obj_bd_DAL.dst;
                Obj_marcaactivo_DAL.cAxn = 'U';
            }
            else
            {
                Obj_marcaactivo_DAL.bbandera = false;
                Obj_marcaactivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_marcaactivo_DAL.Ds = null;
                Obj_marcaactivo_DAL.cAxn = 'I';
            }
        }

        public void eliminar_marcaactivo(ref Cls_marcaactivo_DAL Obj_marcaactivo_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();
            Obj_bd_DAL.snombretabla = "marcaactivo";
            Obj_bd_DAL.ssentencia = "SP_ELIMINAR_MARCAACTIVO";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_MarcaActivo", "3", Obj_marcaactivo_DAL.iId_MarcaActivo);
            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_marcaactivo_DAL.bbandera = true;
                Obj_marcaactivo_DAL.smsjError = string.Empty;
                Obj_marcaactivo_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_marcaactivo_DAL.bbandera = false;
                Obj_marcaactivo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_marcaactivo_DAL.Ds = null;
            }


        }
    }
}
