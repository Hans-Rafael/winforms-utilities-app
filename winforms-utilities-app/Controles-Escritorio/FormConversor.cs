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
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }
        private (decimal valorConvertido, string textoResultado) ConvertirTemperatura(decimal valor, bool esCelsToFahr)
        {
            decimal numeroResultado;
            string mensaje;
            if (esCelsToFahr)
            {
                //(ºC * 9/5)+ 32 = F
                numeroResultado = (valor * 9m / 5m) + 32m;
                mensaje = $"{valor:N2} °C equivalen a {numeroResultado:N2} °F";
            }
            else
            {
                // (°F − 32) × 5/9 = °C
                numeroResultado = (valor - 32m) * 5m / 9m;
                mensaje = $"{valor:N2} °F equivalen a {numeroResultado:N2} °C";
            }
            return (numeroResultado, mensaje);
        }
        
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            decimal valorIngresado = numValor.Value;
            bool esCelAFar = rbCelsToFahr.Checked;

            var respuesta= ConvertirTemperatura(valorIngresado, esCelAFar);

            lblResultado.Text = respuesta.textoResultado;
            decimal numero = respuesta.valorConvertido;// solo lo usare para db mas adelante seguramente

        }
    }
}
