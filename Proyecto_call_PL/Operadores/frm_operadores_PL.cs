﻿using System;
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
using Proyecto_call_PL.Operadores;

namespace Proyecto_call_PL.Formularios
{
    public partial class frm_operadores_PL : Form
    {
        #region Globales
        Cls_operadores_DAL Obj_Operadores_DAL = new Cls_operadores_DAL();
        Cls_operadores_BLL Obj_Operadores_BLL = new Cls_operadores_BLL();
        Cls_estados_DAL Obj_estados_DAL = new Cls_estados_DAL();
        Cls_estados_BLL Obj_estados_BLL = new Cls_estados_BLL();
        Cls_turnos_DAL Obj_turnos_DAL = new Cls_turnos_DAL();
        Cls_turnos_BLL Obj_turnos_BLL = new Cls_turnos_BLL();
        Int16 i16Fila;
        #endregion
        public frm_operadores_PL()
        {
            InitializeComponent();
        }

        private void frm_caso_detalle_PL_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            
            dtg_desplegar.DataSource = null;
            Obj_Operadores_BLL.Listar_operadores(ref Obj_Operadores_DAL);

            if (Obj_Operadores_DAL.smsjError == string.Empty)
            {
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_Operadores_DAL.Ds.Tables[0];

            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_Operadores_DAL.smsjError, "Error", MessageBoxButtons.OK);
            }
        }

        private void filtrar()
        {
            if (Obj_Operadores_DAL.smsjError == string.Empty)
            {

                Obj_Operadores_BLL.Filtrar_Operadores(ref Obj_Operadores_DAL, tstxt_valor_filtrar.Text.ToString());
                dtg_desplegar.DataSource = null;
                dtg_desplegar.DataSource = Obj_Operadores_DAL.Ds.Tables[0];
            }
            else
            {
                dtg_desplegar.DataSource = null;
                MessageBox.Show(" Se presento el siguiente error " + Obj_Operadores_DAL.smsjError, "Error", MessageBoxButtons.OK);
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

            if (dtg_desplegar.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro " +
                Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[0].Value)
                , "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_Operadores_DAL.sId_Operador = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[0].Value);
                    Obj_Operadores_BLL.Eliminar_Operadores(ref Obj_Operadores_DAL);
                    listar();
                }
            }
            
            
            
        }

        private void dtg_desplegar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i16Fila= Convert.ToInt16(e.RowIndex);
        }

        private void tsb_btn_modificar_Click(object sender, EventArgs e)
        {
            if (dtg_desplegar.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frm_ModificaOperador_PL frm_Modificar = new frm_ModificaOperador_PL
                    (ref Obj_Operadores_DAL, null,"Modificar", Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[0].Value));

                #region Cargar combobox 
                Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
                if (Obj_estados_DAL.smsjError == string.Empty)
                {
                    frm_Modificar.cmb_Estado.DisplayMember = "Descripción";
                    frm_Modificar.cmb_Estado.ValueMember = "Código";
                    frm_Modificar.cmb_Estado.DataSource = Obj_estados_DAL.Ds.Tables[0];
                }

                else
                {
                    MessageBox.Show(" Se presento el siguiente error " + Obj_estados_DAL.smsjError, "Error", MessageBoxButtons.OK);
                }

                Obj_turnos_BLL.listar_turnos(ref Obj_turnos_DAL);
                if (Obj_estados_DAL.smsjError == string.Empty)
                {
                    frm_Modificar.cmb_Turno.DisplayMember = "Descripción";
                    frm_Modificar.cmb_Turno.ValueMember = "Código";
                    frm_Modificar.cmb_Turno.DataSource = Obj_turnos_DAL.Ds.Tables[0];
                }
                else
                {
                    MessageBox.Show(" Se presento el siguiente error " + Obj_turnos_DAL.smsjError, "Error", MessageBoxButtons.OK);
                }


                #endregion

                Obj_turnos_BLL.listar_turnos(ref Obj_turnos_DAL);
                Obj_estados_BLL.listar_estados(ref Obj_estados_DAL);
                frm_Modificar.txt_Nombre.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[1].Value);
                frm_Modificar.txt_Apellido.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[2].Value);
                frm_Modificar.txt_Nick.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[3].Value);
                frm_Modificar.cmb_Nivel.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[5].Value);
                frm_Modificar.cmb_Turno.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[4].Value);
                frm_Modificar.cmb_Estado.Text = Convert.ToString(dtg_desplegar.Rows[i16Fila].Cells[6].Value);
                frm_Modificar.ShowDialog(this);
                listar();
            }
        }

        private void tsb_btn_agregar_Click(object sender, EventArgs e)
        {
            Obj_Operadores_DAL = new Cls_operadores_DAL();
            frm_ModificaOperador_PL frm_InsertUpdate_PL = new frm_ModificaOperador_PL(ref Obj_Operadores_DAL, null,"Insertar");
            frm_InsertUpdate_PL.ShowDialog(this);
            if (Obj_Operadores_DAL.bbandera)
            {
                MessageBox.Show("Se ha agregado correctamente", "Agregado correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                listar();
            }
            else
            {
                if (Obj_Operadores_DAL.smsjError != null)
                {
                    MessageBox.Show("Ha un ocurrido un error.\n\nDetalle: " + Obj_Operadores_DAL.smsjError, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsb_btn_actualizar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
