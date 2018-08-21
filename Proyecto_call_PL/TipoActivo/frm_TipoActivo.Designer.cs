namespace Proyecto_call_PL.TipoActivo
{
    partial class frm_TipoActivo
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
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            this.txt_Filtrar = new System.Windows.Forms.TextBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Location = new System.Drawing.Point(12, 56);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.Size = new System.Drawing.Size(833, 340);
            this.dtg_Datos.TabIndex = 0;
            // 
            // txt_Filtrar
            // 
            this.txt_Filtrar.Location = new System.Drawing.Point(12, 22);
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(177, 20);
            this.txt_Filtrar.TabIndex = 1;
            this.txt_Filtrar.TextChanged += new System.EventHandler(this.txt_Filtrar_TextChanged);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.Green;
            this.btn_Actualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar.Location = new System.Drawing.Point(213, 8);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(131, 34);
            this.btn_Actualizar.TabIndex = 2;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Location = new System.Drawing.Point(361, 8);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(131, 34);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_Eliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(509, 8);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(131, 34);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Gray;
            this.btn_Modificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(659, 8);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(131, 34);
            this.btn_Modificar.TabIndex = 6;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // frm_TipoActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 423);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.txt_Filtrar);
            this.Controls.Add(this.dtg_Datos);
            this.Name = "frm_TipoActivo";
            this.Text = "frm_TipoActivo";
            this.Load += new System.EventHandler(this.frm_TipoActivo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.TextBox txt_Filtrar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modificar;
    }
}