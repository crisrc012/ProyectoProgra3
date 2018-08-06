using System;
using System.Windows.Forms;
using Proyecto_Progra3_DAL.Catalogos_Mantenimientos;
using Proyecto_Progra3_BLL.Catalogos_Mantenimientos;

namespace Proyecto_Progra3_PL
{
    public partial class frm_Cat_Man_PL : Form
    {
        private string sSentencia;
        private string sParam;
        public frm_Cat_Man_PL(string sSentencia, string sParam)
        {
            InitializeComponent();
            this.sSentencia = sSentencia;
            this.sParam = sParam;
            // Establece el título de la ventana
            Text = Text + " de " + sSentencia;
        }

        private void frm_Cat_Man_PL_Load(object sender, EventArgs e)
        {
            Cls_Cat_Man_BLL Obj_Cat_Man_BLL = new Cls_Cat_Man_BLL();
            Cls_Cat_Man_DAL Obj_Cat_Man_DAL = new Cls_Cat_Man_DAL();
            Obj_Cat_Man_BLL.listar_Cat_Man(ref Obj_Cat_Man_DAL, sSentencia);
            if (Obj_Cat_Man_DAL.sMsjError == string.Empty)
            {
                dgv_Cat_Man.DataSource = null;
                dgv_Cat_Man.DataSource = Obj_Cat_Man_DAL.Obj_DS.Tables[0];
            }
            else
            {
                dgv_Cat_Man.DataSource = null;
                MessageBox.Show("Se ha producido un error.\n\nError: "+
                                Obj_Cat_Man_DAL.sMsjError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void tstxt_FiltrarCat_Man_PL_TextChanged(object sender, EventArgs e)
        {
            Cls_Cat_Man_DAL Obj_Cat_Man_DAL = new Cls_Cat_Man_DAL();
            Cls_Cat_Man_BLL Obj_Cat_Man_BLL = new Cls_Cat_Man_BLL();

            if (tstxt_FiltrarCat_Man_PL.Text == string.Empty)
            {
                Obj_Cat_Man_BLL.listar_Cat_Man(ref Obj_Cat_Man_DAL, sSentencia);
            }
            else
            {
                Obj_Cat_Man_BLL.filtrar_Cat_Man(ref Obj_Cat_Man_DAL,
                    tstxt_FiltrarCat_Man_PL.Text.Trim(), sSentencia, sParam);
            }
            if (Obj_Cat_Man_DAL.sMsjError == string.Empty)
            {
                dgv_Cat_Man.DataSource = null;
                dgv_Cat_Man.DataSource = Obj_Cat_Man_DAL.Obj_DS.Tables[0];
            }
            else
            {
                dgv_Cat_Man.DataSource = null;
                MessageBox.Show("Se ha producido un error en tablas categorias \n\n Error: " +
                                Obj_Cat_Man_DAL.sMsjError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
