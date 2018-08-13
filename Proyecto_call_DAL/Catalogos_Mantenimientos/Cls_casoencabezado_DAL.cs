using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_call_DAL.Catalogos_Mantenimientos
{
    public class Cls_casoencabezado_DAL
    {
        #region variables

        private int _iId_Caso_Enc;
        private string _sId_Operador, _sComentariosReporte, _sUsuModificacion, _sUsuCreacion, _smsjError;
        private DateTime _dFecha, _dFecCreacion, _dFecModificacion;
        private char _cId_Estado_SemaforoCaso, _cId_Estado, _cAxn;
        private bool _bbandera;

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

        public string sComentariosReporte
        {
            get
            {
                return _sComentariosReporte;
            }

            set
            {
                _sComentariosReporte = value;
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

        public DateTime dFecha
        {
            get
            {
                return _dFecha;
            }

            set
            {
                _dFecha = value;
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
