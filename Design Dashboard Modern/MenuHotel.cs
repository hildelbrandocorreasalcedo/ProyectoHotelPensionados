using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Design_Dashboard_Modern
{
    public partial class MenuHotel : Form
    {
        public MenuHotel()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelSubPensionados.Visible = false;

            PanelConsultarGanancias.Visible = false;

        }
        private void HideSubMenu()
        {
            if (panelSubPensionados.Visible == true)
                panelSubPensionados.Visible = false;

            if (PanelConsultarGanancias.Visible == true)
                PanelConsultarGanancias.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelHijo.Controls.Add(childForm);
            PanelHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void PanelHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 260)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 260;
                SidebarWrapper.Width = 280;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void BTPensionados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubPensionados);
        }

        private void BtRegistrarPencionado_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistroPensionado());
            
        }

        private void BtConsultarPensionado_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsultaModPensionado());
        }

        private void BtReservas_Click(object sender, EventArgs e)
        {
            openChildForm(new Reserva());
        }

        private void BtIngrGast_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelConsultarGanancias);
        }

        private void BtConsultarGanancias_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsultarGanancias());
        }

        private void BtGestionarGanancias_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionGanancias());
        }

        private void BtHabitaciones_Click(object sender, EventArgs e)
        {
            openChildForm(new Habitacion());
        }

        private void BtServiciosAlimentarios_Click(object sender, EventArgs e)
        {
            openChildForm(new ServicioAlimenticio());
        }

        private void BtGenerarFactura_Click(object sender, EventArgs e)
        {
            openChildForm(new GenerarFactura());
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
