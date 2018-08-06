using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra3_DAL.Catalogos_Mantenimientos.Activos
{
    public class Cls_activos_DAL
    {
        private string _sMsjError;
        public System.Data.DataSet Obj_DS = new System.Data.DataSet();

        public string sMsjError
        {
            get
            {
                return _sMsjError;
            }

            set
            {
                _sMsjError = value;
            }
        }
    }
}
