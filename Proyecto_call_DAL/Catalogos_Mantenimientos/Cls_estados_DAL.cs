using System;

namespace Proyecto_call_DAL.Catalogos_Mantenimientos
{
    public class Cls_estados_DAL
    {
        #region Variables

        private string _sDesc_Estado, _sUsuCreacion, _sUsuModificacion, _smsjError;
        private char _cId_Estado, _cAxn;
        private DateTime _dFecCreacion, _dFecModificacion;
        private bool _bbandera;

        public string sDesc_Estado
        {
            get
            {
                return _sDesc_Estado;
            }

            set
            {
                _sDesc_Estado = value;
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
