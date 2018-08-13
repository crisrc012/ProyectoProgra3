using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_call_DAL.Catalogos_Mantenimientos
{
    public class Cls_turnos_DAL
    {
        #region Variables
        private int _iCant_Horas;
        private string _sDesc_Turno, _sHoraEntrada, _sHoraSalida, _sUsuCreacion, _sUsuModificacion, _smsjError;
        private char _cId_Estado, _cAxn, _cId_Turno;
        private DateTime _dFecCreacion, _dFecModificacion;
        private bool _bbandera;

        public int iCant_Horas
        {
            get
            {
                return _iCant_Horas;
            }

            set
            {
                _iCant_Horas = value;
            }
        }

        public string sDesc_Turno
        {
            get
            {
                return _sDesc_Turno;
            }

            set
            {
                _sDesc_Turno = value;
            }
        }

        public string sHoraEntrada
        {
            get
            {
                return _sHoraEntrada;
            }

            set
            {
                _sHoraEntrada = value;
            }
        }

        public string sHoraSalida
        {
            get
            {
                return _sHoraSalida;
            }

            set
            {
                _sHoraSalida = value;
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
