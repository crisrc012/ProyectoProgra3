using Proyecto_call_BLL.BD;
using Proyecto_call_DAL.BD;
using Proyecto_call_DAL.Catalogos_Mantenimientos;

namespace Proyecto_call_BLL.Catalogos_Mantenimientos
{
    public class Cls_estados_BLL
    {
        #region Variables Globales
        Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
        Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();
        #endregion
        public void listar_estados(ref Cls_estados_DAL Obj_estados_DAL)
        {
            Obj_bd_DAL = new Cls_BD_DAL();
            Obj_bd_DAL.snombretabla = "estados";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_ESTADOS";
            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_estados_DAL.smsjError = string.Empty;
                Obj_estados_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_estados_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void filtrar_estados(ref Cls_estados_DAL Obj_estados_DAL, string sfiltro)
        {
            Obj_bd_DAL = new Cls_BD_DAL();
            Obj_bd_DAL.snombretabla = "estados";
            Obj_bd_DAL.ssentencia = "SP_FILTRAR_ESTADOS";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Estado", "1", sfiltro);
            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_estados_DAL.smsjError = string.Empty;
                Obj_estados_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_estados_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void modificar_estados(ref Cls_estados_DAL Obj_estados_DAL)
        {
            Obj_bd_DAL = new Cls_BD_DAL();
            Obj_bd_DAL.snombretabla = "estados";
            Obj_bd_DAL.ssentencia = "SP_MODIFICAR_ESTADOS";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", 2, Obj_estados_DAL.cId_Estado);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Estado", 1, Obj_estados_DAL.sDesc_Estado);
            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_estados_DAL.bbandera = true;
                Obj_estados_DAL.smsjError = string.Empty;
                Obj_estados_DAL.Ds = Obj_bd_DAL.dst;
                Obj_estados_DAL.cAxn = 'U';
            }
            else
            {
                Obj_estados_DAL.bbandera = false;
                Obj_estados_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_estados_DAL.Ds = null;
                Obj_estados_DAL.cAxn = 'I';
            }
        }

        public void insertar_estados(ref Cls_estados_DAL Obj_estados_DAL)
        {
            Obj_bd_DAL = new Cls_BD_DAL();
            Obj_bd_DAL.snombretabla = "estados";
            Obj_bd_DAL.ssentencia = "SP_INSERTAR_ESTADOS";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Estado", 1, Obj_estados_DAL.sDesc_Estado);
            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_estados_DAL.bbandera = true;
                Obj_estados_DAL.smsjError = string.Empty;
                Obj_estados_DAL.Ds = Obj_bd_DAL.dst;
                Obj_estados_DAL.cAxn = 'U';
            }
            else
            {
                Obj_estados_DAL.bbandera = false;
                Obj_estados_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_estados_DAL.Ds = null;
                Obj_estados_DAL.cAxn = 'I';
            }
        }

        public void eliminar_estados(ref Cls_estados_DAL Obj_estados_DAL)
        {
            Obj_bd_DAL = new Cls_BD_DAL();
            Obj_bd_DAL.snombretabla = "estados";
            Obj_bd_DAL.ssentencia = "SP_ELIMINAR_ESTADOS";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", "2", Obj_estados_DAL.cId_Estado);
            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_estados_DAL.bbandera = true;
                Obj_estados_DAL.smsjError = string.Empty;
                Obj_estados_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_estados_DAL.bbandera = false;
                Obj_estados_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_estados_DAL.Ds = null;
            }
        }
    }
}
