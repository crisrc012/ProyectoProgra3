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

namespace Proyecto_call_PL.Formularios
{
    public partial class frm_operadores_PL : Form
    {
        #region Globales
        Cls_operadores_DAL Obj_Operadores_DAL = new Cls_operadores_DAL();
        Cls_operadores_BLL Obj_Operadores_BLL = new Cls_operadores_BLL();
        Int16 i16Fila;
        #endregion
        public frm_operadores_PL()
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
            Obj_Operadores_BLL.Listar_operadores(ref Obj_Operadores_DAL);

            if (Obj_Operadores_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_Operadores_DAL.Ds.Tables[0];

            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_Operadores_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_Operadores_DAL.smsjError == string.Empty)
            {

                Obj_Operadores_BLL.Filtrar_Operadores(ref Obj_Operadores_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_Operadores_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_Operadores_DAL.smsjError, "Error", MessageBoxButtons.OK);
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

            if (dtg_desplegar.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro " +
                Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[0].Value)
                , "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_Operadores_DAL.sId_Operador = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[0].Value);
                    Obj_Operadores_BLL.Eliminar_Operadores(ref Obj_Operadores_DAL);
                    listar();
                }
            }
            
            
            
        }

        private void dtg_desplegar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            i16Fila= Convert.ToInt16(e.RowIndex);

        }
    }
}
