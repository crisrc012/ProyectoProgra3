using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_call_DAL.Catalogos_Mantenimientos
{
    public class Cls_casodetalle_DAL
    {
        #region Variables

        private int _iId_Caso_Det, _iId_Caso_Enc, _iPlaca_Activo;
        private string _sObservaciones, _sUsuCreacion, _sUsuModificacion, _smsjError;
        private DateTime _dFecCreacion, _dFecModificacion;
        private bool _bbandera;
        private char _cAxn;

        public int iId_Caso_Det
        {
            get
            {
                return _iId_Caso_Det;
            }

            set
            {
                _iId_Caso_Det = value;
            }
        }

        public int iId_Caso_Enc
        {
            get
            {
                return _iId_Caso_Enc;
            }

            set
            {
                _iId_Caso_Enc = value;
            }
        }

        public int iPlaca_Activo
        {
            get
            {
                return _iPlaca_Activo;
            }

            set
            {
                _iPlaca_Activo = value;
            }
        }

        public string sObservaciones
        {
            get
            {
                return _sObservaciones;
            }

            set
            {
                _sObservaciones = value;
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


        #endregion

        public System.Data.DataSet Ds = new System.Data.DataSet();
    }
}
