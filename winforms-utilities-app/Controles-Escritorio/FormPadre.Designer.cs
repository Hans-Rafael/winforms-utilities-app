namespace Controles_Escritorio
{
    partial class FormPadre
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
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnConversor = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculadora.Location = new System.Drawing.Point(20, 122);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(165, 50);
            this.btnCalculadora.TabIndex = 1;
            this.btnCalculadora.Text = "Calculadora de Descuento";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassword.Location = new System.Drawing.Point(20, 242);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(165, 50);
            this.btnPassword.TabIndex = 2;
            this.btnPassword.Text = "Validador de Contraseñas";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnConversor
            // 
            this.btnConversor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConversor.Location = new System.Drawing.Point(20, 361);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(165, 50);
            this.btnConversor.TabIndex = 3;
            this.btnConversor.Text = "Conversor de Unidades";
            this.btnConversor.UseVisualStyleBackColor = true;
            this.btnConversor.Click += new System.EventHandler(this.btnConversor_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.lblGrupo);
            this.panelMenu.Controls.Add(this.lblMenu);
            this.panelMenu.Controls.Add(this.btnConversor);
            this.panelMenu.Controls.Add(this.btnCalculadora);
            this.panelMenu.Controls.Add(this.btnPassword);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 526);
            this.panelMenu.TabIndex = 4;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGrupo.Location = new System.Drawing.Point(12, 481);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(180, 18);
            this.lblGrupo.TabIndex = 6;
            this.lblGrupo.Text = "Grupo: tp1-bd1-10db10utn";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMenu.Location = new System.Drawing.Point(71, 35);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(63, 24);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 526);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Name = "FormPadre";
            this.Text = "FormPadre";
            this.Load += new System.EventHandler(this.FormPadre_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnConversor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblGrupo;
    }
}