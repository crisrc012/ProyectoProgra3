using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Proyecto_Progra3_DAL.BD;

namespace Proyecto_Progra3_BLL.BD
{
    public class Cls_bd_BLL
    {
       
        public void Ejecutar_adapter(ref Cls_bd_DAL Obj_bd_DAL)
        {
            try
            {
                Obj_bd_DAL.scadena = ConfigurationManager.ConnectionStrings["Win_Aut"].ToString().Trim();
                Obj_bd_DAL.Obj_sql_conexion = new SqlConnection(Obj_bd_DAL.scadena);
                if (Obj_bd_DAL.Obj_sql_conexion.State == System.Data.ConnectionState.Closed)
                {
                    Obj_bd_DAL.Obj_sql_conexion.Open();
                    Obj_bd_DAL.Obj_sql_adap = new SqlDataAdapter(Obj_bd_DAL.ssentencia, Obj_bd_DAL.Obj_sql_conexion);
                    Obj_bd_DAL.Obj_sql_adap.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    Obj_bd_DAL.Obj_sql_adap.Fill(Obj_bd_DAL.Data_set, Obj_bd_DAL.snombretabla);
                }
                Obj_bd_DAL.smsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_bd_DAL.smsjError = ex.ToString();
            }
            finally
            {
                if (Obj_bd_DAL.Obj_sql_conexion != null)
                {
                    if (Obj_bd_DAL.Obj_sql_conexion.State == System.Data.ConnectionState.Open)
                    {
                        Obj_bd_DAL.Obj_sql_conexion.Close();
                    }
                    Obj_bd_DAL.Obj_sql_conexion.Dispose();
                }
            }
          
        }

    }
}
