﻿
namespace Design_Dashboard_Modern
{
    partial class RegistroPensionado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPensionado));
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CombCarrera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelColor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelColor.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(186, 99);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(252, 26);
            this.TxtIdentificacion.TabIndex = 0;
            this.TxtIdentificacion.TextChanged += new System.EventHandler(this.TxtIdentificacion_TextChanged);
            this.TxtIdentificacion.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.labNombre.Location = new System.Drawing.Point(68, 152);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(65, 20);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(186, 146);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(252, 26);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(186, 190);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(252, 26);
            this.TxtApellido.TabIndex = 5;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(186, 334);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(195, 26);
            this.TxtTelefono.TabIndex = 7;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(187, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "REGISTRAR PENSIONADO";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CombCarrera
            // 
            this.CombCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombCarrera.FormattingEnabled = true;
            this.CombCarrera.Items.AddRange(new object[] {
            "PSICOLOGIA ",
            "ENFERMERIA",
            "ADMINISTRACION DE EMPRESAS",
            "ADMINISTRACION DE EMPRESAS TURISTICAS Y HOTELERAS",
            "COMERCIO INTERNACIONAL",
            "CONTADURIA PUBLICA ",
            "ECONOMIA",
            "DERECHO",
            "PSICOLOGIA",
            "SOCIOLOGIA",
            "ENFERMERIA",
            "INSTRUMENTACION QUIRURGICA ",
            "MICROBIOLOGIA",
            "INGENIERIA AGROINDUSTRIAL ",
            "INGENIERIA AMBIENTAL Y SANITARIAS",
            "INGENIERIA SISTEMAS",
            "INGENIERIA ELECTRONICA",
            "LICENCIATURA EN MATEMATICAS",
            "LICENCIATURA ESPAÑOL E INGLES",
            "LICENCIATURA EN LITERATURA Y LENGUAS CASTELLANAS",
            "LICENCIATURA EN EDUCACION FISICA, RECREACION Y DEPORTES",
            "LICENCIATURA EN CIENCIAS NATURALES Y EDUCACION AMBIENTAL",
            "LICENCIATURA EN ARTE",
            "MUSICA"});
            this.CombCarrera.Location = new System.Drawing.Point(186, 283);
            this.CombCarrera.Name = "CombCarrera";
            this.CombCarrera.Size = new System.Drawing.Size(252, 28);
            this.CombCarrera.TabIndex = 15;
            this.CombCarrera.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(68, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(71, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(71, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Carrera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(71, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sexo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CmbSexo
            // 
            this.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.CmbSexo.Location = new System.Drawing.Point(186, 236);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(195, 28);
            this.CmbSexo.TabIndex = 23;
            this.CmbSexo.SelectedIndexChanged += new System.EventHandler(this.CmbSexo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelColor
            // 
            this.PanelColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelColor.BackgroundImage")));
            this.PanelColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelColor.Controls.Add(this.pictureBox1);
            this.PanelColor.GradientBottomLeft = System.Drawing.Color.Blue;
            this.PanelColor.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.PanelColor.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PanelColor.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelColor.Location = new System.Drawing.Point(468, 85);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Quality = 10;
            this.PanelColor.Size = new System.Drawing.Size(263, 237);
            this.PanelColor.TabIndex = 25;
            this.PanelColor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelColor_Paint);
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.Activecolor = System.Drawing.Color.Transparent;
            this.BtRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.BtRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtRegistrar.BorderRadius = 0;
            this.BtRegistrar.ButtonText = "    REGISTRAR";
            this.BtRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.BtRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtRegistrar.Iconimage")));
            this.BtRegistrar.Iconimage_right = null;
            this.BtRegistrar.Iconimage_right_Selected = null;
            this.BtRegistrar.Iconimage_Selected = null;
            this.BtRegistrar.IconMarginLeft = 8;
            this.BtRegistrar.IconMarginRight = 0;
            this.BtRegistrar.IconRightVisible = true;
            this.BtRegistrar.IconRightZoom = 0D;
            this.BtRegistrar.IconVisible = true;
            this.BtRegistrar.IconZoom = 80D;
            this.BtRegistrar.IsTab = false;
            this.BtRegistrar.Location = new System.Drawing.Point(6, 1);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtRegistrar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtRegistrar.selected = false;
            this.BtRegistrar.Size = new System.Drawing.Size(139, 44);
            this.BtRegistrar.TabIndex = 28;
            this.BtRegistrar.Text = "    REGISTRAR";
            this.BtRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRegistrar.Textcolor = System.Drawing.Color.White;
            this.BtRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click_2);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtRegistrar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(75, 409);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(151, 44);
            this.bunifuGradientPanel1.TabIndex = 26;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.BtModificar);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(435, 411);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(151, 44);
            this.bunifuGradientPanel3.TabIndex = 29;
            // 
            // BtModificar
            // 
            this.BtModificar.Activecolor = System.Drawing.Color.Transparent;
            this.BtModificar.BackColor = System.Drawing.Color.Transparent;
            this.BtModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtModificar.BorderRadius = 0;
            this.BtModificar.ButtonText = "    MODIFICAR";
            this.BtModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtModificar.DisabledColor = System.Drawing.Color.Gray;
            this.BtModificar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtModificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtModificar.Iconimage")));
            this.BtModificar.Iconimage_right = null;
            this.BtModificar.Iconimage_right_Selected = null;
            this.BtModificar.Iconimage_Selected = null;
            this.BtModificar.IconMarginLeft = 8;
            this.BtModificar.IconMarginRight = 0;
            this.BtModificar.IconRightVisible = true;
            this.BtModificar.IconRightZoom = 0D;
            this.BtModificar.IconVisible = true;
            this.BtModificar.IconZoom = 80D;
            this.BtModificar.IsTab = false;
            this.BtModificar.Location = new System.Drawing.Point(6, 1);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtModificar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtModificar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtModificar.selected = false;
            this.BtModificar.Size = new System.Drawing.Size(139, 44);
            this.BtModificar.TabIndex = 28;
            this.BtModificar.Text = "    MODIFICAR";
            this.BtModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtModificar.Textcolor = System.Drawing.Color.White;
            this.BtModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtModificar.Click += new System.EventHandler(this.BtModificar_Click);
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.BtCancelar);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(612, 411);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(155, 44);
            this.bunifuGradientPanel4.TabIndex = 29;
            this.bunifuGradientPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel4_Paint);
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelar.Location = new System.Drawing.Point(5, 0);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(145, 44);
            this.BtCancelar.TabIndex = 13;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.ButCancelar_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.BtEliminar);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(257, 410);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(151, 44);
            this.bunifuGradientPanel2.TabIndex = 29;
            // 
            // BtEliminar
            // 
            this.BtEliminar.Activecolor = System.Drawing.Color.Transparent;
            this.BtEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEliminar.BorderRadius = 0;
            this.BtEliminar.ButtonText = "    ELIMINAR";
            this.BtEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtEliminar.Iconimage")));
            this.BtEliminar.Iconimage_right = null;
            this.BtEliminar.Iconimage_right_Selected = null;
            this.BtEliminar.Iconimage_Selected = null;
            this.BtEliminar.IconMarginLeft = 8;
            this.BtEliminar.IconMarginRight = 0;
            this.BtEliminar.IconRightVisible = true;
            this.BtEliminar.IconRightZoom = 0D;
            this.BtEliminar.IconVisible = true;
            this.BtEliminar.IconZoom = 80D;
            this.BtEliminar.IsTab = false;
            this.BtEliminar.Location = new System.Drawing.Point(6, 1);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtEliminar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtEliminar.selected = false;
            this.BtEliminar.Size = new System.Drawing.Size(139, 44);
            this.BtEliminar.TabIndex = 28;
            this.BtEliminar.Text = "    ELIMINAR";
            this.BtEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEliminar.Textcolor = System.Drawing.Color.White;
            this.BtEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // RegistroPensionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.PanelColor);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CombCarrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Name = "RegistroPensionado";
            this.Text = "RegistroPensionado";
            this.Load += new System.EventHandler(this.RegistroPensionado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelColor.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox CombCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelColor;
        private Bunifu.Framework.UI.BunifuFlatButton BtRegistrar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuFlatButton BtModificar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtRegistrarPensionado;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtEliminar;
    }
}