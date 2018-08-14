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
    public class Cls_operadores_BLL
    {
        public void Listar_operadores(ref Cls_operadores_DAL Obj_operadores_DAL)
        {
            Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

            Obj_bd_DAL.snombretabla = "Tbl_Operadores";
            Obj_bd_DAL.ssentencia = "SP_LISTAR_OPERADORES";

            Obj_bd_BLL.Adapt(ref Obj_bd_DAL);

            if (Obj_bd_DAL.smsjerror == string.Empty)
            {
                Obj_operadores_DAL.smsjError = string.Empty;
                Obj_operadores_DAL.Ds = Obj_bd_DAL.dst;
            }
            else
            {
                Obj_operadores_DAL.smsjError = Obj_bd_DAL.smsjerror;
                Obj_bd_DAL.dst = null;
            }
        }

        public void Filtrar_Operadores(ref Cls_operadores_DAL Obj_operadores_DAL, string sfiltro)
            {
                Cls_BD_DAL Obj_bd_DAL = new Cls_BD_DAL();
                Cls_BD_BLL Obj_bd_BLL = new Cls_BD_BLL();

                Obj_bd_DAL.snombretabla = "Tbl_Operadores";
                Obj_bd_DAL.ssentencia = "SP_FILTRAR_OPERADORES";

                Obj_bd_BLL.crear_tabla(ref Obj_bd_DAL);
                Obj_bd_DAL.Obj_dtparam.Rows.Add("@Id_Operador", "1", sfiltro);


                Obj_bd_BLL.Adapt(ref Obj_bd_DAL);
                if (Obj_bd_DAL.smsjerror == string.Empty)
                {
                    Obj_operadores_DAL.smsjError = string.Empty;
                    Obj_operadores_DAL.Ds = Obj_bd_DAL.dst;
                }
                else
                {
                    Obj_operadores_DAL.smsjError = Obj_bd_DAL.smsjerror;
                    Obj_bd_DAL.dst = null;
                }
            }

        public void Insertar_Operadores(ref Cls_operadores_DAL Obj_Operadores_DAL)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.snombretabla = "Tbl_Operadores";
            Obj_BD_DAL.ssentencia = "SP_Eliminar_OPERADOR";
            Obj_BD_BLL.crear_tabla(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@Id_Operador", 2, Obj_Operadores_DAL.sId_Operador);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@Id_Nombre", 1, Obj_Operadores_DAL.sNombre_Operador);
            Obj_BD_BLL.Exe_NonQuery(ref Obj_BD_DAL);
            if (Obj_BD_DAL.smsjerror == string.Empty)
            {
                Obj_Operadores_DAL.smsjError = string.Empty;
                Obj_Operadores_DAL.Ds = Obj_BD_DAL.dst;
                Obj_Operadores_DAL.sAx = "U";
            }
            else
            {
                Obj_Operadores_DAL.smsjError = Obj_BD_DAL.smsjerror;
                Obj_Operadores_DAL.Ds = null;
                Obj_Operadores_DAL.sAx = "I";
            }
        }

        public void Eliminar_Operadores(ref Cls_operadores_DAL Obj_operadores_DAL)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.snombretabla = "Tbl_Operadores";
            Obj_BD_DAL.ssentencia = "SP_ELIMINAR_OPERADOR";
            Obj_BD_BLL.crear_tabla(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@Id_Operador", 2, Obj_operadores_DAL.sId_Operador);
            Obj_BD_BLL.Exe_NonQuery(ref Obj_BD_DAL);
            if (Obj_BD_DAL.smsjerror == string.Empty)
            {
                Obj_operadores_DAL.smsjError = string.Empty;
                Obj_operadores_DAL.bbandera = true;
                Obj_operadores_DAL.sAx = "D";
            }
            else
            {
                Obj_operadores_DAL.smsjError = Obj_BD_DAL.smsjerror;
                Obj_operadores_DAL.bbandera = false;
                Obj_operadores_DAL.sAx = "D";
            }

        }

     }
}
