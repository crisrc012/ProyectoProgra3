using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_call_DAL.Catalogos_Mantenimientos
{
    public class Cls_semaforo_DAL
    {
        #region Variables
        private string _sDesc_Estado_SemaforoCaso, _sColor, _sUsuCreacion, _sUsuModificacion, _smsjError;
        private char _cId_Estado, _cAxn, _cId_Estado_SemaforoCaso;
        private DateTime _dFecCreacion, _dFecModificacion;
        private bool _bbandera;

        public string sDesc_Estado_SemaforoCaso
        {
            get
            {
                return _sDesc_Estado_SemaforoCaso;
            }

            set
            {
                _sDesc_Estado_SemaforoCaso = value;
            }
        }

        public string sColor
        {
            get
            {
                return _sColor;
            }

            set
            {
                _sColor = value;
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

        public char cId_Estado_SemaforoCaso
        {
            get
            {
                return _cId_Estado_SemaforoCaso;
            }

            set
            {
                _cId_Estado_SemaforoCaso = value;
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
