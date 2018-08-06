using System;
using System.Windows.Forms;

namespace Proyecto_Progra3_PL
{
    public partial class frm_Menu : Form
    {
        private frm_Cat_Man_PL frmActivos, frmCaso_Detalle,
            frmCaso_Encabezado, frmDepartamento, frmEstados,
            frmMarca_Activo, frmOperadores,frmSemaforo_Casos,
            frmTipo_Activo, frmTurnos;
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmActivos == null)
            {
                frmActivos = new frm_Cat_Man_PL("ACTIVOS", "@Desc_Activo");
                frmActivos.FormClosed += new FormClosedEventHandler(FrmActivos_FormClosed);
                frmActivos.Show();
            }
            else
            {
                frmActivos.Activate();
            }
        }

        private void FrmActivos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmActivos = null;
        }

        private void detalleDelCasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCaso_Detalle == null)
            {
                frmCaso_Detalle = new frm_Cat_Man_PL("CASO_DETALLE", "@Observaciones");
                frmCaso_Detalle.FormClosed += new FormClosedEventHandler(frmCaso_Detalle_FormClosed);
                frmCaso_Detalle.Show();
            }
            else
            {
                frmCaso_Detalle.Activate();
            }
        }
        private void frmCaso_Detalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCaso_Detalle = null;
        }

        private void encabezadoDelCasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCaso_Encabezado == null)
            {
                frmCaso_Encabezado = new frm_Cat_Man_PL("CASO_ENCABEZADO", "@ComentariosReporte");
                frmCaso_Encabezado.FormClosed += new FormClosedEventHandler(frmCaso_Encabezado_FormClosed);
                frmCaso_Encabezado.Show();
            }
            else
            {
                frmCaso_Encabezado.Activate();
            }
        }
        private void frmCaso_Encabezado_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCaso_Encabezado = null;
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDepartamento == null)
            {
                frmDepartamento = new frm_Cat_Man_PL("DEPARTAMENTOS", "@Desc_Departamento");
                frmDepartamento.FormClosed += new FormClosedEventHandler(frmDepartamento_FormClosed);
                frmDepartamento.Show();
            }
            else
            {
                frmDepartamento.Activate();
            }
        }

        private void frmDepartamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDepartamento = null;
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEstados == null)
            {
                frmEstados = new frm_Cat_Man_PL("ESTADOS", "@Desc_Estado");
                frmEstados.FormClosed += new FormClosedEventHandler(frmEstados_FormClosed);
                frmEstados.Show();
            }
            else
            {
                frmDepartamento.Activate();
            }
        }

        private void frmEstados_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEstados = null;
        }

        private void marcaDeActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMarca_Activo == null)
            {
                frmMarca_Activo = new frm_Cat_Man_PL("MARCAACTIVO", "@Desc_MarcaActivo");
                frmMarca_Activo.FormClosed += new FormClosedEventHandler(frmMarca_Activo_FormClosed);
                frmMarca_Activo.Show();
            }
            else
            {
                frmMarca_Activo.Activate();
            }
        }
        private void frmMarca_Activo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMarca_Activo = null;
        }

        private void operadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOperadores == null)
            {
                frmOperadores = new frm_Cat_Man_PL("OPERADORES", "@Id_Operador");
                frmOperadores.FormClosed += new FormClosedEventHandler(frmOperadores_FormClosed);
                frmOperadores.Show();
            }
            else
            {
                frmOperadores.Activate();
            }
        }
        private void frmOperadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOperadores = null;
        }

        private void semaforoDeCasosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSemaforo_Casos == null)
            {
                frmSemaforo_Casos = new frm_Cat_Man_PL("SEMAFOROCASOS", "@Desc_Estado_SemaforoCaso");
                frmSemaforo_Casos.FormClosed += new FormClosedEventHandler(frmSemaforo_Casos_FormClosed);
                frmSemaforo_Casos.Show();
            }
            else
            {
                frmOperadores.Activate();
            }
        }
        private void frmSemaforo_Casos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSemaforo_Casos = null;
        }
        private void tipoDeActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTipo_Activo == null)
            {
                frmTipo_Activo = new frm_Cat_Man_PL("TIPOACTIVO", "@Desc_TipoActivo");
                frmTipo_Activo.FormClosed += new FormClosedEventHandler(frmTipo_Activo_FormClosed);
                frmTipo_Activo.Show();
            }
            else
            {
                frmTipo_Activo.Activate();
            }
        }
        private void frmTipo_Activo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTipo_Activo = null;
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTurnos == null)
            {
                frmTurnos = new frm_Cat_Man_PL("TURNOS", "@Desc_Turno");
                frmTurnos.FormClosed += new FormClosedEventHandler(frmTurnos_FormClosed);
                frmTurnos.Show();
            }
            else
            {
                frmTurnos.Activate();
            }
        }
        private void frmTurnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTurnos = null;
        }
    }
}
