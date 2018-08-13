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

namespace Proyecto_call_PL.Activos
{
    public partial class frm_activos_PL : Form
    {
        #region Globales
        Cls_activos_DAL Obj_activos_DAL = new Cls_activos_DAL();
        Cls_activos_BLL Obj_activos_BLL = new Cls_activos_BLL();
        #endregion
        public frm_activos_PL()
        {
            InitializeComponent();
        }

        private void frm_activos_PL_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            dtg_desplegar.DataSource = null;
            Obj_activos_BLL.listar_activos(ref Obj_activos_DAL);

            if (Obj_activos_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_activos_DAL.Ds.Tables[0];

            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_activos_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_activos_DAL.smsjError == string.Empty)
            {
                Obj_activos_BLL.filtrar_activos(ref Obj_activos_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_activos_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_activos_DAL.smsjError, "Error", MessageBoxButtons.OK);
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
            if (Obj_activos_DAL.smsjError == string.Empty)
            {
                if (dtg_desplegar.Rows.Count >= 1)
                {
                    string _svalor = dtg_desplegar.SelectedRows[0].Cells[0].Value.ToString();
                    Obj_activos_BLL.eliminar_activos(ref Obj_activos_DAL, _svalor);
                    MessageBox.Show("El dato se borro exitosamente", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    dtg_desplegar.DataSource = null;
                    MessageBox.Show(" Se presento el siguiente error " + Obj_activos_DAL.smsjError, "Error", MessageBoxButtons.OK);
                }
            }
            
        }
    }
}
