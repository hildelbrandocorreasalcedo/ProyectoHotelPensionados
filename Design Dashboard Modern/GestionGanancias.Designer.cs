
namespace Design_Dashboard_Modern
{
    partial class GestionGanancias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionGanancias));
            this.BtCalcularGastos = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.LabElectricidad = new System.Windows.Forms.Label();
            this.LabAlimento = new System.Windows.Forms.Label();
            this.LabGas = new System.Windows.Forms.Label();
            this.LabAgua = new System.Windows.Forms.Label();
            this.TxtElectricidad = new System.Windows.Forms.TextBox();
            this.TxtAgua = new System.Windows.Forms.TextBox();
            this.TxtGas = new System.Windows.Forms.TextBox();
            this.TxtAlimento = new System.Windows.Forms.TextBox();
            this.LabCostoAlquilerHab = new System.Windows.Forms.Label();
            this.LabCantidadAlquiler = new System.Windows.Forms.Label();
            this.LabCantidadPensionado = new System.Windows.Forms.Label();
            this.LabTotalIngresos = new System.Windows.Forms.Label();
            this.TxtTotalIngresos = new System.Windows.Forms.TextBox();
            this.LabValorTotalGastos = new System.Windows.Forms.Label();
            this.TxtValorGastos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtCantidadPensionado = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtLimpiarGanancias = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelColor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PanelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCalcularGastos
            // 
            this.BtCalcularGastos.Location = new System.Drawing.Point(54, 431);
            this.BtCalcularGastos.Name = "BtCalcularGastos";
            this.BtCalcularGastos.Size = new System.Drawing.Size(145, 51);
            this.BtCalcularGastos.TabIndex = 0;
            this.BtCalcularGastos.Text = "CALCULAR ";
            this.BtCalcularGastos.UseVisualStyleBackColor = true;
            this.BtCalcularGastos.Click += new System.EventHandler(this.BtCalcularGastos_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(382, 431);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(145, 51);
            this.BtCancelar.TabIndex = 3;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // LabElectricidad
            // 
            this.LabElectricidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabElectricidad.AutoSize = true;
            this.LabElectricidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabElectricidad.ForeColor = System.Drawing.Color.White;
            this.LabElectricidad.Location = new System.Drawing.Point(70, 162);
            this.LabElectricidad.Name = "LabElectricidad";
            this.LabElectricidad.Size = new System.Drawing.Size(183, 20);
            this.LabElectricidad.TabIndex = 4;
            this.LabElectricidad.Text = "Consumo de electricidad";
            // 
            // LabAlimento
            // 
            this.LabAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabAlimento.AutoSize = true;
            this.LabAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAlimento.ForeColor = System.Drawing.Color.White;
            this.LabAlimento.Location = new System.Drawing.Point(70, 318);
            this.LabAlimento.Name = "LabAlimento";
            this.LabAlimento.Size = new System.Drawing.Size(171, 20);
            this.LabAlimento.TabIndex = 6;
            this.LabAlimento.Text = "Consumo de alimentos";
            // 
            // LabGas
            // 
            this.LabGas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabGas.AutoSize = true;
            this.LabGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGas.ForeColor = System.Drawing.Color.White;
            this.LabGas.Location = new System.Drawing.Point(70, 263);
            this.LabGas.Name = "LabGas";
            this.LabGas.Size = new System.Drawing.Size(129, 20);
            this.LabGas.TabIndex = 7;
            this.LabGas.Text = "Consumo de gas";
            // 
            // LabAgua
            // 
            this.LabAgua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabAgua.AutoSize = true;
            this.LabAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAgua.ForeColor = System.Drawing.Color.White;
            this.LabAgua.Location = new System.Drawing.Point(70, 207);
            this.LabAgua.Name = "LabAgua";
            this.LabAgua.Size = new System.Drawing.Size(139, 20);
            this.LabAgua.TabIndex = 8;
            this.LabAgua.Text = "Consumo de agua";
            // 
            // TxtElectricidad
            // 
            this.TxtElectricidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtElectricidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtElectricidad.Location = new System.Drawing.Point(264, 159);
            this.TxtElectricidad.Name = "TxtElectricidad";
            this.TxtElectricidad.Size = new System.Drawing.Size(100, 26);
            this.TxtElectricidad.TabIndex = 9;
            this.TxtElectricidad.TextChanged += new System.EventHandler(this.TxtElectricidad_TextChanged);
            // 
            // TxtAgua
            // 
            this.TxtAgua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAgua.Location = new System.Drawing.Point(264, 207);
            this.TxtAgua.Name = "TxtAgua";
            this.TxtAgua.Size = new System.Drawing.Size(100, 26);
            this.TxtAgua.TabIndex = 10;
            this.TxtAgua.TextChanged += new System.EventHandler(this.TxtAgua_TextChanged);
            // 
            // TxtGas
            // 
            this.TxtGas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGas.Location = new System.Drawing.Point(264, 257);
            this.TxtGas.Name = "TxtGas";
            this.TxtGas.Size = new System.Drawing.Size(100, 26);
            this.TxtGas.TabIndex = 11;
            this.TxtGas.TextChanged += new System.EventHandler(this.TxtGas_TextChanged);
            // 
            // TxtAlimento
            // 
            this.TxtAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlimento.Location = new System.Drawing.Point(264, 312);
            this.TxtAlimento.Name = "TxtAlimento";
            this.TxtAlimento.Size = new System.Drawing.Size(100, 26);
            this.TxtAlimento.TabIndex = 12;
            this.TxtAlimento.TextChanged += new System.EventHandler(this.TxtAlimento_TextChanged);
            // 
            // LabCostoAlquilerHab
            // 
            this.LabCostoAlquilerHab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabCostoAlquilerHab.AutoSize = true;
            this.LabCostoAlquilerHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCostoAlquilerHab.ForeColor = System.Drawing.Color.White;
            this.LabCostoAlquilerHab.Location = new System.Drawing.Point(441, 159);
            this.LabCostoAlquilerHab.Name = "LabCostoAlquilerHab";
            this.LabCostoAlquilerHab.Size = new System.Drawing.Size(206, 20);
            this.LabCostoAlquilerHab.TabIndex = 13;
            this.LabCostoAlquilerHab.Text = "Precio alquiler de habitación";
            // 
            // LabCantidadAlquiler
            // 
            this.LabCantidadAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabCantidadAlquiler.AutoSize = true;
            this.LabCantidadAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCantidadAlquiler.ForeColor = System.Drawing.Color.White;
            this.LabCantidadAlquiler.Location = new System.Drawing.Point(643, 160);
            this.LabCantidadAlquiler.Name = "LabCantidadAlquiler";
            this.LabCantidadAlquiler.Size = new System.Drawing.Size(76, 20);
            this.LabCantidadAlquiler.TabIndex = 14;
            this.LabCantidadAlquiler.Text = "$400.000";
            // 
            // LabCantidadPensionado
            // 
            this.LabCantidadPensionado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabCantidadPensionado.AutoSize = true;
            this.LabCantidadPensionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCantidadPensionado.ForeColor = System.Drawing.Color.White;
            this.LabCantidadPensionado.Location = new System.Drawing.Point(441, 207);
            this.LabCantidadPensionado.Name = "LabCantidadPensionado";
            this.LabCantidadPensionado.Size = new System.Drawing.Size(176, 20);
            this.LabCantidadPensionado.TabIndex = 15;
            this.LabCantidadPensionado.Text = "Habitaciones ocupadas";
            // 
            // LabTotalIngresos
            // 
            this.LabTotalIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabTotalIngresos.AutoSize = true;
            this.LabTotalIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalIngresos.ForeColor = System.Drawing.Color.White;
            this.LabTotalIngresos.Location = new System.Drawing.Point(441, 263);
            this.LabTotalIngresos.Name = "LabTotalIngresos";
            this.LabTotalIngresos.Size = new System.Drawing.Size(167, 20);
            this.LabTotalIngresos.TabIndex = 17;
            this.LabTotalIngresos.Text = "Valor total de ingresos";
            // 
            // TxtTotalIngresos
            // 
            this.TxtTotalIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalIngresos.Location = new System.Drawing.Point(641, 257);
            this.TxtTotalIngresos.Name = "TxtTotalIngresos";
            this.TxtTotalIngresos.Size = new System.Drawing.Size(100, 26);
            this.TxtTotalIngresos.TabIndex = 18;
            this.TxtTotalIngresos.TextChanged += new System.EventHandler(this.TxtTotalIngresos_TextChanged);
            // 
            // LabValorTotalGastos
            // 
            this.LabValorTotalGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabValorTotalGastos.AutoSize = true;
            this.LabValorTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabValorTotalGastos.ForeColor = System.Drawing.Color.White;
            this.LabValorTotalGastos.Location = new System.Drawing.Point(70, 371);
            this.LabValorTotalGastos.Name = "LabValorTotalGastos";
            this.LabValorTotalGastos.Size = new System.Drawing.Size(155, 20);
            this.LabValorTotalGastos.TabIndex = 19;
            this.LabValorTotalGastos.Text = "Valor total de gastos";
            // 
            // TxtValorGastos
            // 
            this.TxtValorGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValorGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorGastos.Location = new System.Drawing.Point(264, 365);
            this.TxtValorGastos.Name = "TxtValorGastos";
            this.TxtValorGastos.Size = new System.Drawing.Size(100, 26);
            this.TxtValorGastos.TabIndex = 20;
            this.TxtValorGastos.TextChanged += new System.EventHandler(this.TxtValorGastos_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha de alquiler";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtCantidadPensionado
            // 
            this.TxtCantidadPensionado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCantidadPensionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadPensionado.Location = new System.Drawing.Point(641, 204);
            this.TxtCantidadPensionado.Name = "TxtCantidadPensionado";
            this.TxtCantidadPensionado.Size = new System.Drawing.Size(50, 26);
            this.TxtCantidadPensionado.TabIndex = 16;
            this.TxtCantidadPensionado.TextChanged += new System.EventHandler(this.TxtCantidadPensionado_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(206, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker2.TabIndex = 30;
            this.dateTimePicker2.Value = new System.DateTime(2021, 4, 29, 6, 46, 2, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // BtLimpiarGanancias
            // 
            this.BtLimpiarGanancias.Location = new System.Drawing.Point(219, 431);
            this.BtLimpiarGanancias.Name = "BtLimpiarGanancias";
            this.BtLimpiarGanancias.Size = new System.Drawing.Size(145, 51);
            this.BtLimpiarGanancias.TabIndex = 25;
            this.BtLimpiarGanancias.Text = "LIMPIAR";
            this.BtLimpiarGanancias.UseVisualStyleBackColor = true;
            this.BtLimpiarGanancias.Click += new System.EventHandler(this.BtLimpiarGanancias_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 44);
            this.label3.TabIndex = 31;
            this.label3.Text = "GESTION DE GANANCIAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(158, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "GASTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(496, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "INGRESOS";
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
            this.PanelColor.Location = new System.Drawing.Point(559, 304);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Quality = 10;
            this.PanelColor.Size = new System.Drawing.Size(208, 178);
            this.PanelColor.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // GestionGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.PanelColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.BtLimpiarGanancias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtValorGastos);
            this.Controls.Add(this.LabValorTotalGastos);
            this.Controls.Add(this.TxtTotalIngresos);
            this.Controls.Add(this.LabTotalIngresos);
            this.Controls.Add(this.TxtCantidadPensionado);
            this.Controls.Add(this.LabCantidadPensionado);
            this.Controls.Add(this.LabCantidadAlquiler);
            this.Controls.Add(this.LabCostoAlquilerHab);
            this.Controls.Add(this.TxtAlimento);
            this.Controls.Add(this.TxtGas);
            this.Controls.Add(this.TxtAgua);
            this.Controls.Add(this.TxtElectricidad);
            this.Controls.Add(this.LabAgua);
            this.Controls.Add(this.LabGas);
            this.Controls.Add(this.LabAlimento);
            this.Controls.Add(this.LabElectricidad);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtCalcularGastos);
            this.Name = "GestionGanancias";
            this.Text = "GestionGanancias";
            this.Load += new System.EventHandler(this.IngresosGastosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PanelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCalcularGastos;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label LabElectricidad;
        private System.Windows.Forms.Label LabAlimento;
        private System.Windows.Forms.Label LabGas;
        private System.Windows.Forms.Label LabAgua;
        private System.Windows.Forms.TextBox TxtElectricidad;
        private System.Windows.Forms.TextBox TxtAgua;
        private System.Windows.Forms.TextBox TxtGas;
        private System.Windows.Forms.TextBox TxtAlimento;
        private System.Windows.Forms.Label LabCostoAlquilerHab;
        private System.Windows.Forms.Label LabCantidadAlquiler;
        private System.Windows.Forms.Label LabCantidadPensionado;
        private System.Windows.Forms.Label LabTotalIngresos;
        private System.Windows.Forms.TextBox TxtTotalIngresos;
        private System.Windows.Forms.Label LabValorTotalGastos;
        private System.Windows.Forms.TextBox TxtValorGastos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TxtCantidadPensionado;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BtLimpiarGanancias;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}