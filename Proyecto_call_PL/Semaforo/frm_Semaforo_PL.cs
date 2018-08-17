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
using Proyecto_call_PL.Semaforo;

namespace Proyecto_call_PL.Formularios
{
    public partial class frm_Semaforo_PL : Form
    {
        #region Globales
        Cls_semaforo_DAL Obj_Semaforo_DAL = new Cls_semaforo_DAL();
        Cls_semaforo_BLL Obj_Semaforo_BLL = new Cls_semaforo_BLL();
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        Int16 i16Fila;
        #endregion
        public frm_Semaforo_PL()
        {
            InitializeComponent();
        }

        private void frm_caso_detalle_PL_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            
            dtg_desplegar.DataSource = null;
            Obj_Semaforo_BLL.Listar_Semaforo(ref Obj_Semaforo_DAL);

            if (Obj_Semaforo_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_Semaforo_DAL.Ds.Tables[0];

            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_Semaforo_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_Semaforo_DAL.smsjError == string.Empty)
            {

                Obj_Semaforo_BLL.Filtrar_Semaforo(ref Obj_Semaforo_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_Semaforo_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_Semaforo_DAL.smsjError, "Error", MessageBoxButtons.OK);
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
            
            if (dtg_desplegar.Rows.Count==0)
            {
                MessageBox.Show("No hay registros para eliminar","Eliminar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro " +
                Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[0].Value)
                , "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_Semaforo_DAL.cId_Estado_SemaforoCaso = Convert.ToChar(dtg_desplegar.Rows[i16Fila].Cells[0].Value);
                    Obj_Semaforo_BLL.Eliminar_Semaforo(ref Obj_Semaforo_DAL);
                    listar();
                }
            }
            
        }

        private void dtg_desplegar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i16Fila = Convert.ToInt16(e.RowIndex);
        }

        private void tsb_btn_actualizar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void tsb_btn_agregar_Click(object sender, EventArgs e)
        {
            Obj_Semaforo_DAL = new Cls_semaforo_DAL();
            frm_ModificaSemaforo_PL frm_InsertUpdate_PL = new frm_ModificaSemaforo_PL(ref Obj_Semaforo_DAL, null, "Insertar");
            frm_InsertUpdate_PL.ShowDialog(this);
            if (Obj_Semaforo_DAL.bbandera)
            {
                MessageBox.Show("Se ha agregado correctamente", "Agregado correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                listar();
            }
            else
            {
                if (Obj_Semaforo_DAL.smsjError != null)
                {
                    MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_Semaforo_DAL.smsjError, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsb_btn_modificar_Click(object sender, EventArgs e)
        {
            if (dtg_desplegar.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frm_ModificaSemaforo_PL frm_Modificar = new frm_ModificaSemaforo_PL
                    (ref Obj_Semaforo_DAL, null, "Modificar", Convert.ToChar(dtg_desplegar.Rows[i16Fila].Cells[0].Value));

                #region Cargar combobox 
                Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
                if (Obj_estados_DAL.smsjError == string.Empty)
                {
                    frm_Modificar.cmb_Estado.DisplayMember = "Descripción";
                    frm_Modificar.cmb_Estado.ValueMember = "Código";
                    frm_Modificar.cmb_Estado.DataSource = Obj_estados_DAL.Ds.Tables[0];
                }

                else
                {
                    MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
                }


                #endregion

                Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
                frm_Modificar.txt_Descripcion.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[1].Value);
                frm_Modificar.txt_Color.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[2].Value);
                frm_Modificar.cmb_Estado.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[3].Value);
                frm_Modificar.ShowDialog(this);
                listar();
            }
        }
    }
}
