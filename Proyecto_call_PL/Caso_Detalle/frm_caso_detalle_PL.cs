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

namespace Proyecto_call_PL.Caso_Detalle
{
    public partial class frm_caso_detalle_PL : Form
    {
        #region Globales
        Cls_casodetalle_DAL Obj_casodetalle_DAL = new Cls_casodetalle_DAL();
        Cls_casodetalle_BLL Obj_casodetalle_BLL = new Cls_casodetalle_BLL();
        #endregion
        public frm_caso_detalle_PL()
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
            Obj_casodetalle_BLL.listar_casodetalle(ref Obj_casodetalle_DAL);

            if (Obj_casodetalle_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_casodetalle_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_casodetalle_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_casodetalle_DAL.smsjError == string.Empty)
            {
                
                Obj_casodetalle_BLL.filtrar_casodetalle(ref Obj_casodetalle_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_casodetalle_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_casodetalle_DAL.smsjError, "Error", MessageBoxButtons.OK);
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
           if (dtg_desplegar.RowCount >=1)
             {
                if ((MessageBox.Show("Seguro que desea eliminar la fila seleccionada", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    string _svalor = dtg_desplegar.SelectedRows[0].Cells[0].Value.ToString();
                    Obj_casodetalle_BLL.eliminar_casodetalle(ref Obj_casodetalle_DAL, _svalor);

                    if (Obj_casodetalle_DAL.smsjError == string.Empty)
                    { 
                        MessageBox.Show("El dato se borro exitosamente", "Aviso", MessageBoxButtons.OK);
                        listar();
                    }
                    else
                    {
                        dtg_desplegar.DataSource = null;
                        MessageBox.Show(" Se presento el siguiente error " + Obj_casodetalle_DAL.smsjError, "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void tsb_btn_agregar_Click(object sender, EventArgs e)
        {
            frm_editar_caso_detalle_PL Obj_editar_caso_detalle = new frm_editar_caso_detalle_PL();
            Obj_casodetalle_DAL.cAxn = Convert.ToChar("I");
            Obj_editar_caso_detalle.Obj_casodetalle_DAL = Obj_casodetalle_DAL;
            Obj_editar_caso_detalle.ShowDialog();

            if (Obj_casodetalle_DAL.bbandera == true)
            {
                MessageBox.Show("El registro se agrego con exito", "Informacion", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El registro no se pudo agregar" + Obj_casodetalle_DAL.smsjError, "Informacion", MessageBoxButtons.OK);
            }
        }

        

        private void tsb_btn_modificar_Click(object sender, EventArgs e)
        {
            Obj_casodetalle_DAL.iId_Caso_Enc =  Convert.ToInt32( dtg_desplegar.SelectedRows[0].Cells[0].Value.ToString());
            Obj_casodetalle_DAL.sUsuCreacion = dtg_desplegar.SelectedRows[0].Cells[5].Value.ToString();
            Obj_casodetalle_DAL.dFecCreacion = Convert.ToDateTime( dtg_desplegar.SelectedRows[0].Cells[4].Value.ToString());


            frm_editar_caso_detalle_PL Obj_editar_caso_detalle = new frm_editar_caso_detalle_PL();
            Obj_casodetalle_DAL.cAxn = Convert.ToChar("U");
            Obj_editar_caso_detalle.Obj_casodetalle_DAL = Obj_casodetalle_DAL;
            Obj_editar_caso_detalle.ShowDialog();

            if (Obj_casodetalle_DAL.bbandera == true)
            {
                MessageBox.Show("El registro se agrego con exito", "Informacion", MessageBoxButtons.OK);
                listar();
            }
            else
            {
                MessageBox.Show("El registro no se pudo agregar" + Obj_casodetalle_DAL.smsjError, "Informacion", MessageBoxButtons.OK);
            }
        }
    }
}
