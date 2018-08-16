using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using System;
using System.Windows.Forms;

namespace Proyecto_call_PL.MarcaActivo
{
    public partial class frm_editar_marcaactivo_PL : Form
    {
        #region Globales
        private Cls_marcaactivo_DAL Obj_marcaactivo_DAL = new Cls_marcaactivo_DAL();
        private Cls_marcaactivo_BLL Obj_marcaactivo_BLL = new Cls_marcaactivo_BLL();
        private Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        private Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        private string _sEstado;
        private bool insert = false;
        #endregion
        public frm_editar_marcaactivo_PL(ref Cls_marcaactivo_DAL Obj_marcaactivo_DAL, string sEstado)
        {
            InitializeComponent();
            #region Cargar combobox marcaactivo
            Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
            if (Obj_estados_DAL.smsjError == string.Empty)
            {
                cmbEstado.DisplayMember = "Descripción";
                cmbEstado.ValueMember = "Código";
                cmbEstado.DataSource = Obj_estados_DAL.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
                Close();
            }
            #endregion
            _sEstado = sEstado;
            #region Valida insert o Update
            if (Obj_marcaactivo_DAL.iId_MarcaActivo == 0)
            {
                // Insert
                insert = true;
                btnAccion.Text = "Agregar";
            }
            else
            {
                // Update
                btnAccion.Text = "Modificar";
                txtDescripcion.Text = Obj_marcaactivo_DAL.sDesc_MarcaActivo;
                cmbEstado.SelectedValue = Obj_marcaactivo_DAL.cId_Estado;
                cmbEstado.Refresh();
            }
            this.Obj_marcaactivo_DAL = Obj_marcaactivo_DAL;
            #endregion
            Text = btnAccion.Text + " Marca de Activo";
        }

        private void frm_editar_marcaactivo_PL_Load(object sender, EventArgs e)
        {
            if (_sEstado != string.Empty)
            {
                cmbEstado.SelectedText = _sEstado;
            }
            cmbEstado.SelectedIndex = 0;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (Obj_marcaactivo_DAL.sDesc_MarcaActivo == txtDescripcion.Text.Trim() &&
                Obj_marcaactivo_DAL.cId_Estado == Convert.ToChar(cmbEstado.SelectedValue))
            {
                MessageBox.Show("No ha cambiado ningún valor", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDescripcion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La descripción no puede ser vacía", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Obj_marcaactivo_DAL.sDesc_MarcaActivo = txtDescripcion.Text.Trim();
            Obj_marcaactivo_DAL.cId_Estado = Convert.ToChar(cmbEstado.SelectedValue);
            if (Obj_marcaactivo_DAL.cId_Estado == '\0')
            {
                Obj_marcaactivo_DAL.cId_Estado = '1';
            }
            if (insert)
            {
                Obj_marcaactivo_BLL.insertar_marcaactivo(ref Obj_marcaactivo_DAL);
            }
            else
            {
                Obj_marcaactivo_BLL.modificar_marcaactivo(ref Obj_marcaactivo_DAL);
            }
            Close();
        }
    }
}
