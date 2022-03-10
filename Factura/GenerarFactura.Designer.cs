namespace Factura
{
    partial class GenerarFactura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSeleccionar = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.Consumo = new System.Windows.Forms.Label();
            this.txtEstrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotalAlcantarillado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubTotalAcueducto = new System.Windows.Forms.TextBox();
            this.txtValoPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAseo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSeleccionar);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBarrio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtConsumo);
            this.groupBox1.Controls.Add(this.Consumo);
            this.groupBox1.Controls.Add(this.txtEstrato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(447, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbSeleccionar
            // 
            this.cbSeleccionar.FormattingEnabled = true;
            this.cbSeleccionar.Location = new System.Drawing.Point(7, 23);
            this.cbSeleccionar.Name = "cbSeleccionar";
            this.cbSeleccionar.Size = new System.Drawing.Size(425, 24);
            this.cbSeleccionar.TabIndex = 2;
            this.cbSeleccionar.SelectedValueChanged += new System.EventHandler(this.cbSeleccionar_SelectedValueChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(251, 74);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(176, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dirección";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.Enabled = false;
            this.txtBarrio.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrio.Location = new System.Drawing.Point(251, 104);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(176, 23);
            this.txtBarrio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barrio";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Enabled = false;
            this.txtConsumo.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(76, 101);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(48, 23);
            this.txtConsumo.TabIndex = 1;
            // 
            // Consumo
            // 
            this.Consumo.AutoSize = true;
            this.Consumo.Location = new System.Drawing.Point(7, 104);
            this.Consumo.Name = "Consumo";
            this.Consumo.Size = new System.Drawing.Size(63, 16);
            this.Consumo.TabIndex = 0;
            this.Consumo.Text = "Consumo";
            // 
            // txtEstrato
            // 
            this.txtEstrato.Enabled = false;
            this.txtEstrato.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstrato.Location = new System.Drawing.Point(76, 72);
            this.txtEstrato.Name = "txtEstrato";
            this.txtEstrato.Size = new System.Drawing.Size(48, 23);
            this.txtEstrato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estrato";
            // 
            // txtSubtotalAlcantarillado
            // 
            this.txtSubtotalAlcantarillado.Enabled = false;
            this.txtSubtotalAlcantarillado.Location = new System.Drawing.Point(225, 180);
            this.txtSubtotalAlcantarillado.Name = "txtSubtotalAlcantarillado";
            this.txtSubtotalAlcantarillado.Size = new System.Drawing.Size(176, 23);
            this.txtSubtotalAlcantarillado.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subtotal Alcantarillado";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subtotal Acueducto";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSubTotalAcueducto
            // 
            this.txtSubTotalAcueducto.Enabled = false;
            this.txtSubTotalAcueducto.Location = new System.Drawing.Point(225, 207);
            this.txtSubTotalAcueducto.Name = "txtSubTotalAcueducto";
            this.txtSubTotalAcueducto.Size = new System.Drawing.Size(176, 23);
            this.txtSubTotalAcueducto.TabIndex = 1;
            // 
            // txtValoPagar
            // 
            this.txtValoPagar.Enabled = false;
            this.txtValoPagar.Location = new System.Drawing.Point(225, 266);
            this.txtValoPagar.Name = "txtValoPagar";
            this.txtValoPagar.Size = new System.Drawing.Size(176, 23);
            this.txtValoPagar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor a Pagar";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(289, 326);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(151, 45);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subtotal Aseo";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAseo
            // 
            this.txtAseo.Enabled = false;
            this.txtAseo.Location = new System.Drawing.Point(225, 236);
            this.txtAseo.Name = "txtAseo";
            this.txtAseo.Size = new System.Drawing.Size(176, 23);
            this.txtAseo.TabIndex = 1;
            // 
            // GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(474, 397);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAseo);
            this.Controls.Add(this.txtValoPagar);
            this.Controls.Add(this.txtSubTotalAcueducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubtotalAlcantarillado);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarFactura";
            this.Text = "Generar Facturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.GenerarFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSeleccionar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label Consumo;
        private System.Windows.Forms.TextBox txtEstrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotalAlcantarillado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubTotalAcueducto;
        private System.Windows.Forms.TextBox txtValoPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAseo;
    }
}

