namespace Proyecto_call_PL.Operadores
{
    partial class frm_ModificaOperador_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ModificaOperador_PL));
            cmb_Estado = new System.Windows.Forms.ComboBox();
            cmb_Turno = new System.Windows.Forms.ComboBox();
            txt_Nombre = new System.Windows.Forms.TextBox();
            txt_Apellido = new System.Windows.Forms.TextBox();
            txt_Nick = new System.Windows.Forms.TextBox();
            cmb_Nivel = new System.Windows.Forms.ComboBox();
            btnAccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Estado
            // 
            cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Location = new System.Drawing.Point(351, 37);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new System.Drawing.Size(95, 21);
            cmb_Estado.TabIndex = 0;
            // 
            // cmb_Turno
            // 
            cmb_Turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_Turno.FormattingEnabled = true;
            cmb_Turno.Location = new System.Drawing.Point(351, 92);
            cmb_Turno.Name = "cmb_Turno";
            cmb_Turno.Size = new System.Drawing.Size(95, 21);
            cmb_Turno.TabIndex = 0;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new System.Drawing.Point(98, 25);
            txt_Nombre.MaxLength = 45;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new System.Drawing.Size(152, 26);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new System.Drawing.Point(98, 57);
            txt_Apellido.MaxLength = 140;
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new System.Drawing.Size(152, 26);
            txt_Apellido.TabIndex = 1;
            // 
            // txt_Nick
            // 
            txt_Nick.Location = new System.Drawing.Point(98, 91);
            txt_Nick.MaxLength = 10;
            txt_Nick.Name = "txt_Nick";
            txt_Nick.Size = new System.Drawing.Size(152, 26);
            txt_Nick.TabIndex = 1;
            // 
            // cmb_Nivel
            // 
            cmb_Nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_Nivel.FormattingEnabled = true;
            cmb_Nivel.Items.AddRange(new object[] {
            "Nivel 0",
            "Nivel 1",
            "Nivel 2",
            "Nivel 3"});
            cmb_Nivel.Location = new System.Drawing.Point(98, 123);
            cmb_Nivel.Name = "cmb_Nivel";
            cmb_Nivel.Size = new System.Drawing.Size(152, 28);
            cmb_Nivel.TabIndex = 0;
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.Color.Transparent;
            this.btnAccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccion.BackgroundImage")));
            this.btnAccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccion.Location = new System.Drawing.Point(394, 176);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(52, 50);
            this.btnAccion.TabIndex = 2;
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(cmb_Nivel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(txt_Nombre);
            this.groupBox1.Controls.Add(txt_Apellido);
            this.groupBox1.Controls.Add(txt_Nick);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "NickName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Turno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Estado";
            // 
            // frm_InsertUpdate_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(cmb_Turno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(cmb_Estado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_InsertUpdate_PL";
            this.Text = "frm_InsertUpdate_PL";
            this.Load += new System.EventHandler(this.frm_InsertUpdate_PL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.ComboBox cmb_Estado;
        public  System.Windows.Forms.ComboBox cmb_Turno;
        public  System.Windows.Forms.TextBox txt_Nombre;
        public  System.Windows.Forms.TextBox txt_Apellido;
        public  System.Windows.Forms.TextBox txt_Nick;
        public  System.Windows.Forms.ComboBox cmb_Nivel;
        public  System.Windows.Forms.Button btnAccion;
        public  System.Windows.Forms.Label label1;
        public  System.Windows.Forms.GroupBox groupBox1;
        public  System.Windows.Forms.Label label4;
        public  System.Windows.Forms.Label label3;
        public  System.Windows.Forms.Label label2;
        public  System.Windows.Forms.Label label5;
        public  System.Windows.Forms.Label label6;
    }
}