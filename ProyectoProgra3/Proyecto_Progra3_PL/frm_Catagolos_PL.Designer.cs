namespace Proyecto_Progra3_PL
{
    partial class frm_Catagolos_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Catagolos_PL));
            this.dgv_Catalogos_PL = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxt_FiltrarCat_PL = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Catalogos_PL)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Catalogos_PL
            // 
            this.dgv_Catalogos_PL.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgv_Catalogos_PL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Catalogos_PL.Location = new System.Drawing.Point(27, 46);
            this.dgv_Catalogos_PL.Name = "dgv_Catalogos_PL";
            this.dgv_Catalogos_PL.Size = new System.Drawing.Size(578, 292);
            this.dgv_Catalogos_PL.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstxt_FiltrarCat_PL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Filtrar Catalogo";
            // 
            // tstxt_FiltrarCat_PL
            // 
            this.tstxt_FiltrarCat_PL.Name = "tstxt_FiltrarCat_PL";
            this.tstxt_FiltrarCat_PL.Size = new System.Drawing.Size(100, 25);
            // 
            // frm_Catagolos_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(640, 365);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_Catalogos_PL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Catagolos_PL";
            this.Text = "Administración Catalogos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Catalogos_PL)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Catalogos_PL;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxt_FiltrarCat_PL;
    }
}