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


namespace Proyecto_call_PL.Operadores
{
    public partial class frm_InsertUpdate_PL : Form
    {
        #region Globales
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        #endregion
        public frm_InsertUpdate_PL(string sTipo, string sOperador="")
        {
            
            InitializeComponent();
            
            if (sTipo == "Insertar")
            {
                this.Text = "Ingreso de nuevo Operador";
            }
            else
            {
                this.Text = "Modoficación del "+ sOperador;
            }
        }

        private void cmb_Estado_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_Estado.ValueMember.ToString());
        }

        private void frm_InsertUpdate_PL_Load(object sender, EventArgs e)
        {
            #region Cargar combobox estados
            Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
            if (Obj_estados_DAL.smsjError == string.Empty)
            {
                cmb_Estado.DisplayMember = "Descripción";
                cmb_Estado.ValueMember = "Código";
                cmb_Estado.DataSource = Obj_estados_DAL.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
            #endregion
        }
    }
}
