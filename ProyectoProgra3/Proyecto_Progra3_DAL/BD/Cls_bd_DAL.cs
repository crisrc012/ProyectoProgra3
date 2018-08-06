using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Progra3_DAL.BD
{
    public class Cls_bd_DAL
    {
        #region Variables encapsuladas

        private string _scadena, _smsjError, _ssentencia, _snombretabla;

        public string scadena
        {
            get
            {
                return _scadena;
            }

            set
            {
                _scadena = value;
            }
        }

        public string smsjError
        {
            get
            {
                return _smsjError;
            }

            set
            {
                _smsjError = value;
            }
        }

        public string snombretabla
        {
            get
            {
                return _snombretabla;
            }

            set
            {
                _snombretabla = value;
            }
        }

        public string ssentencia
        {
            get
            {
                return _ssentencia;
            }

            set
            {
                _ssentencia = value;
            }
        }
        #endregion

        #region Objetos Base de datos

        public SqlConnection Obj_sql_conexion;
        public SqlCommand Obj_sql_cmd;
        public SqlDataAdapter Obj_sql_adap;
        public System.Data.DataSet Data_set = new System.Data.DataSet();
        public System.Data.DataTable Obj_DTParametros = new System.Data.DataTable("PARAMETROS");
        #endregion
    }
}
