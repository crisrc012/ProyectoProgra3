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
        Cls_operadores_DAL Obj_Operadores_DAL = new Cls_operadores_DAL();
        Cls_operadores_BLL Obj_Operadores_BLL = new Cls_operadores_BLL();
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        private string _sEstado;
        private bool insert = false;
        #endregion
        public frm_InsertUpdate_PL(ref Cls_operadores_DAL Obj_Operadores_DAL, string sEstado, string sTipo, string sOperador="")
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

            
            _sEstado = sEstado;
            #region Valida insert o Update
            if (sOperador == string.Empty)
            {
                // Insert
                insert = true;
            }
            else
            {
                // Update
                txt_Nombre.Text = Obj_Operadores_DAL.sNombre_Operador;
                cmb_Estado.SelectedValue = Obj_Operadores_DAL.cId_Estado;
                cmb_Estado.Refresh();
            }
            this.Obj_Operadores_DAL = Obj_Operadores_DAL;
            #endregion
            

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

        private void btnAccion_Click(object sender, EventArgs e)
        {
            
            if (Obj_Operadores_DAL.sNombre_Operador == txt_Nombre.Text.Trim() &&
                
            Obj_Operadores_DAL.cId_Estado == Convert.ToChar(cmb_Estado.SelectedValue)&&
               Obj_Operadores_DAL.sApellidos_Operador == txt_Apellido.Text && 
               Obj_Operadores_DAL.sNivel == cmb_Nivel.SelectedText.ToString() &&
               Obj_Operadores_DAL.cId_Turno == Convert.ToChar(cmb_Turno.SelectedValue))
            {
                MessageBox.Show("No ha cambiado ningún valor", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_Nombre.Text.Trim() == string.Empty ||
                txt_Apellido.Text.Trim() == string.Empty ||
                txt_Nick.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe llenar todos los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Obj_Operadores_DAL.sNombre_Operador = txt_Nombre.Text.Trim();
            Obj_Operadores_DAL.sApellidos_Operador = txt_Apellido.Text.Trim();
            Obj_Operadores_DAL.sNickNameOperador = txt_Nick.Text.Trim();
            Obj_Operadores_DAL.sNivel = cmb_Nivel.SelectedItem.ToString();
            Obj_Operadores_DAL.cId_Estado = Convert.ToChar(cmb_Estado.SelectedValue);
            if (Obj_Operadores_DAL.cId_Estado == '\0')
            {
                Obj_Operadores_DAL.cId_Estado = '1';
            }
            if (insert)
            {
                Obj_Operadores_BLL.Insertar_Operadores(ref Obj_Operadores_DAL);
                Obj_Operadores_DAL.bbandera = true;//Revisar por que esto genera un error si no se pone
            }
            else
            {
                Obj_Operadores_BLL.Modificar_Operadores(ref Obj_Operadores_DAL);
            }
            Close();
        }
    }
}
