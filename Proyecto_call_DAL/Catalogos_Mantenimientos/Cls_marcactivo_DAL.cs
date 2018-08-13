using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_call_DAL.Catalogos_Mantenimientos
{
    public class Cls_marcactivo_DAL
    {
        #region Variables

        private int _iId_MarcaActivo;
        private string _sDesc_MarcaActivo, _sUsuCreacion, _sUsuModificacion, _smsjError;
        private char _cId_Estado, _cAxn;
        private DateTime _dFecCreacion, _dFecModificacion;
        private bool _bbandera;

        

        public string iDesc_MarcaActivo
        {
            get
            {
                return _sDesc_MarcaActivo;
            }

            set
            {
                _sDesc_MarcaActivo = value;
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

        public int iId_MarcaActivo
        {
            get
            {
                return _iId_MarcaActivo;
            }

            set
            {
                _iId_MarcaActivo = value;
            }
        }

        #endregion

        public System.Data.DataSet Ds = new System.Data.DataSet();
    }
}
