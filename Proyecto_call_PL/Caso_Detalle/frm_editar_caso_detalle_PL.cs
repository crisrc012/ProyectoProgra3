using System;
using System.Windows.Forms;
using Proyecto_call_BLL.Catalogos_Mantenimientos;
using Proyecto_call_BLL.Interfaces;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_PL.Caso_Detalle
{

    public partial class frm_editar_caso_detalle_PL : Form
    {
        #region Globales
        Cls_activos_DAL Obj_activos_DAL = new Cls_activos_DAL();
        Cls_activos_BLL Obj_activos_BLL = new Cls_activos_BLL();
        Cls_casoencabezado_DAL Obj_casoencabezado_DAL = new Cls_casoencabezado_DAL();
        Cls_casoencabezado_BLL Obj_casoencabezado_BLL = new Cls_casoencabezado_BLL();
        public Cls_casodetalle_DAL Obj_casodetalle_DAL;
        Cls_casodetalle_BLL Obj_casodetalle_BLL = new Cls_casodetalle_BLL();

        #endregion
        public frm_editar_caso_detalle_PL(IRepository<Encabezado, int> repository)
        {
            InitializeComponent();

            #region Combo placa activo
            Obj_activos_BLL.listar_activos(ref Obj_activos_DAL);
            if (Obj_activos_DAL.smsjError == string.Empty)
            {
                cmb_placa_activo.DisplayMember = "Descripción";
                cmb_placa_activo.ValueMember = "Código";
                cmb_placa_activo.DataSource = Obj_activos_DAL.Ds.Tables[0];
            }

            #endregion

            #region Combo caso

            //if (Obj_casoencabezado_DAL.smsjError == string.Empty)
            //{
            //    var mockObject = new Cls_casoencabezado_DAL {iId_Caso_Enc = -1 };
            //    cmb_id_caso_curso.DisplayMember = "Descripcion";
            //    cmb_id_caso_curso.ValueMember = "Id";
            //    cmb_id_caso_curso.DataSource = _encabezadoRepository.List(mockObject);
            //}



            cmb_id_caso_curso.DisplayMember = "Id";
            cmb_id_caso_curso.ValueMember = "Id";
            var mockObject = new Encabezado { Id = -1 };
            cmb_id_caso_curso.DataSource = repository.List(mockObject);
            #endregion

        }

        private void frm_editar_caso_detalle_PL_Load(object sender, EventArgs e)
        {
            if (Obj_casodetalle_DAL.cAxn.ToString().Contains("I"))
            {
                txt_id_caso_detalle.Enabled = false;
                msk_modf_activo.Enabled = false;
                txt_modificadopor.Enabled = false;
                msk_cread_activo.Enabled = false;
            }
            else
            {
                msk_cread_activo.Enabled = false;
                txt_creadopor.Enabled = false;
                msk_modf_activo.Enabled = false;
                txt_id_caso_detalle.Enabled = false;
                msk_cread_activo.Text = Obj_casodetalle_DAL.dFecCreacion.ToString();
                txt_creadopor.Text = Obj_casodetalle_DAL.sUsuCreacion.ToString();
                txt_id_caso_detalle.Text = Obj_casodetalle_DAL.iId_Caso_Enc.ToString();

            }

        }

        private void bt_insertar_caso_detalle_Click(object sender, EventArgs e)
        {
            var id = cmb_id_caso_curso.SelectedValue; // LECTURA DEL COMBO BOX DE CASO ENCABEZADO
            if ((txt_observaciones.Text == string.Empty) || (txt_creadopor.Text == string.Empty))
            {
                MessageBox.Show("Debe seleccionar alguna opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_creadopor.Clear();
                txt_observaciones.Clear();
                return;
            }
            else
            {
                MessageBox.Show("Procedemos con la ejecucion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Obj_casodetalle_DAL.cAxn.ToString().Contains("I"))
            {
                Obj_casodetalle_DAL.sObservaciones = txt_observaciones.Text.ToString().Trim();
                Obj_casodetalle_DAL.sUsuCreacion = txt_creadopor.Text.ToString().Trim();
                Obj_casodetalle_DAL.dFecCreacion = DateTime.Now;
                Obj_casodetalle_DAL.iPlaca_Activo = Convert.ToInt32(cmb_placa_activo.SelectedValue);
                Obj_casodetalle_DAL.iId_Caso_Enc = 4;

                Obj_casodetalle_BLL.insertar_casodetalle(ref Obj_casodetalle_DAL);

                if (Obj_casodetalle_DAL.smsjError == string.Empty)
                {
                    Obj_casodetalle_DAL.bbandera = true;
                }
                else
                {
                    Obj_casodetalle_DAL.bbandera = false;
                }
            }
            else
            {
                Obj_casodetalle_DAL.iId_Caso_Enc = Convert.ToInt32(txt_id_caso_detalle.Text.ToString());
                Obj_casodetalle_DAL.sObservaciones = txt_observaciones.Text.ToString().Trim();
                Obj_casodetalle_DAL.dFecModificacion = DateTime.Now;
                Obj_casodetalle_DAL.sUsuModificacion = txt_modificadopor.Text.Trim();




                Obj_casodetalle_BLL.modificar_casodetalle(ref Obj_casodetalle_DAL);
                if (Obj_casodetalle_DAL.smsjError == string.Empty)
                {
                    Obj_casodetalle_DAL.bbandera = true;
                }
                else
                {
                    Obj_casodetalle_DAL.bbandera = false;
                }
            }

            Close();
        }

        private void btn_salir_caso_detalle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
