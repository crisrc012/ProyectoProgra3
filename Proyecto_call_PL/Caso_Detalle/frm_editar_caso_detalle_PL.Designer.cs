namespace Proyecto_call_PL.Caso_Detalle
{
    partial class frm_editar_caso_detalle_PL
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
            this.btn_salir_caso_detalle = new System.Windows.Forms.Button();
            this.bt_insertar_caso_detalle = new System.Windows.Forms.Button();
            this.msk_modf_activo = new System.Windows.Forms.MaskedTextBox();
            this.msk_cread_activo = new System.Windows.Forms.MaskedTextBox();
            this.txt_modificadopor = new System.Windows.Forms.TextBox();
            this.txt_creadopor = new System.Windows.Forms.TextBox();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.txt_id_caso_detalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_placa_activo = new System.Windows.Forms.ComboBox();
            this.cmb_id_caso_curso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_salir_caso_detalle
            // 
            this.btn_salir_caso_detalle.Location = new System.Drawing.Point(166, 265);
            this.btn_salir_caso_detalle.Name = "btn_salir_caso_detalle";
            this.btn_salir_caso_detalle.Size = new System.Drawing.Size(75, 23);
            this.btn_salir_caso_detalle.TabIndex = 47;
            this.btn_salir_caso_detalle.Text = "Cancelar";
            this.btn_salir_caso_detalle.UseVisualStyleBackColor = true;
            this.btn_salir_caso_detalle.Click += new System.EventHandler(this.btn_salir_caso_detalle_Click);
            // 
            // bt_insertar_caso_detalle
            // 
            this.bt_insertar_caso_detalle.Location = new System.Drawing.Point(58, 265);
            this.bt_insertar_caso_detalle.Name = "bt_insertar_caso_detalle";
            this.bt_insertar_caso_detalle.Size = new System.Drawing.Size(75, 23);
            this.bt_insertar_caso_detalle.TabIndex = 46;
            this.bt_insertar_caso_detalle.Text = "Insertar";
            this.bt_insertar_caso_detalle.UseVisualStyleBackColor = true;
            this.bt_insertar_caso_detalle.Click += new System.EventHandler(this.bt_insertar_caso_detalle_Click);
            // 
            // msk_modf_activo
            // 
            this.msk_modf_activo.Location = new System.Drawing.Point(157, 203);
            this.msk_modf_activo.Mask = "0000/00/00";
            this.msk_modf_activo.Name = "msk_modf_activo";
            this.msk_modf_activo.Size = new System.Drawing.Size(100, 20);
            this.msk_modf_activo.TabIndex = 45;
            // 
            // msk_cread_activo
            // 
            this.msk_cread_activo.Location = new System.Drawing.Point(156, 155);
            this.msk_cread_activo.Mask = "0000/00/00";
            this.msk_cread_activo.Name = "msk_cread_activo";
            this.msk_cread_activo.Size = new System.Drawing.Size(100, 20);
            this.msk_cread_activo.TabIndex = 44;
            this.msk_cread_activo.ValidatingType = typeof(System.DateTime);
            // 
            // txt_modificadopor
            // 
            this.txt_modificadopor.Location = new System.Drawing.Point(157, 229);
            this.txt_modificadopor.MaxLength = 15;
            this.txt_modificadopor.Name = "txt_modificadopor";
            this.txt_modificadopor.Size = new System.Drawing.Size(100, 20);
            this.txt_modificadopor.TabIndex = 40;
            // 
            // txt_creadopor
            // 
            this.txt_creadopor.Location = new System.Drawing.Point(156, 177);
            this.txt_creadopor.MaxLength = 15;
            this.txt_creadopor.Name = "txt_creadopor";
            this.txt_creadopor.Size = new System.Drawing.Size(100, 20);
            this.txt_creadopor.TabIndex = 39;
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(185, 80);
            this.txt_observaciones.MaxLength = 450;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(100, 20);
            this.txt_observaciones.TabIndex = 37;
            // 
            // txt_id_caso_detalle
            // 
            this.txt_id_caso_detalle.Location = new System.Drawing.Point(185, 50);
            this.txt_id_caso_detalle.Name = "txt_id_caso_detalle";
            this.txt_id_caso_detalle.Size = new System.Drawing.Size(100, 20);
            this.txt_id_caso_detalle.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Modificado por";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Fecha de modificacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Creado por";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Fecha de creacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Observaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Id del caso en detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Placa_Activo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Id del caso en curso";
            // 
            // cmb_placa_activo
            // 
            this.cmb_placa_activo.FormattingEnabled = true;
            this.cmb_placa_activo.Location = new System.Drawing.Point(185, 106);
            this.cmb_placa_activo.Name = "cmb_placa_activo";
            this.cmb_placa_activo.Size = new System.Drawing.Size(121, 21);
            this.cmb_placa_activo.TabIndex = 41;
            // 
            // cmb_id_caso_curso
            // 
            this.cmb_id_caso_curso.FormattingEnabled = true;
            this.cmb_id_caso_curso.Location = new System.Drawing.Point(185, 129);
            this.cmb_id_caso_curso.Name = "cmb_id_caso_curso";
            this.cmb_id_caso_curso.Size = new System.Drawing.Size(121, 21);
            this.cmb_id_caso_curso.TabIndex = 42;
            // 
            // frm_editar_caso_detalle_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 326);
            this.Controls.Add(this.btn_salir_caso_detalle);
            this.Controls.Add(this.bt_insertar_caso_detalle);
            this.Controls.Add(this.msk_modf_activo);
            this.Controls.Add(this.msk_cread_activo);
            this.Controls.Add(this.cmb_id_caso_curso);
            this.Controls.Add(this.cmb_placa_activo);
            this.Controls.Add(this.txt_modificadopor);
            this.Controls.Add(this.txt_creadopor);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.txt_id_caso_detalle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_editar_caso_detalle_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar caso detalle";
            this.Load += new System.EventHandler(this.frm_editar_caso_detalle_PL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir_caso_detalle;
        private System.Windows.Forms.Button bt_insertar_caso_detalle;
        private System.Windows.Forms.MaskedTextBox msk_modf_activo;
        private System.Windows.Forms.MaskedTextBox msk_cread_activo;
        private System.Windows.Forms.TextBox txt_modificadopor;
        private System.Windows.Forms.TextBox txt_creadopor;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.TextBox txt_id_caso_detalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_placa_activo;
        private System.Windows.Forms.ComboBox cmb_id_caso_curso;
    }
}