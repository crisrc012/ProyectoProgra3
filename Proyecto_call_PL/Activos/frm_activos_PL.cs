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
using Proyecto_call_BLL.Interfaces;
using Proyecto_call_BLL.Repositories;
using Proyecto_call_DAL.Catalogos_Mantenimientos;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_PL.Activos
{
    public partial class frm_activos_PL : Form
    {
        #region Globales
        Cls_activos_DAL Obj_activos_DAL = new Cls_activos_DAL();
        Cls_activos_BLL Obj_activos_BLL = new Cls_activos_BLL();
        #endregion
        public frm_activos_PL()
        {
            InitializeComponent();
        }

        private void frm_activos_PL_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            dtg_desplegar.DataSource = null;
            Obj_activos_BLL.listar_activos(ref Obj_activos_DAL);

            if (Obj_activos_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_activos_DAL.Ds.Tables[0];

            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_activos_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_activos_DAL.smsjError == string.Empty)
            {
                Obj_activos_BLL.filtrar_activos(ref Obj_activos_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_activos_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_activos_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }   
        }

        private void tstxt_valor_filtrar_TextChanged(object sender, EventArgs e)
        {
            if (tstxt_valor_filtrar.Text.ToString().Trim() == "")
            {
                listar();
            }
            else
            {
                filtrar();
            }
        }

        private void tsb_btn_eliminar_Click(object sender, EventArgs e)
        {
             if (dtg_desplegar.Rows.Count >= 1)
             {
                if ((MessageBox.Show("Seguro que desea eliminar la fila seleccionada", "ADVERTENCIA",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                  {
                    string svalor = (dtg_desplegar.SelectedRows[0].Cells[0].Value).ToString();
                    Obj_activos_BLL.eliminar_activos(ref Obj_activos_DAL, svalor);
                    if (Obj_activos_DAL.smsjError == string.Empty)
                        {
                         listar();
                    }
                    else
                    {
                       MessageBox.Show(" Se presento el siguiente error " + Obj_activos_DAL.smsjError, "Error", MessageBoxButtons.OK);
                       dtg_desplegar.DataSource = null;
                    }
                }
            }
        }

        private void tsb_btn_agregar_Click(object sender, EventArgs e)
        {
            frm_editar_activos_PL Obj_editar_activos = new frm_editar_activos_PL(ref Obj_activos_DAL, Bootstrap.GetInstance<IRepository<Departamentos, int>>());
            Obj_activos_DAL.cAxn = Convert.ToChar("I");
            Obj_editar_activos.Obj_activos_DAL = Obj_activos_DAL;
            Obj_editar_activos.ShowDialog();

            if (Obj_activos_DAL.bbandera == true)
            {
                MessageBox.Show("El registro se agrego con exito", "Informacion", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El registro no se pudo agregar" + Obj_activos_DAL.smsjError, "Informacion", MessageBoxButtons.OK);
            }
        }

        private void tsb_btn_modificar_Click(object sender, EventArgs e)
        {
            frm_editar_activos_PL Obj_editar_activos = new frm_editar_activos_PL(ref Obj_activos_DAL, Bootstrap.GetInstance<IRepository<Departamentos, int>>());
            Obj_activos_DAL.cAxn = Convert.ToChar("U");
            Obj_editar_activos.Obj_activos_DAL = Obj_activos_DAL;

            Obj_activos_DAL.iPlaca_Activo = Convert.ToInt32(dtg_desplegar.SelectedRows[0].Cells[0].Value.ToString());
            Obj_activos_DAL.sDesc_Activo = dtg_desplegar.SelectedRows[0].Cells[2].Value.ToString();
            Obj_activos_DAL.sUsuCreacion = dtg_desplegar.SelectedRows[0].Cells[8].Value.ToString();
            Obj_activos_DAL.dFecCreacion = Convert.ToDateTime(dtg_desplegar.SelectedRows[0].Cells[7].Value.ToString());
            Obj_activos_DAL.dPrioridad_SLA = Convert.ToDecimal(dtg_desplegar.SelectedRows[0].Cells[5].Value);


            Obj_editar_activos.ShowDialog();

            if (Obj_activos_DAL.bbandera == true)
            {
                MessageBox.Show("El registro se agrego con exito", "Informacion", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El registro no se pudo agregar" + Obj_activos_DAL.smsjError, "Informacion", MessageBoxButtons.OK);
            }
        }
    }
}
