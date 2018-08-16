using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using System;
using System.Windows.Forms;

namespace Proyecto_call_PL.Estados
{
    public partial class frm_editar_estados_PL : Form
    {
        #region Globales
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        bool insert = false;
        #endregion

        public frm_editar_estados_PL(ref Cls_estados_DAL Obj_estados_DAL)
        {
            InitializeComponent();
            if (Obj_estados_DAL.cId_Estado == '\0')
            {
                // Insert
                insert = true;
                btnAccion.Text = "Agregar";
            }
            else
            {
                // Update
                btnAccion.Text = "Modificar";
                txtDescripcion.Text = Obj_estados_DAL.sDesc_Estado;
            }
            this.Obj_estados_DAL = Obj_estados_DAL;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            Obj_estados_DAL.sDesc_Estado = txtDescripcion.Text.Trim();
            if (insert)
            {
                Obj_estados_BLL.insertar_estados(ref Obj_estados_DAL);
            }
            else
            {
                Obj_estados_BLL.modificar_estados(ref Obj_estados_DAL);
            }
            Close();
        }
    }
}
