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
    }
}
