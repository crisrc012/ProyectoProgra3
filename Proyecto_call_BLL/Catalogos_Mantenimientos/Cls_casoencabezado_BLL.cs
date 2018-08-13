using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_call_DAL.BD;
using Proyecto_call_BLL.BD;
using Proyecto_call_DAL.Catalogos_Mantenimientos;

namespace Proyecto_call_BLL.Catalogos_Mantenimientos
{
    public class Cls_casoencabezado_BLL
    {
        public void listar_casoencabezado(ref Cls_casoencabezado_DAL Obj_casoencabezado_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Encabezado del caso";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_CASO_ENCABEZADO";

            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_casoencabezado_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_casoencabezado_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_casoencabezado_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }

        }

        public void filtrar_casoencabezado(ref Cls_casodetalle_DAL Obj_casoencabezado_DAL)
        {

        }

        public void modificar_casoencabezado(ref Cls_casodetalle_DAL Obj_casoencabezado_DAL)
        {

        }

        public void insertar_casoencabezado(ref Cls_casodetalle_DAL Obj_casoencabezado_DAL)
        {

        }

        public void eliminar_casoencabezado(ref Cls_casodetalle_DAL Obj_casoencabezado_DAL)
        {

        }
    }
}
