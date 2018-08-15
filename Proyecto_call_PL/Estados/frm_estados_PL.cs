using System;
using System.Windows.Forms;
using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_DAL.Catalogos_Mantenimientos;

namespace Proyecto_call_PL.Estados
{
    public partial class frm_estados_PL : Form
    {
        #region Globales
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        #endregion
        public frm_estados_PL()
        {
            InitializeComponent();
        }

        private void frm_estados_PL_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            dtg_desplegar.DataSource = null;
            Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
            if (Obj_estados_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_estados_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_estados_DAL.smsjError == string.Empty)
            {
                Obj_estados_BLL.filtrar_estados(ref Obj_estados_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_estados_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
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
                Obj_estados_DAL = new Cls_estados_DAL();
                Obj_estados_DAL.cId_Estado = Convert.ToChar(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                Obj_estados_BLL.eliminar_estados(ref Obj_estados_DAL);
            }
            else
            {
                MessageBox.Show("Por favor selecciones una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
