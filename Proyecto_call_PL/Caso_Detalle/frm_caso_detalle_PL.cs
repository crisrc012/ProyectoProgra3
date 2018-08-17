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
            if (Obj_casodetalle_DAL.smsjError == string.Empty)
            {
                if (dtg_desplegar.RowCount >=1)
                {
                    int _ivalor = Convert.ToInt32( dtg_desplegar.SelectedRows[0].Cells[0].Value.ToString());
                    Obj_casodetalle_BLL.eliminar_casodetalle(ref Obj_casodetalle_DAL,_ivalor);
                    MessageBox.Show("El dato se borro exitosamente", "Aviso", MessageBoxButtons.OK);
                    listar();
                }
                else
                {
                    dtg_desplegar.DataSource = null;
                    MessageBox.Show(" Se presento el siguiente error " + Obj_casodetalle_DAL.smsjError, "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
