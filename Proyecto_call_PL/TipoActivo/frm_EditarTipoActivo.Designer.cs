namespace Proyecto_call_PL.TipoActivo
{
    partial class frm_EditarTipoActivo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.cmb_TipoActivo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Accion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(19, 36);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(461, 22);
            this.txt_Descripcion.TabIndex = 1;
            // 
            // cmb_TipoActivo
            // 
            this.cmb_TipoActivo.FormattingEnabled = true;
            this.cmb_TipoActivo.Location = new System.Drawing.Point(19, 85);
            this.cmb_TipoActivo.Name = "cmb_TipoActivo";
            this.cmb_TipoActivo.Size = new System.Drawing.Size(461, 24);
            this.cmb_TipoActivo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(21, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Activo";
            // 
            // btn_Accion
            // 
            this.btn_Accion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Accion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accion.ForeColor = System.Drawing.Color.White;
            this.btn_Accion.Location = new System.Drawing.Point(19, 131);
            this.btn_Accion.Name = "btn_Accion";
            this.btn_Accion.Size = new System.Drawing.Size(461, 46);
            this.btn_Accion.TabIndex = 12;
            this.btn_Accion.UseVisualStyleBackColor = false;
            this.btn_Accion.Click += new System.EventHandler(this.btn_Accion_Click);
            // 
            // frm_EditarTipoActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 211);
            this.Controls.Add(this.btn_Accion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_TipoActivo);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_EditarTipoActivo";
            this.Text = "frm_EditarTipoActivo";
            this.Load += new System.EventHandler(this.frm_EditarTipoActivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.ComboBox cmb_TipoActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Accion;
    }
}