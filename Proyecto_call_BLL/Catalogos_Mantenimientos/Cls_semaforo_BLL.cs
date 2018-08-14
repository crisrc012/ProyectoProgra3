using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using Proyecto_call_BLL.BD;
using Proyecto_call_DAL.BD;


namespace Proyecto_call_BLL.Catalogos_Mantenimientos
{
    public class Cls_semaforo_BLL
    {
        public void Listar_Semaforo(ref Cls_semaforo_DAL Obj_semaforo_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Tbl_SemaforoCasos";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_SEMAFOROCASOS";

            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_semaforo_DAL.smsjError = string.Empty;
                Obj_semaforo_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_semaforo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void Filtrar_Semaforo(ref Cls_semaforo_DAL Obj_semaforo_DAL, string sfiltro)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Tbl_SemaforoCasos";
            Obj_bd_DAL.ssentencia = "SP_FILTRAR_SEMAFOROCASOS";

            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Estado_SemaforoCaso", "1", sfiltro);


            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_semaforo_DAL.smsjError = string.Empty;
                Obj_semaforo_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_semaforo_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void Eliminar_Semaforo(ref Cls_semaforo_DAL Obj_semaforo_DAL)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.snombretabla = "Tbl_SemaforoCasos";
            Obj_BD_DAL.ssentencia = "SP_ELIMINAR_SEMAFORO";
            Obj_BD_BLL.crear_tabla(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@Id_Semaforo", 2, Obj_semaforo_DAL.cId_Estado_SemaforoCaso);
            Obj_BD_BLL.Exe_NonQuery(ref Obj_BD_DAL);
            if (Obj_BD_DAL.smsjerror == string.Empty)
            {
                Obj_semaforo_DAL.smsjError = string.Empty;
                Obj_semaforo_DAL.bbandera = true;
                Obj_semaforo_DAL.cAxn = 'D';
            }
            else
            {
                Obj_semaforo_DAL.smsjError = Obj_BD_DAL.smsjerror;
                Obj_semaforo_DAL.bbandera = false;
                Obj_semaforo_DAL.cAxn = 'D';
            }
        }
    }
}
