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
using Proyecto_call_PL.Activos;

namespace Proyecto_call_PL.Activos
{
    public partial class frm_editar_activos_PL : Form
    {
        #region Globales para combos

        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        Cls_departamentos_DAL Obj_departamento_DAL = new Cls_departamentos_DAL();
        Cls_departamentos_BLL Obj_departamento_BLL = new Cls_departamentos_BLL();
        Cls_marcaactivo_DAL Obj_marcaactivo_DAL = new Cls_marcaactivo_DAL();
        Cls_marcaactivo_BLL Obj_marcaactivo_BLL = new Cls_marcaactivo_BLL();
        Cls_tipoactivo_DAL Obj_tipoactivo_DAL = new Cls_tipoactivo_DAL();
        Cls_tipoactivo_BLL Obj_tipoactivo_BLL = new Cls_tipoactivo_BLL();


        #endregion
        public frm_editar_activos_PL(ref Cls_activos_DAL Obj_activos_DAL)
        {
            InitializeComponent();

        }

        private void frm_editar_activos_PL_Load(object sender, EventArgs e)
        {
            llenar_combos();
        }

        private void llenar_combos()
        {
            #region Combo estados
            Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
            if (Obj_estados_DAL.smsjError == string.Empty)
            {
                cmb_estado.DisplayMember = "Descripción";
                cmb_estado.ValueMember = "Código";
                cmb_estado.DataSource = Obj_estados_DAL.Ds.Tables[0];
            }

            #endregion

            #region Combo tipos
            //Obj_tipoactivo_BLL.(ref Obj_tipoactivo_DAL);
            if (Obj_marcaactivo_DAL.smsjError == string.Empty)
            {
                cmb_marca_activo.DisplayMember = "Descripción";
                cmb_marca_activo.ValueMember = "Código";
                cmb_marca_activo.DataSource = Obj_tipoactivo_DAL.Ds.Tables[0];
            }
            #endregion
            #region Combo Marca
            Obj_marcaactivo_BLL.listar_marcaactivo(ref Obj_marcaactivo_DAL);
            if (Obj_marcaactivo_DAL.smsjError == string.Empty)
            {
                cmb_marca_activo.DisplayMember = "Descripción";
                cmb_marca_activo.ValueMember = "Código";
                cmb_marca_activo.DataSource = Obj_marcaactivo_DAL.Ds.Tables[0];
            }
            #endregion

            #region Combo departamentos
            //Obj_departamento_BLL.listar_(ref Obj_departamento_DAL);
            if (Obj_marcaactivo_DAL.smsjError == string.Empty)
            {
                cmb_marca_activo.DisplayMember = "Descripción";
                cmb_marca_activo.ValueMember = "Código";
                cmb_marca_activo.DataSource = Obj_departamento_DAL.Ds.Tables[0];
            }


            #endregion
        }
    }
}
