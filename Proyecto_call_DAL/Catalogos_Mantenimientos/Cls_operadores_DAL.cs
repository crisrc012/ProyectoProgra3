using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_call_DAL.Catalogos_Mantenimientos
{
    public class Cls_operadores_DAL
    {
        #region Variables

        private string _sId_Operador, _sNombre_Operador, _sApellidos_Operador, _sNickNameOperador, _sNivel, _sUsuCreacion, _sUsuModificacion, _smsjError;
        private char _cId_Estado, _cAxn, _cId_Turno;
        private DateTime _dFecCreacion, _dFecModificacion;
        private bool _bbandera;

        public string sId_Operador
        {
            get
            {
                return _sId_Operador;
            }

            set
            {
                _sId_Operador = value;
            }
        }

        public string sNombre_Operador
        {
            get
            {
                return _sNombre_Operador;
            }

            set
            {
                _sNombre_Operador = value;
            }
        }

        public string sApellidos_Operador
        {
            get
            {
                return _sApellidos_Operador;
            }

            set
            {
                _sApellidos_Operador = value;
            }
        }

        public string sNickNameOperador
        {
            get
            {
                return _sNickNameOperador;
            }

            set
            {
                _sNickNameOperador = value;
            }
        }

        public string sNivel
        {
            get
            {
                return _sNivel;
            }

            set
            {
                _sNivel = value;
            }
        }

        public string sUsuCreacion
        {
            get
            {
                return _sUsuCreacion;
            }

            set
            {
                _sUsuCreacion = value;
            }
        }

        public string sUsuModificacion
        {
            get
            {
                return _sUsuModificacion;
            }

            set
            {
                _sUsuModificacion = value;
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

        public char cId_Estado
        {
            get
            {
                return _cId_Estado;
            }

            set
            {
                _cId_Estado = value;
            }
        }

        public char cAxn
        {
            get
            {
                return _cAxn;
            }

            set
            {
                _cAxn = value;
            }
        }

        public char cId_Turno
        {
            get
            {
                return _cId_Turno;
            }

            set
            {
                _cId_Turno = value;
            }
        }

        public DateTime dFecCreacion
        {
            get
            {
                return _dFecCreacion;
            }

            set
            {
                _dFecCreacion = value;
            }
        }

        public DateTime dFecModificacion
        {
            get
            {
                return _dFecModificacion;
            }

            set
            {
                _dFecModificacion = value;
            }
        }

        public bool bbandera
        {
            get
            {
                return _bbandera;
            }

            set
            {
                _bbandera = value;
            }
        }
        #endregion

        public System.Data.DataSet Ds = new System.Data.DataSet();
    }
}
