using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_call_PL.MarcaActivo
{
    public partial class frm_editar_marcaactivo_PL : Form
    {
        #region Globales
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        #endregion
        public frm_editar_marcaactivo_PL()
        {
            InitializeComponent();
        }

        private void frm_editar_marcaactivo_PL_Load(object sender, EventArgs e)
        {
            #region Cargar combobox estados
            Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
            if (Obj_estados_DAL.smsjError == string.Empty)
            {
                cmbEstado.DisplayMember = "Descripción";
                cmbEstado.ValueMember = "Código";
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
            #endregion
        }
    }
}
