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
using Proyecto_call_PL.TipoActivo;

namespace Proyecto_call_PL.TipoActivo
{
    public partial class frm_TipoActivo : Form
    {
        Cls_tipoactivo_BLL Obj_TipoActivo_BLL = new Cls_tipoactivo_BLL();
        Cls_tipoactivo_DAL Obj_TipoActivo_DAL = new Cls_tipoactivo_DAL();
        frm_EditarTipoActivo frm_agregar_TipoActivo;

        public frm_TipoActivo()
        {
            InitializeComponent();
        }

        private void listar()
        {
            dtg_Datos.DataSource = null;
            Obj_TipoActivo_BLL.listar_Tipoactivo(ref Obj_TipoActivo_DAL);

            if (Obj_TipoActivo_DAL.smsjError == string.Empty)
            {
                dtg_Datos.DataSource = null;
                dtg_Datos.DataSource = Obj_TipoActivo_DAL.Ds.Tables[0];

            }
            else
            {
                dtg_Datos.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_TipoActivo_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_TipoActivo_DAL.smsjError == string.Empty)
            {

                Obj_TipoActivo_BLL.filtrar_Tipoactivos(ref Obj_TipoActivo_DAL, txt_Filtrar.Text.ToString());
                dtg_Datos.DataSource = null;
                dtg_Datos.DataSource = Obj_TipoActivo_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_Datos.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_TipoActivo_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void frm_TipoActivo_Load_1(object sender, EventArgs e)
        {
            listar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Obj_TipoActivo_DAL.smsjError == string.Empty)
            {
                if (dtg_Datos.Rows.Count >= 1)
                {
                    string _svalor = dtg_Datos.SelectedRows[0].Cells[0].Value.ToString();
                    Obj_TipoActivo_BLL.eliminar_Tipoactivos(ref Obj_TipoActivo_DAL, _svalor);
                    MessageBox.Show("El dato se borro exitosamente", "Aviso", MessageBoxButtons.OK);
                    listar();
                }
                else
                {
                    dtg_Datos.DataSource = null;
                    MessageBox.Show(" Se presento el siguiente error " + Obj_TipoActivo_DAL.smsjError, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void txt_Filtrar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Filtrar.Text.ToString().Trim() == "")
            {
                listar();
            }
            else
            {
                filtrar();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            Obj_TipoActivo_DAL = new Cls_tipoactivo_DAL();
            frm_EditarTipoActivo frm_AgregarTipoActivo = new frm_EditarTipoActivo(ref Obj_TipoActivo_DAL, null);
            Obj_TipoActivo_DAL.cAxn = Convert.ToChar("I");
            frm_AgregarTipoActivo.ShowDialog(this);

            if (Obj_TipoActivo_DAL.bbandera)
            {
                MessageBox.Show("Se ha agregado correctamente", "Agregado correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                listar();
            }
            else
            {
                if (Obj_TipoActivo_DAL.smsjError != null)
                {
                    MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_TipoActivo_DAL.smsjError, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            listar();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dtg_Datos.SelectedRows.Count == 1)
            {
                Cls_tipoactivo_DAL Obj_TipoActivo_DAL = new Cls_tipoactivo_DAL();
                // Se obtinenen los datos del DataGridView
                Obj_TipoActivo_DAL.iId_TipoActivo = Convert.ToInt32(dtg_Datos.SelectedRows[0].Cells[0].Value);
                Obj_TipoActivo_DAL.sDesc_TipoActivo = dtg_Datos.SelectedRows[0].Cells[1].Value.ToString();
                string sEstado = dtg_Datos.SelectedRows[0].Cells[2].Value.ToString();
                // Se abre la ventana de modificación
                frm_EditarTipoActivo frm_editar_EditarTipoActivo = new frm_EditarTipoActivo(ref Obj_TipoActivo_DAL, sEstado);
                frm_editar_EditarTipoActivo.ShowDialog(this);
                // Se evalua el resultado de la operación y se muestra el mensaje de error o de operación realizada
                if (Obj_TipoActivo_DAL.bbandera)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Modificado correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listar();
                }
                else
                {
                    if (Obj_TipoActivo_DAL.smsjError != null)
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_TipoActivo_DAL.smsjError, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciones una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
