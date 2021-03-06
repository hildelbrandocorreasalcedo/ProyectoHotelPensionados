
namespace Design_Dashboard_Modern
{
    partial class MenuHotel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHotel));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.PanelHijo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.BtGenerarFactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtServiciosAlimentarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtHabitaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelConsultarGanancias = new System.Windows.Forms.Panel();
            this.BtConsultarGanancias = new System.Windows.Forms.Button();
            this.BtGestionarGanancias = new System.Windows.Forms.Button();
            this.BtIngrGast = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtReservas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubPensionados = new System.Windows.Forms.Panel();
            this.BtConsultarPensionado = new System.Windows.Forms.Button();
            this.BtRegistrarPencionado = new System.Windows.Forms.Button();
            this.BTPensionados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.PanelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.PanelSideMenu.SuspendLayout();
            this.PanelConsultarGanancias.SuspendLayout();
            this.panelSubPensionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.AnimacionSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.MenuSidebar);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.Salir);
            this.bunifuGradientPanel1.Controls.Add(this.Maximizar);
            this.bunifuGradientPanel1.Controls.Add(this.Restaurar);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.Minimizar);
            this.AnimacionSidebar.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1131, 75);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(571, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(19, 14);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(50, 44);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 24;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(176, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "FOUNDERS APARTAMENT ";
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1089, 21);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1053, 21);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1053, 21);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1017, 21);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // PanelHijo
            // 
            this.PanelHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelHijo.Controls.Add(this.pictureBox3);
            this.AnimacionSidebar.SetDecoration(this.PanelHijo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PanelHijo, BunifuAnimatorNS.DecorationType.None);
            this.PanelHijo.Location = new System.Drawing.Point(6, 11);
            this.PanelHijo.Name = "PanelHijo";
            this.PanelHijo.Size = new System.Drawing.Size(833, 553);
            this.PanelHijo.TabIndex = 4;
            this.PanelHijo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHijo_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(285, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(288, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.label3);
            this.Sidebar.Controls.Add(this.PanelSideMenu);
            this.Sidebar.Controls.Add(this.BTPensionados);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label4);
            this.Sidebar.Controls.Add(this.pictureBox4);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.Blue;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(11, 11);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(260, 553);
            this.Sidebar.TabIndex = 19;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "APARTAMENT ";
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.AutoScroll = true;
            this.PanelSideMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelSideMenu.Controls.Add(this.BtGenerarFactura);
            this.PanelSideMenu.Controls.Add(this.BtServiciosAlimentarios);
            this.PanelSideMenu.Controls.Add(this.BtHabitaciones);
            this.PanelSideMenu.Controls.Add(this.PanelConsultarGanancias);
            this.PanelSideMenu.Controls.Add(this.BtIngrGast);
            this.PanelSideMenu.Controls.Add(this.BtReservas);
            this.PanelSideMenu.Controls.Add(this.panelSubPensionados);
            this.AnimacionSidebar.SetDecoration(this.PanelSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PanelSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelSideMenu.Location = new System.Drawing.Point(7, 130);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(245, 418);
            this.PanelSideMenu.TabIndex = 2;
            // 
            // BtGenerarFactura
            // 
            this.BtGenerarFactura.Activecolor = System.Drawing.Color.Transparent;
            this.BtGenerarFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtGenerarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtGenerarFactura.BorderRadius = 0;
            this.BtGenerarFactura.ButtonText = "          GENERAR FACTURA";
            this.BtGenerarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtGenerarFactura, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtGenerarFactura, BunifuAnimatorNS.DecorationType.None);
            this.BtGenerarFactura.DisabledColor = System.Drawing.Color.Gray;
            this.BtGenerarFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtGenerarFactura.Iconcolor = System.Drawing.Color.Transparent;
            this.BtGenerarFactura.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtGenerarFactura.Iconimage")));
            this.BtGenerarFactura.Iconimage_right = null;
            this.BtGenerarFactura.Iconimage_right_Selected = null;
            this.BtGenerarFactura.Iconimage_Selected = null;
            this.BtGenerarFactura.IconMarginLeft = 13;
            this.BtGenerarFactura.IconMarginRight = 0;
            this.BtGenerarFactura.IconRightVisible = true;
            this.BtGenerarFactura.IconRightZoom = 0D;
            this.BtGenerarFactura.IconVisible = true;
            this.BtGenerarFactura.IconZoom = 60D;
            this.BtGenerarFactura.IsTab = false;
            this.BtGenerarFactura.Location = new System.Drawing.Point(0, 370);
            this.BtGenerarFactura.Margin = new System.Windows.Forms.Padding(6);
            this.BtGenerarFactura.Name = "BtGenerarFactura";
            this.BtGenerarFactura.Normalcolor = System.Drawing.Color.Transparent;
            this.BtGenerarFactura.OnHovercolor = System.Drawing.Color.Blue;
            this.BtGenerarFactura.OnHoverTextColor = System.Drawing.Color.White;
            this.BtGenerarFactura.selected = false;
            this.BtGenerarFactura.Size = new System.Drawing.Size(245, 46);
            this.BtGenerarFactura.TabIndex = 22;
            this.BtGenerarFactura.Text = "          GENERAR FACTURA";
            this.BtGenerarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtGenerarFactura.Textcolor = System.Drawing.Color.LightGray;
            this.BtGenerarFactura.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtGenerarFactura.Click += new System.EventHandler(this.BtGenerarFactura_Click);
            // 
            // BtServiciosAlimentarios
            // 
            this.BtServiciosAlimentarios.Activecolor = System.Drawing.Color.Transparent;
            this.BtServiciosAlimentarios.BackColor = System.Drawing.Color.Transparent;
            this.BtServiciosAlimentarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtServiciosAlimentarios.BorderRadius = 0;
            this.BtServiciosAlimentarios.ButtonText = "       SERVICIOS ALIMENTARIOS";
            this.BtServiciosAlimentarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtServiciosAlimentarios, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtServiciosAlimentarios, BunifuAnimatorNS.DecorationType.None);
            this.BtServiciosAlimentarios.DisabledColor = System.Drawing.Color.Gray;
            this.BtServiciosAlimentarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtServiciosAlimentarios.Iconcolor = System.Drawing.Color.Transparent;
            this.BtServiciosAlimentarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtServiciosAlimentarios.Iconimage")));
            this.BtServiciosAlimentarios.Iconimage_right = null;
            this.BtServiciosAlimentarios.Iconimage_right_Selected = null;
            this.BtServiciosAlimentarios.Iconimage_Selected = null;
            this.BtServiciosAlimentarios.IconMarginLeft = 4;
            this.BtServiciosAlimentarios.IconMarginRight = 0;
            this.BtServiciosAlimentarios.IconRightVisible = true;
            this.BtServiciosAlimentarios.IconRightZoom = 0D;
            this.BtServiciosAlimentarios.IconVisible = true;
            this.BtServiciosAlimentarios.IconZoom = 100D;
            this.BtServiciosAlimentarios.IsTab = false;
            this.BtServiciosAlimentarios.Location = new System.Drawing.Point(0, 326);
            this.BtServiciosAlimentarios.Name = "BtServiciosAlimentarios";
            this.BtServiciosAlimentarios.Normalcolor = System.Drawing.Color.Transparent;
            this.BtServiciosAlimentarios.OnHovercolor = System.Drawing.Color.Blue;
            this.BtServiciosAlimentarios.OnHoverTextColor = System.Drawing.Color.White;
            this.BtServiciosAlimentarios.selected = false;
            this.BtServiciosAlimentarios.Size = new System.Drawing.Size(245, 44);
            this.BtServiciosAlimentarios.TabIndex = 23;
            this.BtServiciosAlimentarios.Text = "       SERVICIOS ALIMENTARIOS";
            this.BtServiciosAlimentarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtServiciosAlimentarios.Textcolor = System.Drawing.Color.LightGray;
            this.BtServiciosAlimentarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtServiciosAlimentarios.Click += new System.EventHandler(this.BtServiciosAlimentarios_Click);
            // 
            // BtHabitaciones
            // 
            this.BtHabitaciones.Activecolor = System.Drawing.Color.Transparent;
            this.BtHabitaciones.BackColor = System.Drawing.Color.Transparent;
            this.BtHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtHabitaciones.BorderRadius = 0;
            this.BtHabitaciones.ButtonText = "          HABITACIONES";
            this.BtHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtHabitaciones, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtHabitaciones, BunifuAnimatorNS.DecorationType.None);
            this.BtHabitaciones.DisabledColor = System.Drawing.Color.Gray;
            this.BtHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHabitaciones.ForeColor = System.Drawing.Color.Navy;
            this.BtHabitaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.BtHabitaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtHabitaciones.Iconimage")));
            this.BtHabitaciones.Iconimage_right = null;
            this.BtHabitaciones.Iconimage_right_Selected = null;
            this.BtHabitaciones.Iconimage_Selected = null;
            this.BtHabitaciones.IconMarginLeft = 14;
            this.BtHabitaciones.IconMarginRight = 0;
            this.BtHabitaciones.IconRightVisible = true;
            this.BtHabitaciones.IconRightZoom = 0D;
            this.BtHabitaciones.IconVisible = true;
            this.BtHabitaciones.IconZoom = 60D;
            this.BtHabitaciones.IsTab = false;
            this.BtHabitaciones.Location = new System.Drawing.Point(0, 280);
            this.BtHabitaciones.Name = "BtHabitaciones";
            this.BtHabitaciones.Normalcolor = System.Drawing.Color.Transparent;
            this.BtHabitaciones.OnHovercolor = System.Drawing.Color.Blue;
            this.BtHabitaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.BtHabitaciones.selected = false;
            this.BtHabitaciones.Size = new System.Drawing.Size(245, 46);
            this.BtHabitaciones.TabIndex = 21;
            this.BtHabitaciones.Text = "          HABITACIONES";
            this.BtHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtHabitaciones.Textcolor = System.Drawing.Color.LightGray;
            this.BtHabitaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtHabitaciones.Click += new System.EventHandler(this.BtHabitaciones_Click);
            // 
            // PanelConsultarGanancias
            // 
            this.PanelConsultarGanancias.BackColor = System.Drawing.Color.Transparent;
            this.PanelConsultarGanancias.Controls.Add(this.BtConsultarGanancias);
            this.PanelConsultarGanancias.Controls.Add(this.BtGestionarGanancias);
            this.AnimacionSidebar.SetDecoration(this.PanelConsultarGanancias, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PanelConsultarGanancias, BunifuAnimatorNS.DecorationType.None);
            this.PanelConsultarGanancias.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelConsultarGanancias.Location = new System.Drawing.Point(0, 180);
            this.PanelConsultarGanancias.Name = "PanelConsultarGanancias";
            this.PanelConsultarGanancias.Size = new System.Drawing.Size(245, 100);
            this.PanelConsultarGanancias.TabIndex = 15;
            // 
            // BtConsultarGanancias
            // 
            this.BtConsultarGanancias.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.BtConsultarGanancias, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtConsultarGanancias, BunifuAnimatorNS.DecorationType.None);
            this.BtConsultarGanancias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtConsultarGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConsultarGanancias.ForeColor = System.Drawing.SystemColors.Control;
            this.BtConsultarGanancias.Image = ((System.Drawing.Image)(resources.GetObject("BtConsultarGanancias.Image")));
            this.BtConsultarGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultarGanancias.Location = new System.Drawing.Point(0, 45);
            this.BtConsultarGanancias.Name = "BtConsultarGanancias";
            this.BtConsultarGanancias.Size = new System.Drawing.Size(245, 46);
            this.BtConsultarGanancias.TabIndex = 16;
            this.BtConsultarGanancias.Text = "              CONSULTAR GANANCIAS";
            this.BtConsultarGanancias.UseVisualStyleBackColor = false;
            this.BtConsultarGanancias.Click += new System.EventHandler(this.BtConsultarGanancias_Click);
            // 
            // BtGestionarGanancias
            // 
            this.BtGestionarGanancias.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.BtGestionarGanancias, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtGestionarGanancias, BunifuAnimatorNS.DecorationType.None);
            this.BtGestionarGanancias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtGestionarGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGestionarGanancias.ForeColor = System.Drawing.SystemColors.Control;
            this.BtGestionarGanancias.Image = ((System.Drawing.Image)(resources.GetObject("BtGestionarGanancias.Image")));
            this.BtGestionarGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtGestionarGanancias.Location = new System.Drawing.Point(0, 0);
            this.BtGestionarGanancias.Name = "BtGestionarGanancias";
            this.BtGestionarGanancias.Size = new System.Drawing.Size(245, 45);
            this.BtGestionarGanancias.TabIndex = 15;
            this.BtGestionarGanancias.Text = "             GESTION DE GANANCIAS";
            this.BtGestionarGanancias.UseVisualStyleBackColor = false;
            this.BtGestionarGanancias.Click += new System.EventHandler(this.BtGestionarGanancias_Click);
            // 
            // BtIngrGast
            // 
            this.BtIngrGast.Activecolor = System.Drawing.Color.Transparent;
            this.BtIngrGast.BackColor = System.Drawing.Color.Transparent;
            this.BtIngrGast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIngrGast.BorderRadius = 0;
            this.BtIngrGast.ButtonText = "      INGRESOS Y GASTOS";
            this.BtIngrGast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtIngrGast, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtIngrGast, BunifuAnimatorNS.DecorationType.None);
            this.BtIngrGast.DisabledColor = System.Drawing.Color.Gray;
            this.BtIngrGast.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtIngrGast.Iconcolor = System.Drawing.Color.Transparent;
            this.BtIngrGast.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtIngrGast.Iconimage")));
            this.BtIngrGast.Iconimage_right = null;
            this.BtIngrGast.Iconimage_right_Selected = null;
            this.BtIngrGast.Iconimage_Selected = null;
            this.BtIngrGast.IconMarginLeft = 2;
            this.BtIngrGast.IconMarginRight = 0;
            this.BtIngrGast.IconRightVisible = true;
            this.BtIngrGast.IconRightZoom = 0D;
            this.BtIngrGast.IconVisible = true;
            this.BtIngrGast.IconZoom = 105D;
            this.BtIngrGast.IsTab = false;
            this.BtIngrGast.Location = new System.Drawing.Point(0, 134);
            this.BtIngrGast.Margin = new System.Windows.Forms.Padding(5);
            this.BtIngrGast.Name = "BtIngrGast";
            this.BtIngrGast.Normalcolor = System.Drawing.Color.Transparent;
            this.BtIngrGast.OnHovercolor = System.Drawing.Color.Blue;
            this.BtIngrGast.OnHoverTextColor = System.Drawing.Color.White;
            this.BtIngrGast.selected = false;
            this.BtIngrGast.Size = new System.Drawing.Size(245, 46);
            this.BtIngrGast.TabIndex = 19;
            this.BtIngrGast.Text = "      INGRESOS Y GASTOS";
            this.BtIngrGast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtIngrGast.Textcolor = System.Drawing.Color.LightGray;
            this.BtIngrGast.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtIngrGast.Click += new System.EventHandler(this.BtIngrGast_Click);
            // 
            // BtReservas
            // 
            this.BtReservas.Activecolor = System.Drawing.Color.Transparent;
            this.BtReservas.BackColor = System.Drawing.Color.Transparent;
            this.BtReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtReservas.BorderRadius = 0;
            this.BtReservas.ButtonText = "         RESERVAS";
            this.BtReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtReservas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtReservas, BunifuAnimatorNS.DecorationType.None);
            this.BtReservas.DisabledColor = System.Drawing.Color.Gray;
            this.BtReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReservas.Iconcolor = System.Drawing.Color.Transparent;
            this.BtReservas.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtReservas.Iconimage")));
            this.BtReservas.Iconimage_right = null;
            this.BtReservas.Iconimage_right_Selected = null;
            this.BtReservas.Iconimage_Selected = null;
            this.BtReservas.IconMarginLeft = 14;
            this.BtReservas.IconMarginRight = 0;
            this.BtReservas.IconRightVisible = true;
            this.BtReservas.IconRightZoom = 0D;
            this.BtReservas.IconVisible = true;
            this.BtReservas.IconZoom = 40D;
            this.BtReservas.IsTab = false;
            this.BtReservas.Location = new System.Drawing.Point(0, 88);
            this.BtReservas.Margin = new System.Windows.Forms.Padding(4);
            this.BtReservas.Name = "BtReservas";
            this.BtReservas.Normalcolor = System.Drawing.Color.Transparent;
            this.BtReservas.OnHovercolor = System.Drawing.Color.Blue;
            this.BtReservas.OnHoverTextColor = System.Drawing.Color.White;
            this.BtReservas.selected = false;
            this.BtReservas.Size = new System.Drawing.Size(245, 46);
            this.BtReservas.TabIndex = 18;
            this.BtReservas.Text = "         RESERVAS";
            this.BtReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtReservas.Textcolor = System.Drawing.Color.LightGray;
            this.BtReservas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtReservas.Click += new System.EventHandler(this.BtReservas_Click);
            // 
            // panelSubPensionados
            // 
            this.panelSubPensionados.Controls.Add(this.BtConsultarPensionado);
            this.panelSubPensionados.Controls.Add(this.BtRegistrarPencionado);
            this.AnimacionSidebar.SetDecoration(this.panelSubPensionados, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panelSubPensionados, BunifuAnimatorNS.DecorationType.None);
            this.panelSubPensionados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubPensionados.Location = new System.Drawing.Point(0, 0);
            this.panelSubPensionados.Name = "panelSubPensionados";
            this.panelSubPensionados.Size = new System.Drawing.Size(245, 88);
            this.panelSubPensionados.TabIndex = 2;
            // 
            // BtConsultarPensionado
            // 
            this.BtConsultarPensionado.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.BtConsultarPensionado, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtConsultarPensionado, BunifuAnimatorNS.DecorationType.None);
            this.BtConsultarPensionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtConsultarPensionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConsultarPensionado.ForeColor = System.Drawing.SystemColors.Control;
            this.BtConsultarPensionado.Image = ((System.Drawing.Image)(resources.GetObject("BtConsultarPensionado.Image")));
            this.BtConsultarPensionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultarPensionado.Location = new System.Drawing.Point(0, 43);
            this.BtConsultarPensionado.Name = "BtConsultarPensionado";
            this.BtConsultarPensionado.Size = new System.Drawing.Size(245, 42);
            this.BtConsultarPensionado.TabIndex = 3;
            this.BtConsultarPensionado.Text = "                  CONSULTAR PENCIONADOS";
            this.BtConsultarPensionado.UseVisualStyleBackColor = false;
            this.BtConsultarPensionado.Click += new System.EventHandler(this.BtConsultarPensionado_Click);
            // 
            // BtRegistrarPencionado
            // 
            this.AnimacionSidebarBack.SetDecoration(this.BtRegistrarPencionado, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtRegistrarPencionado, BunifuAnimatorNS.DecorationType.None);
            this.BtRegistrarPencionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtRegistrarPencionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRegistrarPencionado.ForeColor = System.Drawing.SystemColors.Control;
            this.BtRegistrarPencionado.Image = ((System.Drawing.Image)(resources.GetObject("BtRegistrarPencionado.Image")));
            this.BtRegistrarPencionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRegistrarPencionado.Location = new System.Drawing.Point(0, 0);
            this.BtRegistrarPencionado.Name = "BtRegistrarPencionado";
            this.BtRegistrarPencionado.Size = new System.Drawing.Size(245, 43);
            this.BtRegistrarPencionado.TabIndex = 2;
            this.BtRegistrarPencionado.Text = "             REGISTRAR PENSIONADO";
            this.BtRegistrarPencionado.UseVisualStyleBackColor = true;
            this.BtRegistrarPencionado.Click += new System.EventHandler(this.BtRegistrarPencionado_Click);
            // 
            // BTPensionados
            // 
            this.BTPensionados.Activecolor = System.Drawing.Color.Transparent;
            this.BTPensionados.BackColor = System.Drawing.Color.Transparent;
            this.BTPensionados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTPensionados.BorderRadius = 0;
            this.BTPensionados.ButtonText = "        PENSIONADOS";
            this.BTPensionados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BTPensionados, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BTPensionados, BunifuAnimatorNS.DecorationType.None);
            this.BTPensionados.DisabledColor = System.Drawing.Color.Gray;
            this.BTPensionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPensionados.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BTPensionados.Iconcolor = System.Drawing.Color.Transparent;
            this.BTPensionados.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTPensionados.Iconimage")));
            this.BTPensionados.Iconimage_right = null;
            this.BTPensionados.Iconimage_right_Selected = null;
            this.BTPensionados.Iconimage_Selected = null;
            this.BTPensionados.IconMarginLeft = 16;
            this.BTPensionados.IconMarginRight = 0;
            this.BTPensionados.IconRightVisible = true;
            this.BTPensionados.IconRightZoom = 0D;
            this.BTPensionados.IconVisible = true;
            this.BTPensionados.IconZoom = 60D;
            this.BTPensionados.IsTab = false;
            this.BTPensionados.Location = new System.Drawing.Point(8, 82);
            this.BTPensionados.Name = "BTPensionados";
            this.BTPensionados.Normalcolor = System.Drawing.Color.Transparent;
            this.BTPensionados.OnHovercolor = System.Drawing.Color.Blue;
            this.BTPensionados.OnHoverTextColor = System.Drawing.Color.White;
            this.BTPensionados.selected = false;
            this.BTPensionados.Size = new System.Drawing.Size(244, 46);
            this.BTPensionados.TabIndex = 20;
            this.BTPensionados.Text = "        PENSIONADOS";
            this.BTPensionados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTPensionados.Textcolor = System.Drawing.Color.LightGray;
            this.BTPensionados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BTPensionados.Click += new System.EventHandler(this.BTPensionados_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(235, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "FOUNDERS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 75);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(280, 576);
            this.SidebarWrapper.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.PanelHijo);
            this.AnimacionSidebar.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 576);
            this.panel3.TabIndex = 21;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.bunifuGradientPanel1;
            this.MoverDashboard.Vertical = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation1;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation2;
            // 
            // MenuHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.panel1);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuHotel";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.PanelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.PanelSideMenu.ResumeLayout(false);
            this.PanelConsultarGanancias.ResumeLayout(false);
            this.panelSubPensionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelHijo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Minimizar;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelSideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton BtGenerarFactura;
        private Bunifu.Framework.UI.BunifuFlatButton BtServiciosAlimentarios;
        private Bunifu.Framework.UI.BunifuFlatButton BtHabitaciones;
        private System.Windows.Forms.Panel PanelConsultarGanancias;
        private System.Windows.Forms.Button BtConsultarGanancias;
        private System.Windows.Forms.Button BtGestionarGanancias;
        private Bunifu.Framework.UI.BunifuFlatButton BtIngrGast;
        private Bunifu.Framework.UI.BunifuFlatButton BtReservas;
        private System.Windows.Forms.Panel panelSubPensionados;
        private System.Windows.Forms.Button BtConsultarPensionado;
        private System.Windows.Forms.Button BtRegistrarPencionado;
        private Bunifu.Framework.UI.BunifuFlatButton BTPensionados;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}