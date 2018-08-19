namespace Proyecto_call_PL.DepartamentoForms
{
    partial class VerDepartamentosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerDepartamentosForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_btn_agregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_btn_modificar = new System.Windows.Forms.ToolStripButton();
            this.tsb_btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.dtg_desplegar = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_desplegar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtFiltro,
            this.toolStripSeparator1,
            this.tsb_btn_actualizar,
            this.toolStripSeparator2,
            this.tsb_btn_agregar,
            this.toolStripSeparator3,
            this.tsb_btn_modificar,
            this.tsb_btn_eliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(123, 22);
            this.toolStripLabel1.Text = "Filtrar por Descripción";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 25);
            this.txtFiltro.TextChanged += new System.EventHandler(this.ListarDepartamentos_Event);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_btn_actualizar
            // 
            this.tsb_btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_btn_actualizar.Image")));
            this.tsb_btn_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_btn_actualizar.Name = "tsb_btn_actualizar";
            this.tsb_btn_actualizar.Size = new System.Drawing.Size(79, 22);
            this.tsb_btn_actualizar.Text = "Actualizar";
            this.tsb_btn_actualizar.Click += new System.EventHandler(this.ListarDepartamentos_Event);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_btn_agregar
            // 
            this.tsb_btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_btn_agregar.Image")));
            this.tsb_btn_agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_btn_agregar.Name = "tsb_btn_agregar";
            this.tsb_btn_agregar.Size = new System.Drawing.Size(69, 22);
            this.tsb_btn_agregar.Text = "Agregar";
            this.tsb_btn_agregar.Click += new System.EventHandler(this.tsb_btn_agregar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_btn_modificar
            // 
            this.tsb_btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_btn_modificar.Image")));
            this.tsb_btn_modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_btn_modificar.Name = "tsb_btn_modificar";
            this.tsb_btn_modificar.Size = new System.Drawing.Size(78, 22);
            this.tsb_btn_modificar.Text = "Modificar";
            this.tsb_btn_modificar.Click += new System.EventHandler(this.tsb_btn_modificar_Click);
            // 
            // tsb_btn_eliminar
            // 
            this.tsb_btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_btn_eliminar.Image")));
            this.tsb_btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_btn_eliminar.Name = "tsb_btn_eliminar";
            this.tsb_btn_eliminar.Size = new System.Drawing.Size(70, 22);
            this.tsb_btn_eliminar.Text = "Eliminar";
            this.tsb_btn_eliminar.Click += new System.EventHandler(this.tsb_btn_eliminar_Click);
            // 
            // dtg_desplegar
            // 
            this.dtg_desplegar.AllowUserToAddRows = false;
            this.dtg_desplegar.AllowUserToDeleteRows = false;
            this.dtg_desplegar.AllowUserToResizeRows = false;
            this.dtg_desplegar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_desplegar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_desplegar.Location = new System.Drawing.Point(12, 47);
            this.dtg_desplegar.MultiSelect = false;
            this.dtg_desplegar.Name = "dtg_desplegar";
            this.dtg_desplegar.ReadOnly = true;
            this.dtg_desplegar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_desplegar.Size = new System.Drawing.Size(760, 502);
            this.dtg_desplegar.TabIndex = 2;
            // 
            // VerDepartamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtg_desplegar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "VerDepartamentosForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.ListarDepartamentos_Event);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_desplegar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_btn_actualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_btn_agregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_btn_modificar;
        private System.Windows.Forms.ToolStripButton tsb_btn_eliminar;
        private System.Windows.Forms.DataGridView dtg_desplegar;
    }
}