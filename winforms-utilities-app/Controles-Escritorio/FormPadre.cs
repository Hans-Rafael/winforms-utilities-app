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
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }
        private void AbrirFormularioHijo(Form formHijo)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            formHijo.MdiParent = this;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.Show();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormCalculadora());
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormPassword());
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormConversor());
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {

        }
    }
}
