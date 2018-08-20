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
        frm_editar_marcaactivo_PL frm_agregar_marcaactivo;
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
                dtg_desplegar.DataSource = Obj_marcaactivo_DAL.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_marcaactivo_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            dtg_desplegar.DataSource = null;
            if (Obj_marcaactivo_DAL.smsjError == string.Empty)
            {
                Obj_marcaactivo_BLL.filtrar_marcaactivo(ref Obj_marcaactivo_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = Obj_marcaactivo_DAL.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_marcaactivo_DAL.smsjError, "Error", MessageBoxButtons.OK);
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
                if (MessageBox.Show("¿Realmente desea eliminar la fila seleccionada?", "Confirmar eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_marcaactivo_DAL = new Cls_marcaactivo_DAL();
                    Obj_marcaactivo_DAL.iId_MarcaActivo = Convert.ToInt32(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                    Obj_marcaactivo_BLL.eliminar_marcaactivo(ref Obj_marcaactivo_DAL);
                    if (Obj_marcaactivo_DAL.bbandera)
                    {
                        MessageBox.Show("Se ha eliminado correctamente", "Eliminado correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listar();
                    }
                    else
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_marcaactivo_DAL.smsjError, "Error",
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
            Obj_marcaactivo_DAL = new Cls_marcaactivo_DAL();
            frm_agregar_marcaactivo = new frm_editar_marcaactivo_PL(ref Obj_marcaactivo_DAL, null);
            frm_agregar_marcaactivo.ShowDialog(this);
            if (Obj_marcaactivo_DAL.bbandera)
            {
                MessageBox.Show("Se ha agregado correctamente", "Agregado correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                listar();
            }
            else
            {
                if (Obj_marcaactivo_DAL.smsjError != null)
                {
                    MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_marcaactivo_DAL.smsjError, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsb_btn_modificar_Click(object sender, EventArgs e)
        {
            if (dtg_desplegar.SelectedRows.Count == 1)
            {
                Obj_marcaactivo_DAL = new Cls_marcaactivo_DAL();
                // Se obtinenen los datos del DataGridView
                Obj_marcaactivo_DAL.iId_MarcaActivo = Convert.ToInt32(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                Obj_marcaactivo_DAL.sDesc_MarcaActivo = dtg_desplegar.SelectedRows[0].Cells[1].Value.ToString();
                string sEstado = dtg_desplegar.SelectedRows[0].Cells[2].Value.ToString();
                // Se abre la ventana de modificación
                frm_editar_marcaactivo_PL frm_editar_marcaactivo = new frm_editar_marcaactivo_PL(ref Obj_marcaactivo_DAL, sEstado);
                frm_editar_marcaactivo.ShowDialog(this);
                // Se evalua el resultado de la operación y se muestra el mensaje de error o de operación realizada
                if (Obj_marcaactivo_DAL.bbandera)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Modificado correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listar();
                }
                else
                {
                    if (Obj_marcaactivo_DAL.smsjError != null)
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_marcaactivo_DAL.smsjError, "Error",
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
