namespace Proyecto_call_PL.Caso_Detalle
{
    partial class frm_caso_detalle_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_caso_detalle_PL));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxt_valor_filtrar = new System.Windows.Forms.ToolStripTextBox();
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
            this.tstxt_valor_filtrar,
            this.toolStripSeparator1,
            this.tsb_btn_actualizar,
            this.toolStripSeparator2,
            this.tsb_btn_agregar,
            this.toolStripSeparator3,
            this.tsb_btn_modificar,
            this.tsb_btn_eliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // tstxt_valor_filtrar
            // 
            this.tstxt_valor_filtrar.Name = "tstxt_valor_filtrar";
            this.tstxt_valor_filtrar.Size = new System.Drawing.Size(100, 25);
            this.tstxt_valor_filtrar.TextChanged += new System.EventHandler(this.tstxt_valor_filtrar_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_btn_actualizar
            // 
            this.tsb_btn_actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_btn_actualizar.Image")));
            this.tsb_btn_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_btn_actualizar.Name = "tsb_btn_actualizar";
            this.tsb_btn_actualizar.Size = new System.Drawing.Size(23, 22);
            this.tsb_btn_actualizar.Text = "Actualizar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_btn_agregar
            // 
            this.tsb_btn_agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_btn_agregar.Image")));
            this.tsb_btn_agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_btn_agregar.Name = "tsb_btn_agregar";
            this.tsb_btn_agregar.Size = new System.Drawing.Size(23, 22);
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
            this.tsb_btn_modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_btn_modificar.Image")));
            this.tsb_btn_modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_btn_modificar.Name = "tsb_btn_modificar";
            this.tsb_btn_modificar.Size = new System.Drawing.Size(23, 22);
            this.tsb_btn_modificar.Text = "Modificar";
            // 
            // tsb_btn_eliminar
            // 
            this.tsb_btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_btn_eliminar.Image")));
            this.tsb_btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_btn_eliminar.Name = "tsb_btn_eliminar";
            this.tsb_btn_eliminar.Size = new System.Drawing.Size(23, 22);
            this.tsb_btn_eliminar.Text = "Eliminar";
            this.tsb_btn_eliminar.Click += new System.EventHandler(this.tsb_btn_eliminar_Click);
            // 
            // dtg_desplegar
            // 
            this.dtg_desplegar.AllowUserToAddRows = false;
            this.dtg_desplegar.AllowUserToDeleteRows = false;
            this.dtg_desplegar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_desplegar.Location = new System.Drawing.Point(12, 43);
            this.dtg_desplegar.MultiSelect = false;
            this.dtg_desplegar.Name = "dtg_desplegar";
            this.dtg_desplegar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_desplegar.Size = new System.Drawing.Size(612, 192);
            this.dtg_desplegar.TabIndex = 2;
            // 
            // frm_caso_detalle_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 249);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtg_desplegar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_caso_detalle_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caso Detalle";
            this.Load += new System.EventHandler(this.frm_caso_detalle_PL_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_desplegar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxt_valor_filtrar;
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