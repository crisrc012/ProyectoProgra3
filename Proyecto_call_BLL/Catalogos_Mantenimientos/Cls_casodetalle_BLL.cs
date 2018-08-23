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
    public class Cls_casodetalle_BLL
    {
        public void listar_casodetalle(ref Cls_casodetalle_DAL Obj_casodetalle_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();
            
            Obj_bd_DAL.snombretabla = "Caso Detallado";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_CASO_DETALLE";

            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_casodetalle_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_casodetalle_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_casodetalle_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }

        }

        public void filtrar_casodetalle(ref Cls_casodetalle_DAL Obj_casodetalle_DAL, string sfiltro)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Caso detalle";
            Obj_bd_DAL.ssentencia = "SP_FILTRAR_CASO_DETALLE";

            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Observaciones", "1", sfiltro);

            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_casodetalle_DAL.smsjError = string.Empty;
                Obj_casodetalle_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_casodetalle_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void modificar_casodetalle(ref Cls_casodetalle_DAL Obj_casodetalle_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Caso a detalle";
            Obj_bd_DAL.ssentencia = "SP_MODIFICAR_CASO_DETALLE";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);

            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Placa_Activo", 3, Obj_casodetalle_DAL.iPlaca_Activo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Observaciones", 1, Obj_casodetalle_DAL.sObservaciones);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@FecCreacion", 4, Obj_casodetalle_DAL.dFecCreacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@UsuCreacion", 1, Obj_casodetalle_DAL.sUsuCreacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@FecModificacion", 1, "");
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@UsuModificacion", 1, "");
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Caso_Enc", 3, Obj_casodetalle_DAL.iId_Caso_Enc);

            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_casodetalle_DAL.smsjError = string.Empty;
                Obj_casodetalle_DAL.Ds = Obj_bd_DAL.dst;
                Obj_casodetalle_DAL.bbandera = false;
            }
            else
            {
                Obj_casodetalle_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_casodetalle_DAL.Ds = null;
                Obj_casodetalle_DAL.bbandera = false;
            }

        }

        public void insertar_casodetalle(ref Cls_casodetalle_DAL Obj_casodetalle_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Caso a detalle";
            Obj_bd_DAL.ssentencia = "SP_INSERTAR_CASO_DETALLE";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);

            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Caso_Enc",3,Obj_casodetalle_DAL.iId_Caso_Enc);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Placa_Activo",3,Obj_casodetalle_DAL.iPlaca_Activo);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Observaciones",1,Obj_casodetalle_DAL.sObservaciones);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@FecCreacion", 4, Obj_casodetalle_DAL.dFecCreacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@UsuCreacion",1,Obj_casodetalle_DAL.sUsuCreacion);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@FecModificacion",1,"");
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@UsuModificacion",1,"");

            Obj_bd_BLL.Exe_Scalar(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {    
                Obj_casodetalle_DAL.iId_Caso_Enc = Obj_bd_DAL.ivalorscalar;
                Obj_casodetalle_DAL.smsjError = string.Empty;
                Obj_casodetalle_DAL.Ds = Obj_bd_DAL.dst;
                Obj_casodetalle_DAL.bbandera = false;
            }
            else
            {
                Obj_casodetalle_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_casodetalle_DAL.Ds = null;
                Obj_casodetalle_DAL.bbandera = false;
            }
        }

        public void eliminar_casodetalle(ref Cls_casodetalle_DAL Obj_casodetalle_DAL, string valor)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Caso al detalle";
            Obj_bd_DAL.ssentencia = "SP_ELIMINAR_CASO_DETALLE";
            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);

            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Caso_Det", 3, valor);
            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_casodetalle_DAL.smsjError = string.Empty;
                Obj_casodetalle_DAL.Ds = Obj_bd_DAL.dst;
                Obj_casodetalle_DAL.bbandera = true;
            }
            else
            { 
                Obj_casodetalle_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_casodetalle_DAL.Ds = null;
                Obj_casodetalle_DAL.bbandera = false;
            }
        }
    }
}
