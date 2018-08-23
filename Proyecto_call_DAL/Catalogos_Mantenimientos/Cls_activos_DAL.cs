using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_call_DAL.Catalogos_Mantenimientos
{
    public class Cls_activos_DAL
    {
        #region Variables

        private int _iPlaca_Activo, _iId_TipoActivo, _iId_MarcaActivo, _iId_Departamento_Responsable;
        private string _sDesc_Activo, _sUsuCreacion, _sUsuModificacion, _smsjError;
        private decimal _dPrioridad_SLA;
        private char _cId_Estado, _cAxn;
        private DateTime _dFecCreacion, _dFecModificacion;
        private bool _bbandera;

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

        public int iId_TipoActivo
        {
            get
            {
                return _iId_TipoActivo;
            }

            set
            {
                _iId_TipoActivo = value;
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

        public int iId_Departamento_Responsable
        {
            get
            {
                return _iId_Departamento_Responsable;
            }

            set
            {
                _iId_Departamento_Responsable = value;
            }
        }

        public string sDesc_Activo
        {
            get
            {
                return _sDesc_Activo;
            }

            set
            {
                _sDesc_Activo = value;
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

        public decimal dPrioridad_SLA
        {
            get
            {
                return _dPrioridad_SLA;
            }

            set
            {
                _dPrioridad_SLA = value;
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
