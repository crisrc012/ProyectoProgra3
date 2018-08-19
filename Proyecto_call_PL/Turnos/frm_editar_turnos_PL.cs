using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_PL.Turnos;

namespace Proyecto_call_PL.Turnos
{
    public partial class frm_editar_turnos_PL : Form
    {
        #region Variable Globales
        public Cls_turnos_DAL Obj_turnos_DAL;
        public string _sEstado;
        public Cls_turnos_BLL Obj_turnos_BLL = new Cls_turnos_BLL();
        public Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        public Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        #endregion

        public frm_editar_turnos_PL()
        {
            InitializeComponent();
        }

        private void cargar_datos()
        {
            //evaluar si es inser habilitar dos cajas de texto, si es actualizar, inabilitar el id y cargar datos
            

            if (Obj_turnos_DAL.cAxn == 'I')
            {
                txt_Id_Turno.Enabled = true;
                txt_Descripcion.Enabled = true;

                txt_Id_Turno.Text = string.Empty;
                txt_Descripcion.Text = string.Empty;
                txt_Cant_Horas.Text = string.Empty;
                txt_Hora_Entrada.Text = string.Empty;
                txt_Hora_Salida.Text = string.Empty;

                Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
                if (Obj_estados_DAL.smsjError == string.Empty)
                {
                    cmb_Estado.DisplayMember = "Descripción";
                    cmb_Estado.ValueMember = "Código";
                    cmb_Estado.DataSource = Obj_estados_DAL.Ds.Tables[0];
                }
            }
            else
            {
                txt_Id_Turno.Enabled = false;
                txt_Descripcion.Enabled = true;

                txt_Id_Turno.Text = Obj_turnos_DAL.cId_Turno.ToString();
                txt_Descripcion.Text = Obj_turnos_DAL.sDesc_Turno.ToString();
                txt_Cant_Horas.Text = Obj_turnos_DAL.iCant_Horas.ToString();
                txt_Hora_Entrada.Text = Obj_turnos_DAL.sHoraEntrada.ToString();
                txt_Hora_Salida.Text = Obj_turnos_DAL.sHoraSalida.ToString();

                Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
                
                if (Obj_estados_DAL.smsjError == string.Empty)
                {
                    cmb_Estado.DisplayMember = "Descripción";
                    cmb_Estado.ValueMember = "Código";
                    cmb_Estado.DataSource = Obj_estados_DAL.Ds.Tables[0];
                    cmb_Estado.Text = _sEstado;
                }
            }
        }

        private void Validar_Numero(KeyPressEventArgs e, string Texto)
        {
            // Obtengo la configuracion del sistema
            CultureInfo ConfReg = CultureInfo.CurrentCulture;
            var FormatoNumberos = ConfReg.NumberFormat;

            // Si es un numero, borrar
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)8))
            {
                
                e.Handled = false;// No hace nada y dejamos que el sistema controle la pulsación de tecla
                return;
            }
            else if (e.KeyChar == (char)13) // Si es un enter
            {
                e.Handled = true; // Interceptamos la pulsación para que no tenga lugar
                SendKeys.Send("{TAB}"); // Pulsamos la tecla Tabulador por código
            }
            else // Para el resto de las teclas
            {
                e.Handled = true; // Interceptamos la pulsación para que no tenga lugar
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            if ((txt_Descripcion.Text == string.Empty) || (txt_Cant_Horas.Text == string.Empty) || (txt_Hora_Entrada.Text == string.Empty) || (txt_Hora_Salida.Text == string.Empty))
            {
                MessageBox.Show("Debe llenar toda la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Obj_turnos_DAL = new Cls_turnos_DAL();
                Obj_turnos_DAL.cId_Turno = Convert.ToChar(txt_Id_Turno.Text);
                Obj_turnos_DAL.sDesc_Turno = txt_Descripcion.Text;
                Obj_turnos_DAL.iCant_Horas = Convert.ToInt16(txt_Cant_Horas.Text);
                Obj_turnos_DAL.sHoraEntrada = txt_Hora_Entrada.Text;
                Obj_turnos_DAL.sHoraSalida = txt_Hora_Salida.Text;
                Obj_turnos_DAL.cId_Estado = Convert.ToChar(cmb_Estado.SelectedValue);

                if (Obj_turnos_DAL.cAxn == 'I')
                {
                    Obj_turnos_BLL.insertar_turnos(ref Obj_turnos_DAL);
                    if (Obj_turnos_DAL.smsjError != string.Empty)
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_turnos_DAL.smsjError, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Obj_turnos_BLL.modificar_turnos(ref Obj_turnos_DAL);
                    if (Obj_turnos_DAL.smsjError != string.Empty)
                    {
                        MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_turnos_DAL.smsjError, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

            Close();
        }

        private void frm_editar_turnos_PL_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void txt_Cant_Horas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numero(e, txt_Cant_Horas.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
