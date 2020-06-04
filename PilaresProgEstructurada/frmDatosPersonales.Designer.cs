namespace PilaresProgEstructurada
{
    partial class frmDatosPersonales
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
            this.btnPasoValor = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPasoValor
            // 
            this.btnPasoValor.Location = new System.Drawing.Point(501, 83);
            this.btnPasoValor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasoValor.Name = "btnPasoValor";
            this.btnPasoValor.Size = new System.Drawing.Size(96, 24);
            this.btnPasoValor.TabIndex = 19;
            this.btnPasoValor.Text = "Paso por Valor";
            this.btnPasoValor.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(432, 130);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 20);
            this.txtValor.TabIndex = 18;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(399, 174);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 17;
            this.lblNombres.Text = "Nombres";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(18, 172);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(371, 130);
            this.txtResultado.TabIndex = 16;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(402, 83);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 24);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(192, 133);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(197, 20);
            this.txtNombres.TabIndex = 14;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(192, 94);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.MaxLength = 30;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(197, 20);
            this.txtApellidos.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingresa tus nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingresa tus Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(137, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bienvenidos al Sistema de Registro de Docentes";
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 324);
            this.Controls.Add(this.btnPasoValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmListas";
            this.Text = "DATOS PERSONALES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasoValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}