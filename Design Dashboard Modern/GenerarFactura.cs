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
    public partial class GenerarFactura : Form
    {
        public GenerarFactura()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtTelefonoGenFactura, "");
            int numero;
            if (!int.TryParse(TxtTelefonoGenFactura.Text, out numero))
            {
                errorProvider1.SetError(TxtTelefonoGenFactura, "Ingrese Solo Numeros");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtReservaGenFactura, "");
            int numero;
            if (!int.TryParse(TxtReservaGenFactura.Text, out numero))
            {
                errorProvider1.SetError(TxtReservaGenFactura, "Ingrese Solo Numeros");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtFacturaGenFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtFacturaGenFactura, "");
            int numero;
            if (!int.TryParse(TxtFacturaGenFactura.Text, out numero))
            {
                errorProvider1.SetError(TxtFacturaGenFactura, "Ingrese Solo Numeros");
            }
            
        }

        private void BtGenerarGenFactura_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                MessageBox.Show("Se Generó la Factura Correctamente");
            }
        }
            private bool validarcampos()
            {
                bool ok = true;
                if (TxtFacturaGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtFacturaGenFactura, "Por Favor Este Campo Es Obligatorio");
                }
                if (TxtNombreGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtNombreGenFactura, "Por Favor Ingrese los Nombres");
                }
                if (TxtIdenGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtIdenGenFactura, "Por Favor Ingrese La Identificación");
                }
                if (txtApellidosGenerarFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtApellidosGenerarFactura, "Por Favor Ingrese los Apellidos");
                }
                if (CmbCarreraGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(CmbCarreraGenFactura, "Por Favor Ingrese la Edad");
                }
                if (TxtSexoGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtSexoGenFactura, "Por Favor Este Campo Es Obligatorio");
                }
                if (TxtTelefonoGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtTelefonoGenFactura, "Por Favor Este Campo Es Obligatorio");
                }
                if (TxtCodGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtCodGenFactura, "Por Favor Este Campo Es Obligatorio");
                }
                if (dateTimePicker1.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(dateTimePicker1, "Por Favor Este Campo Es Obligatorio");
                }
                if (dateTimePicker2.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(dateTimePicker2, "Por Favor Este Campo Es Obligatorio");
                }
                if (TxtHabGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtHabGenFactura, "Por Favor Este Campo Es Obligatorio");
                }
                if (TxtReservaGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtReservaGenFactura, "Por Favor Este Campo Es Obligatorio");
                }
                if (TxtTotalGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtTotalGenFactura, "Por Favor Este Campo Es Obligatorio");
                }
                if (TxtCostoHabGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtCostoHabGenFactura, "Por Favor Este Campo Es Obligatorio");
                }
                if (TxtNumMesesGenFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtNumMesesGenFactura, "Por Favor Este Campo Es Obligatorio");
                }

                return ok;
            }
            private void BorrarMensajesError()
            {
            errorProvider1.SetError(TxtFacturaGenFactura, "");
            errorProvider1.SetError(TxtIdenGenFactura, "");
            errorProvider1.SetError(TxtNombreGenFactura, "");
            errorProvider1.SetError(txtApellidosGenerarFactura, "");
            errorProvider1.SetError(CmbCarreraGenFactura, "");
            errorProvider1.SetError(TxtSexoGenFactura, "");
            errorProvider1.SetError(TxtTelefonoGenFactura, "");
            errorProvider1.SetError(TxtCodGenFactura, "");
            errorProvider1.SetError(dateTimePicker1, "");
            errorProvider1.SetError(dateTimePicker2, "");
            errorProvider1.SetError(TxtHabGenFactura, "");
            errorProvider1.SetError(TxtReservaGenFactura, "");
            errorProvider1.SetError(TxtTotalGenFactura, "");
            errorProvider1.SetError(TxtCostoHabGenFactura, "");
            errorProvider1.SetError(TxtNumMesesGenFactura, "");

        }

        private void TxtCodGenFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtCodGenFactura, "");
            int numero;
            if (!int.TryParse(TxtCodGenFactura.Text, out numero))
            {
                errorProvider1.SetError(TxtCodGenFactura, "Ingrese Solo Numeros");
            }
        }

        private void TxtIdenGenFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtIdenGenFactura, "");
            int numero;
            if (!int.TryParse(TxtIdenGenFactura.Text, out numero))
            {
                errorProvider1.SetError(TxtIdenGenFactura, "Ingrese Solo Numeros");
            }
        }

        private void TxtEdadGenFactura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtHabGenFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtHabGenFactura, "");
        }

        private void txtApellidosGenerarFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtApellidosGenerarFactura, "");
        }

        private void TxtNombreGenFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtNombreGenFactura, "");
        }

        private void TxtSexoGenFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtSexoGenFactura, "");
        }

        private void BtLimpiarGenFactura_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                MessageBox.Show("Se Eliminó la Factura Correctamente");
            }
        }

        private void BtCancelarGenFactura_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CmbCarreraGenFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbCarreraGenFactura, "");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerarFactura_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtTotalGenFactura, "");
        }

        private void TxtCostoHabGenFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtCostoHabGenFactura, "");
            int numero;
            if (!int.TryParse(TxtCostoHabGenFactura.Text, out numero))
            {
                errorProvider1.SetError(TxtCostoHabGenFactura, "Ingrese Solo Numeros");
            }
        }

        private void TxtNumMesesGenFactura_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtNumMesesGenFactura, "");
            int numero;
            if (!int.TryParse(TxtNumMesesGenFactura.Text, out numero))
            {
                errorProvider1.SetError(TxtNumMesesGenFactura, "Ingrese Solo Numeros");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtIdenGenFactura, "");
            int numero;
            if (!int.TryParse(TxtIdentificacionAdmin.Text, out numero))
            {
                errorProvider1.SetError(TxtIdentificacionAdmin, "Ingrese Solo Numeros");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtNombreAdmini, "");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtDireccion, "");
        }
    }
}
