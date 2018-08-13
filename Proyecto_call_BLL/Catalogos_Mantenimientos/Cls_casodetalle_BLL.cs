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

        }

        public void insertar_casodetalle(ref Cls_casodetalle_DAL Obj_casodetalle_DAL)
        {

        }

        public void eliminar_casodetalle(ref Cls_casodetalle_DAL Obj_casodetalle_DAL)
        {

        }
    }
}
