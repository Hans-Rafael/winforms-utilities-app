using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_Escritorio
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }
         //ckeck largo >7
         private bool EsLongitudValida(string pass)
        {
            return pass.Length > 7;
        }

        //almenos 1 digit o 1 mayuscula
        private bool TieneNumeroYMayuscula(string pass)
        {
            bool tieneNumero = false;
            bool tieneMayuscula = false;

            for (int i = 0; i < pass.Length; i++)
            {
                char c = pass[i]; // caracter en la posicion i

                if (char.IsDigit(c))
                {
                    tieneNumero = true;
                }

                if (char.IsUpper(c))
                {
                    tieneMayuscula = true;
                }
                if (tieneNumero && tieneMayuscula)
                {
                    break;
                }
            }
            return tieneNumero && tieneMayuscula;
        }

        // decide si es debil,media o Fuerte
        private string EvaluarNivelSeguridad(string pass)
        {
            // Caso vacío
            if (string.IsNullOrEmpty(pass)) return "Débil";

            bool longitudOk = EsLongitudValida(pass);
            bool formatoOk = TieneNumeroYMayuscula(pass);

            if (longitudOk && formatoOk)
            {
                return "Fuerte";
            }
            // al menos una de las reglas es Media
            else if (longitudOk || formatoOk)
            {
                return "Media";
            }
            // ninguna es Debil
            else
            {
                return "Débil";
            }
        }


        private void lblEvaluacion_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string clave = txtPassword.Text;

            // fortaleza
            string nivel = EvaluarNivelSeguridad(clave);

            // Actualizamos texto y color correspondiente
            lblEvaluacion.Text = $"Nivel de seguridad: {nivel}";

            switch (nivel)
            {
                case "Fuerte":
                    lblEvaluacion.ForeColor = Color.Green;
                    break;
                case "Media":
                    lblEvaluacion.ForeColor = Color.Orange;
                    break;
                default: // "Debil"
                    lblEvaluacion.ForeColor = Color.Red;
                    break;
            }
        }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            // Si chkMostrarPass esta marcado (muestra el texto)
            txtPassword.UseSystemPasswordChar = !chkMostrarPass.Checked;
        }
    }
}
