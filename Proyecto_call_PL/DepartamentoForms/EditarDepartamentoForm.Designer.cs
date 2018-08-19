namespace Proyecto_call_PL.DepartamentoForms
{
    partial class EditarDepartamentoForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUsuarioCreacion = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblFechaModificación = new System.Windows.Forms.Label();
            this.lblUsuarioModificacion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.txtUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtFechaModificacion = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(43, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(155, 24);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Departamento:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(83, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(115, 24);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(125, 109);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 24);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // lblUsuarioCreacion
            // 
            this.lblUsuarioCreacion.AutoSize = true;
            this.lblUsuarioCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCreacion.Location = new System.Drawing.Point(38, 152);
            this.lblUsuarioCreacion.Name = "lblUsuarioCreacion";
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(160, 24);
            this.lblUsuarioCreacion.TabIndex = 3;
            this.lblUsuarioCreacion.Text = "Usuario Creación:";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(48, 205);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(150, 24);
            this.lblFechaCreacion.TabIndex = 4;
            this.lblFechaCreacion.Text = "Fecha Creación:";
            // 
            // lblFechaModificación
            // 
            this.lblFechaModificación.AutoSize = true;
            this.lblFechaModificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificación.Location = new System.Drawing.Point(23, 310);
            this.lblFechaModificación.Name = "lblFechaModificación";
            this.lblFechaModificación.Size = new System.Drawing.Size(175, 24);
            this.lblFechaModificación.TabIndex = 6;
            this.lblFechaModificación.Text = "Fecha Modificación";
            // 
            // lblUsuarioModificacion
            // 
            this.lblUsuarioModificacion.AutoSize = true;
            this.lblUsuarioModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioModificacion.Location = new System.Drawing.Point(8, 257);
            this.lblUsuarioModificacion.Name = "lblUsuarioModificacion";
            this.lblUsuarioModificacion.Size = new System.Drawing.Size(190, 24);
            this.lblUsuarioModificacion.TabIndex = 5;
            this.lblUsuarioModificacion.Text = "Usuario Modificación:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(205, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(407, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(205, 58);
            this.txtDescripcion.MaxLength = 65;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(407, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtUsuarioCreacion
            // 
            this.txtUsuarioCreacion.Location = new System.Drawing.Point(205, 152);
            this.txtUsuarioCreacion.MaxLength = 15;
            this.txtUsuarioCreacion.Name = "txtUsuarioCreacion";
            this.txtUsuarioCreacion.ReadOnly = true;
            this.txtUsuarioCreacion.Size = new System.Drawing.Size(407, 20);
            this.txtUsuarioCreacion.TabIndex = 4;
            // 
            // txtUsuarioModificacion
            // 
            this.txtUsuarioModificacion.Location = new System.Drawing.Point(205, 257);
            this.txtUsuarioModificacion.MaxLength = 15;
            this.txtUsuarioModificacion.Name = "txtUsuarioModificacion";
            this.txtUsuarioModificacion.ReadOnly = true;
            this.txtUsuarioModificacion.Size = new System.Drawing.Size(407, 20);
            this.txtUsuarioModificacion.TabIndex = 6;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(205, 205);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(407, 20);
            this.txtFechaCreacion.TabIndex = 5;
            // 
            // txtFechaModificacion
            // 
            this.txtFechaModificacion.Location = new System.Drawing.Point(205, 310);
            this.txtFechaModificacion.Name = "txtFechaModificacion";
            this.txtFechaModificacion.ReadOnly = true;
            this.txtFechaModificacion.Size = new System.Drawing.Size(407, 20);
            this.txtFechaModificacion.TabIndex = 7;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(205, 109);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(407, 21);
            this.cmbEstado.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(98, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(185, 35);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(349, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(185, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // EditarDepartamentoForm
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtFechaModificacion);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtUsuarioModificacion);
            this.Controls.Add(this.txtUsuarioCreacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblFechaModificación);
            this.Controls.Add(this.lblUsuarioModificacion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblUsuarioCreacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "EditarDepartamentoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.EditarDepartamentoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUsuarioCreacion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblFechaModificación;
        private System.Windows.Forms.Label lblUsuarioModificacion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUsuarioCreacion;
        private System.Windows.Forms.TextBox txtUsuarioModificacion;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtFechaModificacion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}