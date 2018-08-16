namespace Proyecto_call_PL.Menu
{
    partial class frm_menu_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu_PL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_activo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_casodetalle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_casoencabezado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_departamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_estado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_marcactivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_operadores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_semaforo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_tipoactivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ver_turnos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 236);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.tsmi_salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_ver_activo,
            this.tsm_ver_casodetalle,
            this.tsm_ver_casoencabezado,
            this.tsm_ver_departamento,
            this.tsm_ver_estado,
            this.tsm_ver_marcactivo,
            this.tsm_ver_operadores,
            this.tsm_ver_semaforo,
            this.tsm_ver_tipoactivo,
            this.tsm_ver_turnos});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.menuToolStripMenuItem.Text = "Ver tablas";
            // 
            // tsm_ver_activo
            // 
            this.tsm_ver_activo.Name = "tsm_ver_activo";
            this.tsm_ver_activo.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_activo.Text = "Activos";
            this.tsm_ver_activo.Click += new System.EventHandler(this.tsm_ver_activo_Click);
            // 
            // tsm_ver_casodetalle
            // 
            this.tsm_ver_casodetalle.Name = "tsm_ver_casodetalle";
            this.tsm_ver_casodetalle.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_casodetalle.Text = "Casos detalle";
            this.tsm_ver_casodetalle.Click += new System.EventHandler(this.tsm_ver_casodetalle_Click);
            // 
            // tsm_ver_casoencabezado
            // 
            this.tsm_ver_casoencabezado.Name = "tsm_ver_casoencabezado";
            this.tsm_ver_casoencabezado.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_casoencabezado.Text = "Casos encabezado";
            // 
            // tsm_ver_departamento
            // 
            this.tsm_ver_departamento.Name = "tsm_ver_departamento";
            this.tsm_ver_departamento.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_departamento.Text = "Departamento";
            // 
            // tsm_ver_estado
            // 
            this.tsm_ver_estado.Name = "tsm_ver_estado";
            this.tsm_ver_estado.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_estado.Text = "Estados";
            this.tsm_ver_estado.Click += new System.EventHandler(this.tsm_ver_estado_Click);
            // 
            // tsm_ver_marcactivo
            // 
            this.tsm_ver_marcactivo.Name = "tsm_ver_marcactivo";
            this.tsm_ver_marcactivo.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_marcactivo.Text = "Marca de activo";
            this.tsm_ver_marcactivo.Click += new System.EventHandler(this.tsm_ver_marcactivo_Click);
            // 
            // tsm_ver_operadores
            // 
            this.tsm_ver_operadores.Name = "tsm_ver_operadores";
            this.tsm_ver_operadores.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_operadores.Text = "Operadores";
            this.tsm_ver_operadores.Click += new System.EventHandler(this.tsm_ver_operadores_Click);
            // 
            // tsm_ver_semaforo
            // 
            this.tsm_ver_semaforo.Name = "tsm_ver_semaforo";
            this.tsm_ver_semaforo.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_semaforo.Text = "Semaforo";
            this.tsm_ver_semaforo.Click += new System.EventHandler(this.tsm_ver_semaforo_Click);
            // 
            // tsm_ver_tipoactivo
            // 
            this.tsm_ver_tipoactivo.Name = "tsm_ver_tipoactivo";
            this.tsm_ver_tipoactivo.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_tipoactivo.Text = "Tipo de activo";
            // 
            // tsm_ver_turnos
            // 
            this.tsm_ver_turnos.Name = "tsm_ver_turnos";
            this.tsm_ver_turnos.Size = new System.Drawing.Size(171, 22);
            this.tsm_ver_turnos.Text = "Turnos";
            this.tsm_ver_turnos.Click += new System.EventHandler(this.tsm_ver_turnos_Click);
            // 
            // tsmi_salir
            // 
            this.tsmi_salir.Name = "tsmi_salir";
            this.tsmi_salir.Size = new System.Drawing.Size(41, 20);
            this.tsmi_salir.Text = "Salir";
            this.tsmi_salir.Click += new System.EventHandler(this.tsmi_salir_Click);
            // 
            // frm_menu_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 251);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_menu_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_activo;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_casodetalle;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_casoencabezado;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_departamento;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_estado;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_marcactivo;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_operadores;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_semaforo;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_tipoactivo;
        private System.Windows.Forms.ToolStripMenuItem tsm_ver_turnos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_salir;
    }
}