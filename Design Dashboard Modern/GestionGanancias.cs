using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class GestionGanancias : Form
    {
        public GestionGanancias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IngresosGastosForm_Load(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LabIngresos_Click(object sender, EventArgs e)
        {

        }

        private void BtCalcularGastos_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                MessageBox.Show("Se Calcularon los datos Correctamente");
            }
        }

        private void BtLimpiarGanancias_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                MessageBox.Show("Se Limpiaron los datos Correctamente");
            }
        }

        private void TxtElectricidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtElectricidad, "");
            int numero;
            if (!int.TryParse(TxtElectricidad.Text, out numero))
            {
                errorProvider1.SetError(TxtElectricidad, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtElectricidad, "");
            }
        }

        private void TxtAgua_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtAgua, "");
            int numero;
            if (!int.TryParse(TxtAgua.Text, out numero))
            {
                errorProvider1.SetError(TxtAgua, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtAgua, "");
            }
        }

        private void TxtGas_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtGas, "");
            int numero;
            if (!int.TryParse(TxtGas.Text, out numero))
            {
                errorProvider1.SetError(TxtGas, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtGas, "");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(dateTimePicker2, "");
        }

        private bool validarcampos()
        {
            bool ok = true;
            if (TxtElectricidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtElectricidad, "Por Favor Ingrese los Nombres");
            }
            if (TxtAgua.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtAgua, "Por Favor Ingrese La Identificación");
            }
            if (TxtGas.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtGas, "Por Favor Ingrese Los Apellidos");
            }
            if (TxtAlimento.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtAlimento, "Este Campo Es Obligatorio");
            }
            if (TxtValorGastos.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtValorGastos, "Esta Selección Es Obligatoria");
            }
            if (TxtCantidadPensionado.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtCantidadPensionado, "Esta Selección Es Obligatoria");
            }
            if (TxtTotalIngresos.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtTotalIngresos, "Esta Selección Es Obligatoria");
            }
            return ok;
        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(TxtElectricidad, "");
            errorProvider1.SetError(TxtAgua, "");
            errorProvider1.SetError(TxtGas, "");
            errorProvider1.SetError(TxtAlimento, "");
            errorProvider1.SetError(TxtValorGastos, "");
            errorProvider1.SetError(TxtCantidadPensionado, "");
            errorProvider1.SetError(TxtTotalIngresos, "");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void TxtAlimento_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtAlimento, "");
            int numero;
            if (!int.TryParse(TxtAlimento.Text, out numero))
            {
                errorProvider1.SetError(TxtAlimento, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtAlimento, "");
            }
        }

        private void TxtValorGastos_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtValorGastos, "");
            int numero;
            if (!int.TryParse(TxtValorGastos.Text, out numero))
            {
                errorProvider1.SetError(TxtValorGastos, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtValorGastos, "");
            }
        }

        private void TxtCantidadPensionado_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtCantidadPensionado, "");
            int numero;
            if (!int.TryParse(TxtCantidadPensionado.Text, out numero))
            {
                errorProvider1.SetError(TxtCantidadPensionado, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtCantidadPensionado, "");
            }
        }

        private void TxtTotalIngresos_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtTotalIngresos, "");
            int numero;
            if (!int.TryParse(TxtTotalIngresos.Text, out numero))
            {
                errorProvider1.SetError(TxtTotalIngresos, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtTotalIngresos, "");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
