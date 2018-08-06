namespace Proyecto_Progra3_PL
{
    partial class frm_Cat_Man_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cat_Man_PL));
            this.dgv_Cat_Man = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxt_FiltrarCat_Man_PL = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cat_Man)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Cat_Man
            // 
            this.dgv_Cat_Man.AllowUserToAddRows = false;
            this.dgv_Cat_Man.AllowUserToDeleteRows = false;
            this.dgv_Cat_Man.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Cat_Man.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Cat_Man.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgv_Cat_Man.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cat_Man.Location = new System.Drawing.Point(12, 28);
            this.dgv_Cat_Man.MultiSelect = false;
            this.dgv_Cat_Man.Name = "dgv_Cat_Man";
            this.dgv_Cat_Man.ReadOnly = true;
            this.dgv_Cat_Man.Size = new System.Drawing.Size(616, 453);
            this.dgv_Cat_Man.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstxt_FiltrarCat_Man_PL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Filtrar:";
            // 
            // tstxt_FiltrarCat_Man_PL
            // 
            this.tstxt_FiltrarCat_Man_PL.Name = "tstxt_FiltrarCat_Man_PL";
            this.tstxt_FiltrarCat_Man_PL.Size = new System.Drawing.Size(100, 25);
            this.tstxt_FiltrarCat_Man_PL.TextChanged += new System.EventHandler(this.tstxt_FiltrarCat_Man_PL_TextChanged);
            // 
            // frm_Cat_Man_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(640, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_Cat_Man);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Cat_Man_PL";
            this.Text = "Catálogos y mantenimientos";
            this.Load += new System.EventHandler(this.frm_Cat_Man_PL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cat_Man)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cat_Man;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxt_FiltrarCat_Man_PL;
    }
}