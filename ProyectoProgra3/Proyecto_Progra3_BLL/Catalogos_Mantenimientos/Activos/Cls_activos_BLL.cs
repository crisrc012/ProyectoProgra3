using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Progra3_DAL.BD;
using Proyecto_Progra3_BLL.BD;
using Proyecto_Progra3_DAL.Catalogos_Mantenimientos.Activos;



namespace Proyecto_Progra3_BLL.Catalogos_Mantenimientos.Activos
{
    public class Cls_activos_BLL
    {
        public void listar_activos(ref Cls_activos_DAL Obj_activo_DAL)
        {
            Cls_bd_BLL Obj_BD_BLL = new Cls_bd_BLL();
            Cls_bd_DAL Obj_BD_DAL = new Cls_bd_DAL();
            Obj_BD_DAL.snombretabla = "Tbl_Activos";
            Obj_BD_DAL.ssentencia = "SP_LISTAR_ACTIVOS";
            Obj_BD_BLL.Ejecutar_adapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.smsjError== string.Empty)
            {
                Obj_activo_DAL.sMsjError = string.Empty;
                Obj_activo_DAL.Obj_DS = Obj_BD_DAL.Data_set;
            }
            else
            {
                Obj_activo_DAL.sMsjError = string.Empty;
                Obj_activo_DAL.Obj_DS = null;
            }
        }
        public void filtrar_activos(ref Cls_activos_DAL Obj_activo_DAL, string sFiltro)
        {
            Cls_bd_BLL Obj_BD_BLL = new Cls_bd_BLL();
            Cls_bd_DAL Obj_BD_DAL = new Cls_bd_DAL();
            Obj_BD_DAL.snombretabla = "Tbl_Activos";
            Obj_BD_DAL.ssentencia = "SP_FILTRAR_ACTIVOS";
            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_DTParametros.Rows.Add("@Desc_Activo", 1, sFiltro);
            Obj_BD_BLL.Ejecutar_adapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.smsjError ==string.Empty)
            {
                Obj_activo_DAL.sMsjError = string.Empty;
                Obj_activo_DAL.Obj_DS = Obj_BD_DAL.Data_set;

            }
            else
            {
                Obj_activo_DAL.sMsjError = Obj_BD_DAL.smsjError;
                Obj_activo_DAL.Obj_DS = null;
            }
        }
        public void insertar_activos(ref Cls_activos_DAL Obj_activo_DAL)
        {

        }
        public void modificar_activos(ref Cls_activos_DAL Obj_activo_DAL)
        {

        }
        public void eliminar_activos(ref Cls_activos_DAL Obj_activo_DAL)
        {

        }
    }
}
