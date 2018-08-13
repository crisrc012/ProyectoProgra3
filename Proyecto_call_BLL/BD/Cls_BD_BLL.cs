using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_call_DAL.BD;
using System.Configuration;
using System.Data.SqlClient;

namespace Proyecto_call_BLL.BD
{
    public class Cls_BD_BLL
    {
        public void crear_tabla(ref Cls_BD_DAL Obj_bd_DAL)
        {
            Obj_bd_DAL.Obj_dtparam.Columns.Add("Nombre");
            Obj_bd_DAL.Obj_dtparam.Columns.Add("tipo");
            Obj_bd_DAL.Obj_dtparam.Columns.Add("Valor");
        }
        public void Adapt(ref Cls_BD_DAL Obj_bd_DAL)
        {
            try
            {
                Obj_bd_DAL.scadena = ConfigurationManager.ConnectionStrings["Win_aut"].ToString().Trim();
                Obj_bd_DAL.Obj_conexion = new SqlConnection(Obj_bd_DAL.scadena);

                if (Obj_bd_DAL.Obj_conexion.State == System.Data.ConnectionState.Closed)
                {
                    Obj_bd_DAL.Obj_conexion.Open();
                    Obj_bd_DAL.Obj_adpt = new SqlDataAdapter(Obj_bd_DAL.ssentencia, Obj_bd_DAL.Obj_conexion);

                    if (Obj_bd_DAL.Obj_dtparam.Rows.Count >= 1)
                    {
                        System.Data.SqlDbType Obj_tipodato = System.Data.SqlDbType.NVarChar;
                        foreach (System.Data.DataRow dr in Obj_bd_DAL.Obj_dtparam.Rows)
                        {
                            switch (dr[1].ToString())
                            {
                                case "1":
                                    Obj_tipodato = System.Data.SqlDbType.NVarChar;
                                break;
                                default:
                                    break;
                            }
                            Obj_bd_DAL.Obj_adpt.SelectCommand.Parameters.Add(dr[0].ToString(), Obj_tipodato).Value = dr[2].ToString();
                        }
                    }

                    Obj_bd_DAL.Obj_adpt.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    Obj_bd_DAL.Obj_adpt.Fill(Obj_bd_DAL.dst, Obj_bd_DAL.snombretabla);
                }
                Obj_bd_DAL.smsjerror = string.Empty;
            }
            catch (SqlException e)
            {
                Obj_bd_DAL.smsjerror = e.ToString().Trim();
            }
            finally
            {
                if (Obj_bd_DAL.Obj_conexion != null)
                {
                    if (Obj_bd_DAL.Obj_conexion.State== System.Data.ConnectionState.Open)
                    {
                        Obj_bd_DAL.Obj_conexion.Close();
                    }
                    Obj_bd_DAL.Obj_conexion.Dispose();
                }
            }
        }
        public void Exe_NonQuery(ref Cls_BD_DAL Obj_bd_DAL)
        {
            try
            {
                Obj_bd_DAL.scadena = ConfigurationManager.ConnectionStrings["Win_aut"].ToString();
                Obj_bd_DAL.Obj_conexion = new SqlConnection(Obj_bd_DAL.scadena);

                if (Obj_bd_DAL.Obj_conexion.State == System.Data.ConnectionState.Closed)
                {
                    Obj_bd_DAL.Obj_conexion.Open();
                    Obj_bd_DAL.Obj_sql_cmnd = new SqlCommand(Obj_bd_DAL.ssentencia, Obj_bd_DAL.Obj_conexion);

                    if (Obj_bd_DAL.Obj_dtparam.Rows.Count >=1)
                    {
                        System.Data.SqlDbType Obj_tipo_dato = System.Data.SqlDbType.NVarChar;
                        foreach (System.Data.DataRow  Celda in Obj_bd_DAL.Obj_dtparam.Rows)
                        {
                            switch (Celda[1].ToString())
                            {
                                case "1":
                                    Obj_tipo_dato = System.Data.SqlDbType.NVarChar;
                                    break;
                                case "2":
                                    Obj_tipo_dato = System.Data.SqlDbType.Char;
                                    break;
                                case "3":
                                    Obj_tipo_dato = System.Data.SqlDbType.Int;
                                    break;
                                default:
                                    break;
                            }
                            Obj_bd_DAL.Obj_sql_cmnd.Parameters.Add(Celda[0].ToString(), Obj_tipo_dato).Value = Celda[2].ToString();
                        }
                    }
                    Obj_bd_DAL.Obj_sql_cmnd.CommandType = System.Data.CommandType.StoredProcedure;
                    Obj_bd_DAL.Obj_sql_cmnd.ExecuteNonQuery();

                }
                Obj_bd_DAL.smsjerror = string.Empty;
            }
            catch (SqlException error)
            {
                Obj_bd_DAL.smsjerror = error.ToString();

            }
            finally
            {
                if (Obj_bd_DAL.Obj_conexion != null)
                {
                    if (Obj_bd_DAL.Obj_conexion.State == System.Data.ConnectionState.Open)
                    {
                        Obj_bd_DAL.Obj_conexion.Close();
                    }
                }
                Obj_bd_DAL.Obj_conexion.Dispose();
            }
        }
        public void Exe_Scalar(ref Cls_BD_DAL Obj_bd_DAL)
        {
            try
            {
                Obj_bd_DAL.scadena = ConfigurationManager.ConnectionStrings["Win_aut"].ToString();
                Obj_bd_DAL.Obj_conexion = new SqlConnection(Obj_bd_DAL.scadena);

                if (Obj_bd_DAL.Obj_conexion.State == System.Data.ConnectionState.Closed)
                {
                    Obj_bd_DAL.Obj_conexion.Open();
                    Obj_bd_DAL.Obj_sql_cmnd = new SqlCommand(Obj_bd_DAL.ssentencia,Obj_bd_DAL.Obj_conexion);

                    if (Obj_bd_DAL.Obj_dtparam.Rows.Count >= 1)
                    {
                        System.Data.SqlDbType Obj_tipo_dato = System.Data.SqlDbType.NVarChar;
                        foreach (System.Data.DataRow Celda in Obj_bd_DAL.Obj_dtparam.Rows)
                        {
                            switch (Celda[1].ToString())
                            {
                                case "1":
                                    Obj_tipo_dato = System.Data.SqlDbType.NVarChar;
                                    break;
                                case "2":
                                    Obj_tipo_dato = System.Data.SqlDbType.Char;
                                    break;
                                case "3":
                                    Obj_tipo_dato = System.Data.SqlDbType.Int;
                                    break;
                                default:
                                    break;
                            }
                            Obj_bd_DAL.Obj_sql_cmnd.Parameters.Add(Celda[0].ToString(), Obj_tipo_dato).Value = Celda[2].ToString();
                        }
                    }

                    Obj_bd_DAL.Obj_sql_cmnd.CommandType = System.Data.CommandType.StoredProcedure;
                    Obj_bd_DAL.ivalorscalar = Convert.ToInt32(Obj_bd_DAL.Obj_sql_cmnd.ExecuteScalar().ToString());
                }


                Obj_bd_DAL.smsjerror = string.Empty;
            }
            catch (SqlException error)
            {
                Obj_bd_DAL.smsjerror = error.ToString();
            }
            

        }
    }
}
