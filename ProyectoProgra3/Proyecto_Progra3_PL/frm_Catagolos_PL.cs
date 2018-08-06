using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Progra3_BLL.Catalogos_Mantenimientos.Activos;
using Proyecto_Progra3_DAL.Catalogos_Mantenimientos.Activos;

namespace Proyecto_Progra3_PL
{
    public partial class frm_Activos_PL : Form
    {
        public frm_Activos_PL()
        {
            InitializeComponent();
        }

        private void frm_Activos_PL_Load(object sender, EventArgs e)
        {
            Cls_activos_BLL OBJ_Activos_BLL = new Cls_activos_BLL();
            Cls_activos_DAL OBJ_Activos_DAL = new Cls_activos_DAL();
            OBJ_Activos_BLL.listar_activos(ref OBJ_Activos_DAL);
            if (OBJ_Activos_DAL.sMsjError== string.Empty)
            {
                dgv_Activos_PL.DataSource = null;
                dgv_Activos_PL.DataSource = OBJ_Activos_DAL.Obj_DS.Tables[0];
            }
            else
            {
                dgv_Activos_PL.DataSource = null;
                MessageBox.Show("Se ha producido un error en tablas categorias \n\n Error: "+
                                OBJ_Activos_DAL.sMsjError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
