using System;
using System.Windows.Forms;
using Proyecto_call_PL.Activos;
using Proyecto_call_PL.Caso_Detalle;
using Proyecto_call_PL.Formularios;
using Proyecto_call_PL.Estados;
using Proyecto_call_PL.MarcaActivo;
using Proyecto_call_PL.Turnos;

namespace Proyecto_call_PL.Menu
{
    public partial class frm_menu_PL : Form
    {
        public static frm_operadores_PL Operadores_PL=new frm_operadores_PL();
        public frm_menu_PL()
        {
            InitializeComponent();
        }

        #region Activos
        private void tsm_ver_activo_Click(object sender, EventArgs e)
        {
            frm_activos_PL activos = new frm_activos_PL();
            activos.ShowDialog();
           
        }
        #endregion
        private void tsm_ver_casodetalle_Click(object sender, EventArgs e)
        {
            frm_caso_detalle_PL activos = new frm_caso_detalle_PL();
            activos.ShowDialog();
        }
        #region Operadores
        private void tsm_ver_operadores_Click(object sender, EventArgs e)
        {
            Operadores_PL.ShowDialog();
        }
        #endregion

        #region Semaforo
        private void tsm_ver_semaforo_Click(object sender, EventArgs e)
        {
            frm_Semaforo_PL Semaforo_PL  = new frm_Semaforo_PL();
            Semaforo_PL.ShowDialog();
        }
        #endregion

        private void tsmi_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tsm_ver_estado_Click(object sender, EventArgs e)
        {
            frm_estados_PL estados = new frm_estados_PL();
            estados.ShowDialog();
        }

        private void tsm_ver_marcactivo_Click(object sender, EventArgs e)
        {
            frm_marcaactivo_PL marcaactivo = new frm_marcaactivo_PL();
            marcaactivo.ShowDialog();
        }

        #region Turnos
        private void tsm_ver_turnos_Click(object sender, EventArgs e)
        {
            frm_turnos_PL estados = new frm_turnos_PL();
            estados.ShowDialog();
        }
        #endregion
    }
}
