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

namespace Proyecto_call_PL.Turnos
{
    public partial class frm_turnos_PL : Form
    {
        #region Variables Globales
        Cls_turnos_DAL Obj_turnos_DAL = new Cls_turnos_DAL();
        Cls_turnos_BLL Obj_turnos_BLL = new Cls_turnos_BLL();
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        #endregion

        public frm_turnos_PL()
        {
            InitializeComponent();
        }

        private void listar()
        {
            dtg_desplegar.DataSource = null;
            Obj_turnos_BLL.listar_turnos(ref Obj_turnos_DAL);

            if (Obj_turnos_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_turnos_DAL.Ds.Tables[0];

            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_turnos_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_turnos_DAL.smsjError == string.Empty)
            {
                Obj_turnos_BLL.filtrar_turnos(ref Obj_turnos_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_turnos_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_turnos_DAL.smsjError, "Error", MessageBoxButtons.OK);
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

        private void frm_turnos_PL_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void tsb_btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dtg_desplegar.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Realmente desea eliminar la fila seleccionada?", "Confirmar eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_turnos_DAL = new Cls_turnos_DAL();
                    Obj_turnos_DAL.cId_Turno = Convert.ToChar(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                    Obj_turnos_BLL.eliminar_turnos(ref Obj_turnos_DAL);
                    if (Obj_turnos_DAL.bbandera)
                    {
                        MessageBox.Show("Se ha eliminado correctamente", "Eliminado correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listar();
                    }
                    else
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_turnos_DAL.smsjError, "Error",
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
            //Declaramos el objeto para pasar la informacion
            Obj_turnos_DAL = new Cls_turnos_DAL();
            Obj_turnos_DAL.cAxn = 'I';

            frm_editar_turnos_PL frm_editar_estado = new frm_editar_turnos_PL();
            //le asigna la informacion al objeto de la otra pantalla
            frm_editar_estado.Obj_turnos_DAL = Obj_turnos_DAL;

            frm_editar_estado.ShowDialog();
        }

        private void tsb_btn_modificar_Click(object sender, EventArgs e)
        {

            if (dtg_desplegar.SelectedRows.Count == 1)
            {
                frm_editar_turnos_PL frm_editar_estado = new frm_editar_turnos_PL();

                Obj_turnos_DAL = new Cls_turnos_DAL();
                
                Obj_turnos_DAL.cId_Turno = Convert.ToChar(dtg_desplegar.SelectedRows[0].Cells[0].Value);
                Obj_turnos_DAL.sDesc_Turno = dtg_desplegar.SelectedRows[0].Cells[1].Value.ToString();
                Obj_turnos_DAL.iCant_Horas = Convert.ToInt16(dtg_desplegar.SelectedRows[0].Cells[2].Value.ToString());
                Obj_turnos_DAL.sHoraEntrada = dtg_desplegar.SelectedRows[0].Cells[3].Value.ToString();
                Obj_turnos_DAL.sHoraSalida = dtg_desplegar.SelectedRows[0].Cells[4].Value.ToString();
                frm_editar_estado._sEstado = dtg_desplegar.SelectedRows[0].Cells[5].Value.ToString();

                Obj_turnos_DAL.cAxn = 'U';
                
                frm_editar_estado.Obj_turnos_DAL = Obj_turnos_DAL;

                frm_editar_estado.ShowDialog();
                
                if (Obj_turnos_DAL.bbandera)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Modificado correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listar();
                }
                else
                {
                    if (Obj_turnos_DAL.smsjError != null)
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_turnos_DAL.smsjError, "Error",
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
