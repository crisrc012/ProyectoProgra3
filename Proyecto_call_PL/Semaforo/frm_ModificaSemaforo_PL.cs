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

namespace Proyecto_call_PL.Semaforo
{
    public partial class frm_ModificaSemaforo_PL : Form
    {
        #region Globales
        Cls_semaforo_DAL Obj_Semaforo_DAL = new Cls_semaforo_DAL();
        Cls_semaforo_BLL Obj_Semaforo_BLL = new Cls_semaforo_BLL();
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        Cls_turnos_DAL Obj_turnos_DAL = new Cls_turnos_DAL();
        Cls_turnos_BLL Obj_turnos_BLL = new Cls_turnos_BLL();
        private string _sEstado;
        private bool insert = false;

        public object Operadores_PL { get; }
        #endregion
        public frm_ModificaSemaforo_PL(ref Cls_semaforo_DAL Obj_Semaforo_DAL, string sEstado, string sTipo, char cId_Semaforo = '-')
        {
            InitializeComponent();
            if (sTipo == "Insertar")
            {
                this.Text = "Ingreso de nuevo Semaforo";
                #region Cargar combobox
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
            else
            {
                this.Text = "Modoficación del Semaforo Id" + cId_Semaforo.ToString();
            }
            _sEstado = sEstado;
            #region Valida insert o Update
            if (cId_Semaforo == '0')
            {
                // Insert
                insert = true;
            }
            else
            {
                // Update
                Obj_Semaforo_DAL.cId_Estado_SemaforoCaso = cId_Semaforo;
            }
            this.Obj_Semaforo_DAL = Obj_Semaforo_DAL;
            #endregion
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (txt_Descripcion.Text.Trim() == string.Empty ||
                txt_Color.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe llenar todos los datos", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Obj_Semaforo_DAL.sColor = txt_Color.Text.Trim();
            Obj_Semaforo_DAL.sDesc_Estado_SemaforoCaso = txt_Descripcion.Text.Trim();
            Obj_Semaforo_DAL.cId_Estado = Convert.ToChar(cmb_Estado.SelectedValue);

            if (Obj_Semaforo_DAL.cId_Estado == '\0')
            {
                Obj_Semaforo_DAL.cId_Estado = '1';
            }
            if (Obj_Semaforo_DAL.smsjError==String.Empty)
            {
                if (insert)
                {
                    Obj_Semaforo_BLL.Insertar_Semaforo(ref Obj_Semaforo_DAL);
                    Obj_Semaforo_DAL.bbandera = true;
                }
                else
                {
                    Obj_Semaforo_BLL.Modificar_Semaforo(ref Obj_Semaforo_DAL);
                    if (Obj_Semaforo_DAL.smsjError!= string.Empty)
                    {
                        MessageBox.Show(" Se presento el siguiente error " + Obj_Semaforo_DAL.smsjError, "Error", MessageBoxButtons.OK);
                    }
                    
                }
                Close();
            }
            else
            {
                MessageBox.Show(" Se presento el siguiente error " + Obj_Semaforo_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
            
        }
    }
}
