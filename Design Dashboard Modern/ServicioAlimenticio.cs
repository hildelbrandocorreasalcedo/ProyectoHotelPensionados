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
    public partial class ServicioAlimenticio : Form
    {
        public ServicioAlimenticio()
        {
            InitializeComponent();
        }



        private void ReservaForm_Load(object sender, EventArgs e)
        {

        }

        private void BtRegistrarServiAlimentario_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                MessageBox.Show("Se Registraron los datos Correctamente");
            }
        }

        private bool validarcampos()
        {
            bool ok = true;
            if (TxtIdentiServiAlimentario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtIdentiServiAlimentario, "Por Favor Ingrese La Identificación");
            }
            if (CombTipoServiAlimentario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CombTipoServiAlimentario, "Por Favor Ingrese La Identificación");
            }
            if (CombDetalleServiAlimentario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CombDetalleServiAlimentario, "Por Favor Ingrese La Identificación");
            }
            if (CombTipoServiAlimentario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CombTipoServiAlimentario, "Por Favor Ingrese La Identificación");
            }
            if (CombCostComidaServiAlimentario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CombCostComidaServiAlimentario, "Por Favor Ingrese La Identificación");
            }
            return ok;
        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(TxtIdentiServiAlimentario, "");
            errorProvider1.SetError(CombDetalleServiAlimentario, "");
            errorProvider1.SetError(CombCostComidaServiAlimentario, "");
            errorProvider1.SetError(CombTipoServiAlimentario, "");
        }

        private void BtEliminarServiAlimentario_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                MessageBox.Show("Se Eliminaron los datos Correctamente");
            }
        }

        private void BtCancelarServiAlimentario_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtIdentiServiAlimentario_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(TxtIdentiServiAlimentario.Text, out numero))
            {
                errorProvider1.SetError(TxtIdentiServiAlimentario, "Ingrese Solo Numeros");
            }
        }

        private void CombTipoServiAlimentario_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CombTipoServiAlimentario, "");
        }

        private void CombDetalleServiAlimentario_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CombDetalleServiAlimentario, "");
        }

        private void CombCostComidaServiAlimentario_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CombCostComidaServiAlimentario, "");
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtTotalComida, "");
            int numero;
            if (!int.TryParse(TxtTotalComida.Text, out numero))
            {
                errorProvider1.SetError(TxtTotalComida, "Ingrese Solo Numeros");
            }
        }

        private void TxtTotalComida_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCantiComida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

