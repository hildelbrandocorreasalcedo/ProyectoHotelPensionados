
namespace Design_Dashboard_Modern
{
    partial class ServicioAlimenticio
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
            this.CombTipoServiAlimentario = new System.Windows.Forms.ComboBox();
            this.CombDetalleServiAlimentario = new System.Windows.Forms.ComboBox();
            this.TxtIdentiServiAlimentario = new System.Windows.Forms.TextBox();
            this.BtRegistrarServiAlimentario = new System.Windows.Forms.Button();
            this.BtEliminarServiAlimentario = new System.Windows.Forms.Button();
            this.BtCancelarServiAlimentario = new System.Windows.Forms.Button();
            this.CombCostComidaServiAlimentario = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantidadComida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotalComida = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CombTipoServiAlimentario
            // 
            this.CombTipoServiAlimentario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombTipoServiAlimentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombTipoServiAlimentario.FormattingEnabled = true;
            this.CombTipoServiAlimentario.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Cena"});
            this.CombTipoServiAlimentario.Location = new System.Drawing.Point(278, 115);
            this.CombTipoServiAlimentario.Name = "CombTipoServiAlimentario";
            this.CombTipoServiAlimentario.Size = new System.Drawing.Size(182, 28);
            this.CombTipoServiAlimentario.TabIndex = 21;
            this.CombTipoServiAlimentario.SelectedIndexChanged += new System.EventHandler(this.CombTipoServiAlimentario_SelectedIndexChanged);
            // 
            // CombDetalleServiAlimentario
            // 
            this.CombDetalleServiAlimentario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombDetalleServiAlimentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombDetalleServiAlimentario.FormattingEnabled = true;
            this.CombDetalleServiAlimentario.Items.AddRange(new object[] {
            "Caldo de huevo con café",
            "Arepa rellena con queso y café con leche",
            "Sandwich con café o con café con leche",
            "Tajadas con huevo",
            "",
            "Arroz con carne molida, ensalada y jugo de lulo",
            "Espaguetes con tajadas maduras, queso y jugo de mango",
            "Sopa de mondongo con arroz blanco y agua de panela",
            "Arroz de pollo con verduras, tajadas y jugo de naranja",
            "",
            "Panqueques con miel y queso",
            "Guineo cosido con mantquilla y queso",
            "Arepa rellena de queso con mantequilla y chicha",
            "Rosquetes con queso y agua panela ",
            ""});
            this.CombDetalleServiAlimentario.Location = new System.Drawing.Point(278, 240);
            this.CombDetalleServiAlimentario.Name = "CombDetalleServiAlimentario";
            this.CombDetalleServiAlimentario.Size = new System.Drawing.Size(182, 28);
            this.CombDetalleServiAlimentario.TabIndex = 22;
            this.CombDetalleServiAlimentario.SelectedIndexChanged += new System.EventHandler(this.CombDetalleServiAlimentario_SelectedIndexChanged);
            // 
            // TxtIdentiServiAlimentario
            // 
            this.TxtIdentiServiAlimentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentiServiAlimentario.Location = new System.Drawing.Point(278, 77);
            this.TxtIdentiServiAlimentario.Name = "TxtIdentiServiAlimentario";
            this.TxtIdentiServiAlimentario.Size = new System.Drawing.Size(182, 26);
            this.TxtIdentiServiAlimentario.TabIndex = 23;
            this.TxtIdentiServiAlimentario.TextChanged += new System.EventHandler(this.TxtIdentiServiAlimentario_TextChanged);
            // 
            // BtRegistrarServiAlimentario
            // 
            this.BtRegistrarServiAlimentario.Location = new System.Drawing.Point(278, 471);
            this.BtRegistrarServiAlimentario.Name = "BtRegistrarServiAlimentario";
            this.BtRegistrarServiAlimentario.Size = new System.Drawing.Size(92, 31);
            this.BtRegistrarServiAlimentario.TabIndex = 26;
            this.BtRegistrarServiAlimentario.Text = "REGISTRAR";
            this.BtRegistrarServiAlimentario.UseVisualStyleBackColor = true;
            this.BtRegistrarServiAlimentario.Click += new System.EventHandler(this.BtRegistrarServiAlimentario_Click);
            // 
            // BtEliminarServiAlimentario
            // 
            this.BtEliminarServiAlimentario.Location = new System.Drawing.Point(414, 471);
            this.BtEliminarServiAlimentario.Name = "BtEliminarServiAlimentario";
            this.BtEliminarServiAlimentario.Size = new System.Drawing.Size(92, 31);
            this.BtEliminarServiAlimentario.TabIndex = 27;
            this.BtEliminarServiAlimentario.Text = "ELIMINAR";
            this.BtEliminarServiAlimentario.UseVisualStyleBackColor = true;
            this.BtEliminarServiAlimentario.Click += new System.EventHandler(this.BtEliminarServiAlimentario_Click);
            // 
            // BtCancelarServiAlimentario
            // 
            this.BtCancelarServiAlimentario.Location = new System.Drawing.Point(561, 471);
            this.BtCancelarServiAlimentario.Name = "BtCancelarServiAlimentario";
            this.BtCancelarServiAlimentario.Size = new System.Drawing.Size(92, 31);
            this.BtCancelarServiAlimentario.TabIndex = 28;
            this.BtCancelarServiAlimentario.Text = "CANCELAR";
            this.BtCancelarServiAlimentario.UseVisualStyleBackColor = true;
            this.BtCancelarServiAlimentario.Click += new System.EventHandler(this.BtCancelarServiAlimentario_Click);
            // 
            // CombCostComidaServiAlimentario
            // 
            this.CombCostComidaServiAlimentario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombCostComidaServiAlimentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombCostComidaServiAlimentario.FormattingEnabled = true;
            this.CombCostComidaServiAlimentario.Items.AddRange(new object[] {
            "$2000",
            "$2500",
            "$3000"});
            this.CombCostComidaServiAlimentario.Location = new System.Drawing.Point(278, 198);
            this.CombCostComidaServiAlimentario.Name = "CombCostComidaServiAlimentario";
            this.CombCostComidaServiAlimentario.Size = new System.Drawing.Size(182, 28);
            this.CombCostComidaServiAlimentario.TabIndex = 29;
            this.CombCostComidaServiAlimentario.SelectedIndexChanged += new System.EventHandler(this.CombCostComidaServiAlimentario_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(117, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tipo de comida";
            // 
            // TxtCantidadComida
            // 
            this.TxtCantidadComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadComida.Location = new System.Drawing.Point(278, 157);
            this.TxtCantidadComida.Name = "TxtCantidadComida";
            this.TxtCantidadComida.Size = new System.Drawing.Size(182, 26);
            this.TxtCantidadComida.TabIndex = 30;
            this.TxtCantidadComida.TextChanged += new System.EventHandler(this.TxtIdentificacion_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(117, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Identificacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(165, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 44);
            this.label1.TabIndex = 33;
            this.label1.Text = "SERVICIO ALIMENTARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(117, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(117, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Detalles de comida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(117, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Costo de la comida";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 151);
            this.dataGridView1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(117, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total de comida";
            // 
            // TxtTotalComida
            // 
            this.TxtTotalComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalComida.Location = new System.Drawing.Point(278, 282);
            this.TxtTotalComida.Name = "TxtTotalComida";
            this.TxtTotalComida.ReadOnly = true;
            this.TxtTotalComida.Size = new System.Drawing.Size(182, 26);
            this.TxtTotalComida.TabIndex = 58;
            this.TxtTotalComida.TextChanged += new System.EventHandler(this.TxtCantiComida_TextChanged);
            // 
            // ServicioAlimenticio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.TxtTotalComida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCantidadComida);
            this.Controls.Add(this.CombCostComidaServiAlimentario);
            this.Controls.Add(this.BtCancelarServiAlimentario);
            this.Controls.Add(this.BtEliminarServiAlimentario);
            this.Controls.Add(this.BtRegistrarServiAlimentario);
            this.Controls.Add(this.TxtIdentiServiAlimentario);
            this.Controls.Add(this.CombDetalleServiAlimentario);
            this.Controls.Add(this.CombTipoServiAlimentario);
            this.Name = "ServicioAlimenticio";
            this.Text = "Servicio Alimentario";
            this.Load += new System.EventHandler(this.ReservaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CombTipoServiAlimentario;
        private System.Windows.Forms.ComboBox CombDetalleServiAlimentario;
        private System.Windows.Forms.TextBox TxtIdentiServiAlimentario;
        private System.Windows.Forms.Button BtRegistrarServiAlimentario;
        private System.Windows.Forms.Button BtEliminarServiAlimentario;
        private System.Windows.Forms.Button BtCancelarServiAlimentario;
        private System.Windows.Forms.ComboBox CombCostComidaServiAlimentario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCantidadComida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotalComida;
    }
}