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
    public partial class Habitacion : Form
    {
        public Habitacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroPensionado registroPensionado = new RegistroPensionado();
            registroPensionado.Show();
        }

        private void PensionadoConsultaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
