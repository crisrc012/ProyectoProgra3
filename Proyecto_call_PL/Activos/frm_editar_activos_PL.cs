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
        public Cls_activos_DAL Obj_activos_DAL;
        Cls_activos_BLL Obj_activos_BLL = new Cls_activos_BLL();


        #endregion
        public frm_editar_activos_PL(ref Cls_activos_DAL Obj_activos_DAL)
        {
            InitializeComponent();

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

        private void frm_editar_activos_PL_Load(object sender, EventArgs e)
        {
            if (Obj_activos_DAL.cAxn.ToString().Contains("I"))
            {
                msk_modf_activo.Enabled = false;
                txt_modificadopor.Enabled = false;
                msk_cread_activo.Enabled = false;
                txt_placa_activo.Enabled = false;
            }
            else
            {
                msk_cread_activo.Enabled = false;
                txt_creadopor.Enabled = false;
                msk_modf_activo.Enabled = false;
                txt_placa_activo.Enabled = false;
                msk_cread_activo.Text = Obj_estados_DAL.dFecCreacion.ToString();
                txt_creadopor.Text = Obj_estados_DAL.sUsuCreacion.ToString();
            }
        }

        private void btn_insertar_activo_Click(object sender, EventArgs e)
        {
            if ((txt_desc_activo.Text == string.Empty) || (txt_creadopor.Text == string.Empty) || (txt_prioridad_activo.Text == string.Empty))
            {
                MessageBox.Show("Debe seleccionar alguna opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_creadopor.Clear();
                txt_desc_activo.Clear();
                return;
            }
            else
            {
                Obj_activos_DAL.sDesc_Activo = txt_desc_activo.Text.ToString().Trim();
                Obj_activos_DAL.sUsuCreacion = txt_creadopor.Text.ToString().Trim();
                Obj_activos_DAL.dFecCreacion = DateTime.Now;
                Obj_activos_DAL.dPrioridad_SLA = Convert.ToDecimal( txt_prioridad_activo.Text.ToString().Trim());
                Obj_activos_DAL.iPlaca_Activo = Obj_activos_DAL.iPlaca_Activo;
                Obj_activos_DAL.iId_Departamento_Responsable = Convert.ToInt32(cmb_departamento.SelectedValue);
                Obj_activos_DAL.iId_MarcaActivo = Convert.ToInt32(cmb_marca_activo.SelectedValue);
                Obj_activos_DAL.iId_TipoActivo = Convert.ToInt32(cmb_tipo_activo.SelectedValue);     
            }

            if (Obj_activos_DAL.cAxn.ToString().Contains("I"))
            {
                Obj_activos_BLL.insertar_activos(ref Obj_activos_DAL);
            }
            else
            {
                Obj_activos_BLL.modificar_activos(ref Obj_activos_DAL);
            }

            Close();
        }
    }
}
