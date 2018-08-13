using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_call_DAL.BD
{
    public class Cls_BD_DAL
    {
        #region Variables

        private string _scadena, _smsjerror, _ssentencia, _snombretabla;
        private int _ivalorscalar;

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

        public string smsjerror
        {
            get
            {
                return _smsjerror;
            }

            set
            {
                _smsjerror = value;
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

        public int ivalorscalar
        {
            get
            {
                return _ivalorscalar;
            }

            set
            {
                _ivalorscalar = value;
            }
        }

        #endregion

        #region Objetos sql

        public SqlConnection Obj_conexion;
        public SqlCommand Obj_sql_cmnd;
        public SqlDataAdapter Obj_adpt;
        public System.Data.DataSet dst = new System.Data.DataSet();
        public System.Data.DataTable Obj_dtparam = new System.Data.DataTable("Parametros");




        #endregion

    }
}
