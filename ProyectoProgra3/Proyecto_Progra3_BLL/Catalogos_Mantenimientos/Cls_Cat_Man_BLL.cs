using Proyecto_Progra3_DAL.BD;
using Proyecto_Progra3_BLL.BD;
using Proyecto_Progra3_DAL.Catalogos_Mantenimientos;

namespace Proyecto_Progra3_BLL.Catalogos_Mantenimientos
{
    public class Cls_Cat_Man_BLL
    {
        public void listar_Cat_Man(ref Cls_Cat_Man_DAL Obj_Cat_Man_DAL, string sSentencia)
        { 
            Cls_bd_BLL Obj_BD_BLL = new Cls_bd_BLL();
            Cls_bd_DAL Obj_BD_DAL = new Cls_bd_DAL();
            // Esta nombre es el del datatable, no tiene que se el nombre real
            Obj_BD_DAL.snombretabla = "Tbl"; 
            Obj_BD_DAL.ssentencia = "SP_LISTAR_" + sSentencia;
            Obj_BD_BLL.Ejecutar_adapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.smsjError == string.Empty)
            {
                Obj_Cat_Man_DAL.sMsjError = string.Empty;
                Obj_Cat_Man_DAL.Obj_DS = Obj_BD_DAL.Data_set;
            }
            else
            {
                Obj_Cat_Man_DAL.sMsjError = string.Empty;
                Obj_Cat_Man_DAL.Obj_DS = null;
            }
        }
        public void filtrar_Cat_Man(ref Cls_Cat_Man_DAL Obj_Cat_Man_DAL, 
            string sFiltro, string sSentencia, string sParam)
        {
            Cls_bd_BLL Obj_BD_BLL = new Cls_bd_BLL();
            Cls_bd_DAL Obj_BD_DAL = new Cls_bd_DAL();
            Obj_BD_DAL.snombretabla = "Tbl";
            Obj_BD_DAL.ssentencia = "SP_FILTRAR_" + sSentencia;
            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_DTParametros.Rows.Add(sParam, 1, sFiltro);
            Obj_BD_BLL.Ejecutar_adapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.smsjError == string.Empty)
            {
                Obj_Cat_Man_DAL.sMsjError = string.Empty;
                Obj_Cat_Man_DAL.Obj_DS = Obj_BD_DAL.Data_set;

            }
            else
            {
                Obj_Cat_Man_DAL.sMsjError = Obj_BD_DAL.smsjError;
                Obj_Cat_Man_DAL.Obj_DS = null;
            }
        }
        public void insertar_Cat_Man(ref Cls_Cat_Man_DAL Obj_activo_DAL)
        {

        }
        public void modificar_Cat_Man(ref Cls_Cat_Man_DAL Obj_activo_DAL)
        {

        }
        public void eliminar_activos(ref Cls_Cat_Man_DAL Obj_activo_DAL)
        {

        }
    }
}
