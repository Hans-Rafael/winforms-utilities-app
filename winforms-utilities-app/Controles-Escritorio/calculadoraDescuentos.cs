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
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private decimal CalcularPorcentajeDescuento(string tipoCliente)
        {
            switch (tipoCliente)
            {
                case "Regular":
                    return 0.0m;
                case "Socio":
                    return 0.10m;
                case "VIP":
                    return 0.20m;
                default:
                    return 0.0m;
            }
        }

        private decimal CalcularRecargoMedioPago(bool esTarjeta, decimal monto)
        {
            if (esTarjeta)
            {
                return monto * 0.05m;
            }
            return 0;
        }

        private decimal ObtenerMontoFinal(decimal montoBase, decimal descuento, decimal recargo)
        {
            return montoBase - descuento + recargo;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numMonto.Value <= 0)
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el tipo de cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal montoBase = numMonto.Value;
            string tipoCliente = cmbTipoCliente.SelectedItem.ToString();
            bool esTarjeta = rbTarjeta.Checked;

            decimal porcentajeDescuento = CalcularPorcentajeDescuento(tipoCliente);
            decimal descuento = montoBase * porcentajeDescuento;
            decimal recargo = CalcularRecargoMedioPago(esTarjeta, montoBase);
            decimal montoFinal = ObtenerMontoFinal(montoBase, descuento, recargo);

            string resultado = $"Cliente: {txtCliente.Text}\n" +
                             $"Monto Base: ${montoBase:F2}\n" +
                             $"Tipo Cliente: {tipoCliente}\n" +
                             $"Descuento ({porcentajeDescuento * 100}%): -${descuento:F2}\n" +
                             $"Medio de Pago: {(esTarjeta ? "Tarjeta" : "Efectivo")}\n" +
                             $"Recargo: ${recargo:F2}\n" +
                             $"-----------------\n" +
                             $"TOTAL: ${montoFinal:F2}";

            lblResultado.Text = resultado;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
