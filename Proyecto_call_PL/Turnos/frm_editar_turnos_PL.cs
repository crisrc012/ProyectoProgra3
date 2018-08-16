using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_PL.Turnos;

namespace Proyecto_call_PL.Turnos
{
    public partial class frm_editar_turnos_PL : Form
    {
        #region Variable Globales
        public Cls_turnos_DAL Obj_turnos_DAL;
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
                //cmb_Estado
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
                //cmb_Estado
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_editar_turnos_PL_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }
    }
}
