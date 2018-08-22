using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_DAL.Catalogos_Mantenimientos;

namespace Proyecto_call_PL.TipoActivo
{
    public partial class frm_EditarTipoActivo : Form
    {
        #region Globales
        private Cls_tipoactivo_DAL Obj_tipoactivo_DAL = new Cls_tipoactivo_DAL();
        private Cls_tipoactivo_BLL Obj_tipoactivo_BLL = new Cls_tipoactivo_BLL();
        private Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        private Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        private string _sEstado;
        private bool insert = false;
        #endregion
        public frm_EditarTipoActivo(ref Cls_tipoactivo_DAL tipoActivo, string sEstado)
        {
            InitializeComponent();
            Obj_tipoactivo_DAL = tipoActivo;
            #region Cargar combobox
            Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
            if (Obj_estados_DAL.smsjError == string.Empty)
            {
                cmb_TipoActivo.DisplayMember = "Descripción";
                cmb_TipoActivo.ValueMember = "Código";
                cmb_TipoActivo.DataSource = Obj_estados_DAL.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
                Close();
            }
            #endregion
            _sEstado = sEstado;
            #region Valida insert o Update
            if (Obj_tipoactivo_DAL.iId_TipoActivo == 0)
            {
                // Insert
                insert = true;
                btn_Accion.Text = "Agregar";
            }
            else
            {
                // Update
                btn_Accion.Text = "Modificar";
                txt_Descripcion.Text = Obj_tipoactivo_DAL.sDesc_TipoActivo;
                cmb_TipoActivo.SelectedValue = Obj_tipoactivo_DAL.cId_Estado;
                cmb_TipoActivo.Refresh();
            }
            /*this.Obj_marcaactivo_DAL = Obj_marcaactivo_DAL;
                 Obj_marcaactivo_DAL;
            #endregion
            Text = btnAccion.Text + " Marca de Activo";*/
            #endregion
        }

        private void frm_EditarTipoActivo_Load(object sender, EventArgs e)
        {
            if (_sEstado != string.Empty)
            {
                cmb_TipoActivo.SelectedText = _sEstado;
            }
            cmb_TipoActivo.SelectedIndex = 0;
        }

        private void btn_Accion_Click(object sender, EventArgs e)
        {
            if (Obj_tipoactivo_DAL.sDesc_TipoActivo == txt_Descripcion.Text.Trim() &&
              Obj_tipoactivo_DAL.cId_Estado == Convert.ToChar(cmb_TipoActivo.SelectedValue))
            {
                MessageBox.Show("No ha cambiado ningún valor", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_Descripcion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Digite un valor válido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Obj_tipoactivo_DAL.sDesc_TipoActivo = txt_Descripcion.Text.Trim();
            Obj_tipoactivo_DAL.cId_Estado = Convert.ToChar(cmb_TipoActivo.SelectedValue);
            if (Obj_tipoactivo_DAL.cId_Estado == '\0')
            {
                Obj_tipoactivo_DAL.cId_Estado = '1';
            }
            if (insert)
            {
                Obj_tipoactivo_BLL.insertar_Tipoactivos(ref Obj_tipoactivo_DAL);
            }
            else
            {
                Obj_tipoactivo_BLL.modificar_Tipoactivos(ref Obj_tipoactivo_DAL);
            }
            Close();
        }
    }
}
