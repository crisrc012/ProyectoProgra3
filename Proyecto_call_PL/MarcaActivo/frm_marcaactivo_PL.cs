using System;
using System.Windows.Forms;
using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_DAL.Catalogos_Mantenimientos;

namespace Proyecto_call_PL.MarcaActivo
{
    public partial class frm_marcaactivo_PL : Form
    {
        #region Globales
        Cls_marcaactivo_DAL Obj_marcaactivo_DAL = new Cls_marcaactivo_DAL();
        Cls_marcaactivo_BLL Obj_marcaactivo_BLL = new Cls_marcaactivo_BLL();
        #endregion
        public frm_marcaactivo_PL()
        {
            InitializeComponent();
        }

        private void frm_marcaactivo_PL_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            dtg_desplegar.DataSource = null;
            Obj_marcaactivo_BLL.listar_marcaactivo(ref Obj_marcaactivo_DAL);
            if (Obj_marcaactivo_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_marcaactivo_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_marcaactivo_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_marcaactivo_DAL.smsjError == string.Empty)
            {
                Obj_marcaactivo_BLL.filtrar_marcaactivo(ref Obj_marcaactivo_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_marcaactivo_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_marcaactivo_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void tstxt_valor_filtrar_TextChanged(object sender, EventArgs e)
        {
            if (tstxt_valor_filtrar.Text.ToString().Trim() == "")
            {
                listar();
            }
            else
            {
                filtrar();
            }
        }

        private void tsb_btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dtg_desplegar.SelectedRows.Count == 1)
            {
                Obj_marcaactivo_DAL = new Cls_marcaactivo_DAL();
                Obj_marcaactivo_DAL.iId_MarcaActivo= Convert.ToInt32(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                Obj_marcaactivo_BLL.eliminar_marcaactivo(ref Obj_marcaactivo_DAL);
            }
            else
            {
                MessageBox.Show("Por favor selecciones una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_btn_agregar_Click(object sender, EventArgs e)
        {
            frm_editar_marcaactivo_PL frm_agregar_marcaactivo = new frm_editar_marcaactivo_PL();
            frm_agregar_marcaactivo.ShowDialog(this);
        }

        private void tsb_btn_modificar_Click(object sender, EventArgs e)
        {
            if (dtg_desplegar.SelectedRows.Count == 1)
            {
                Obj_marcaactivo_DAL = new Cls_marcaactivo_DAL();
                Obj_marcaactivo_DAL.iId_MarcaActivo = Convert.ToInt32(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                //

                Obj_marcaactivo_BLL.eliminar_marcaactivo(ref Obj_marcaactivo_DAL);
            }
            else
            {
                MessageBox.Show("Por favor selecciones una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
