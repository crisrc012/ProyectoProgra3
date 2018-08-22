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
                dtg_desplegar.DataSource = Obj_estados_DAL.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            dtg_desplegar.DataSource = null;
            if (Obj_estados_DAL.smsjError == string.Empty)
            {
                Obj_estados_BLL.filtrar_estados(ref Obj_estados_DAL, tstxt_valor_filtrar.Text.Trim());
                dtg_desplegar.DataSource = Obj_estados_DAL.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void tstxt_valor_filtrar_TextChanged(object sender, EventArgs e)
        {
            if (tstxt_valor_filtrar.Text.Trim() == string.Empty)
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
                if (MessageBox.Show("¿Realmente desea eliminar la fila seleccionada?","Confirmar eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_estados_DAL = new Cls_estados_DAL();
                    Obj_estados_DAL.cId_Estado = Convert.ToChar(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                    Obj_estados_BLL.eliminar_estados(ref Obj_estados_DAL);
                    if (Obj_estados_DAL.bbandera)
                    {
                        MessageBox.Show("Se ha eliminado correctamente", "Eliminado correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listar();
                    }
                    else
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_estados_DAL.smsjError, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha eliminado ningún dato", "Eliminar cancelado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciones una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_btn_agregar_Click(object sender, EventArgs e)
        {
            Obj_estados_DAL = new Cls_estados_DAL();
            frm_editar_estados_PL frm_agregar_estado = new frm_editar_estados_PL(ref Obj_estados_DAL);
            frm_agregar_estado.ShowDialog(this);
            if (Obj_estados_DAL.bbandera)
            {
                MessageBox.Show("Se ha agregado correctamente", "Agregado correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                listar();
            }
            else
            {
                if (Obj_estados_DAL.smsjError != null)
                {
                    MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_estados_DAL.smsjError, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsb_btn_modificar_Click(object sender, EventArgs e)
        {
            if (dtg_desplegar.SelectedRows.Count == 1)
            {
                Obj_estados_DAL = new Cls_estados_DAL();
                // Se obtinenen los datos del DataGridView
                Obj_estados_DAL.cId_Estado = Convert.ToChar(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                Obj_estados_DAL.sDesc_Estado = dtg_desplegar.SelectedRows[0].Cells[1].Value.ToString();
                // Se abre la ventana de modificación
                frm_editar_estados_PL frm_editar_estado = new frm_editar_estados_PL(ref Obj_estados_DAL);
                frm_editar_estado.ShowDialog(this);
                // Se evalua el resultado de la operación y se muestra el mensaje de error o de operación realizada
                if (Obj_estados_DAL.bbandera)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Modificado correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listar();
                }
                else
                {
                    if (Obj_estados_DAL.smsjError != null)
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_estados_DAL.smsjError, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciones una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_btn_actualizar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
