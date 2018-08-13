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
    }
}
