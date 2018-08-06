using System;
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
                    if (Obj_bd_DAL.Obj_DTParametros.Rows.Count >= 1)
                    {
                        System.Data.SqlDbType Obj_TipoDato = System.Data.SqlDbType.NVarChar;
                        foreach (System.Data.DataRow dr in Obj_bd_DAL.Obj_DTParametros.Rows)
                        {
                            switch (dr[1].ToString())
                            {
                                case "1":
                                    Obj_TipoDato = System.Data.SqlDbType.NVarChar;
                                    break;
                                default:
                                    break;
                            }
                            Obj_bd_DAL.Obj_sql_adap.SelectCommand.Parameters.Add(dr[0].ToString(), Obj_TipoDato).Value = 
                                dr[2].ToString();
                        }
                    }


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

        public void Crear_DT_Parametros(ref Cls_bd_DAL Obj_Conexion_DAL)
        {
            Obj_Conexion_DAL.Obj_DTParametros.Columns.Add("NombreParam");
            Obj_Conexion_DAL.Obj_DTParametros.Columns.Add("TipoDatoParam");
            Obj_Conexion_DAL.Obj_DTParametros.Columns.Add("ValorParam");
        }
    }
}
