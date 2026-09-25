namespace Controles_Escritorio
{
    partial class FormConversor
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.rbCelsToFahr = new System.Windows.Forms.RadioButton();
            this.rbFahrToCels = new System.Windows.Forms.RadioButton();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Conversor de Temperatura";
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(106, 124);
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(169, 20);
            this.numValor.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(106, 84);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(88, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor a Convertir:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(106, 173);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(125, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion de conversion:";
            // 
            // rbCelsToFahr
            // 
            this.rbCelsToFahr.AutoSize = true;
            this.rbCelsToFahr.Location = new System.Drawing.Point(106, 218);
            this.rbCelsToFahr.Name = "rbCelsToFahr";
            this.rbCelsToFahr.Size = new System.Drawing.Size(152, 17);
            this.rbCelsToFahr.TabIndex = 5;
            this.rbCelsToFahr.TabStop = true;
            this.rbCelsToFahr.Text = "Celcius --> Fahrenheit ( ºF )";
            this.rbCelsToFahr.UseVisualStyleBackColor = true;
            // 
            // rbFahrToCels
            // 
            this.rbFahrToCels.AutoSize = true;
            this.rbFahrToCels.Location = new System.Drawing.Point(106, 255);
            this.rbFahrToCels.Name = "rbFahrToCels";
            this.rbFahrToCels.Size = new System.Drawing.Size(150, 17);
            this.rbFahrToCels.TabIndex = 6;
            this.rbFahrToCels.TabStop = true;
            this.rbFahrToCels.Text = "Fahrenheit --> Celcius( ºC )";
            this.rbFahrToCels.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(106, 302);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(102, 23);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(106, 356);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(199, 59);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado se mostrara aqui  ";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.rbFahrToCels);
            this.Controls.Add(this.rbCelsToFahr);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormConversor";
            this.Text = "FormConversor";
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.RadioButton rbCelsToFahr;
        private System.Windows.Forms.RadioButton rbFahrToCels;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
    }
}