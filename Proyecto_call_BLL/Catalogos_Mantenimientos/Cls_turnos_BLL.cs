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
    public class Cls_turnos_BLL
    {
        public void listar_turnos(ref Cls_turnos_DAL Obj_turnos_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Turnos";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_TURNOS";

            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_turnos_DAL.smsjError = string.Empty;
                Obj_turnos_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_turnos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void filtrar_turnos(ref Cls_turnos_DAL Obj_turnos_DAL, string sfiltro)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Turnos";
            Obj_bd_DAL.ssentencia = "SP_FILTRAR_TURNOS";

            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Turno", "1", sfiltro);


            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_turnos_DAL.smsjError = string.Empty;
                Obj_turnos_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_turnos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void modificar_turnos(ref Cls_turnos_DAL Obj_turnos_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Turnos";
            Obj_bd_DAL.ssentencia = "SP_MODIFICAR_TURNOS";

            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Turno", "2", Obj_turnos_DAL.cId_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Turno", "1", Obj_turnos_DAL.sDesc_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Cant_Horas", "3", Obj_turnos_DAL.sDesc_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@HoraEntrada", "1", Obj_turnos_DAL.sDesc_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@HoraSalida", "1", Obj_turnos_DAL.sDesc_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", "2", Obj_turnos_DAL.sDesc_Turno);

            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_turnos_DAL.bbandera = true;
                Obj_turnos_DAL.smsjError = string.Empty;
                Obj_turnos_DAL.Ds = Obj_bd_DAL.dst;
                Obj_turnos_DAL.cAxn = 'U';
            }
            else
            {
                Obj_turnos_DAL.bbandera = false;
                Obj_turnos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_turnos_DAL.Ds = null;
                Obj_turnos_DAL.cAxn = 'I';
            }
        }

        public void insertar_turnos(ref Cls_turnos_DAL Obj_turnos_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Turnos";
            Obj_bd_DAL.ssentencia = "SP_MODIFICAR_TURNOS";

            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Turno", "2", Obj_turnos_DAL.cId_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Desc_Turno", "1", Obj_turnos_DAL.sDesc_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Cant_Horas", "3", Obj_turnos_DAL.sDesc_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@HoraEntrada", "1", Obj_turnos_DAL.sDesc_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@HoraSalida", "1", Obj_turnos_DAL.sDesc_Turno);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Estado", "2", Obj_turnos_DAL.sDesc_Turno);

            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_turnos_DAL.bbandera = true;
                Obj_turnos_DAL.smsjError = string.Empty;
                Obj_turnos_DAL.Ds = Obj_bd_DAL.dst;
                Obj_turnos_DAL.cAxn = 'U';
            }
            else
            {
                Obj_turnos_DAL.bbandera = false;
                Obj_turnos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_turnos_DAL.Ds = null;
                Obj_turnos_DAL.cAxn = 'I';
            }
        }

        public void eliminar_turnos(ref Cls_turnos_DAL Obj_turnos_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Turnos";
            Obj_bd_DAL.ssentencia = "SP_ELIMINAR_TURNOS";

            Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
            Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Turno", "2", Obj_turnos_DAL.cId_Turno);

            Obj_bd_BLL.Exe_NonQuery(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_turnos_DAL.bbandera = true;
                Obj_turnos_DAL.smsjError = string.Empty;
                Obj_turnos_DAL.cAxn = 'D';
            }
            else
            {
                Obj_turnos_DAL.bbandera = false;
                Obj_turnos_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_turnos_DAL.cAxn = 'D';
            }
        }
    }
}
