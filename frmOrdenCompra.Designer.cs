namespace OrdenPizza
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.npdCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbPasta = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkQueso = new System.Windows.Forms.CheckBox();
            this.chkChile = new System.Windows.Forms.CheckBox();
            this.chkEnsalada = new System.Windows.Forms.CheckBox();
            this.rbtnPersonal = new System.Windows.Forms.RadioButton();
            this.rbtnMediana = new System.Windows.Forms.RadioButton();
            this.rbtnGrande = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalcularTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPasta);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.npdCantidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza";
            // 
            // npdCantidad
            // 
            this.npdCantidad.Location = new System.Drawing.Point(99, 20);
            this.npdCantidad.Name = "npdCantidad";
            this.npdCantidad.Size = new System.Drawing.Size(112, 20);
            this.npdCantidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pasta";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(100, 51);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(110, 21);
            this.cmbTipo.TabIndex = 4;
            // 
            // cmbPasta
            // 
            this.cmbPasta.FormattingEnabled = true;
            this.cmbPasta.Location = new System.Drawing.Point(99, 86);
            this.cmbPasta.Name = "cmbPasta";
            this.cmbPasta.Size = new System.Drawing.Size(110, 21);
            this.cmbPasta.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnGrande);
            this.groupBox2.Controls.Add(this.rbtnMediana);
            this.groupBox2.Controls.Add(this.rbtnPersonal);
            this.groupBox2.Location = new System.Drawing.Point(13, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamaño";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkEnsalada);
            this.groupBox3.Controls.Add(this.chkChile);
            this.groupBox3.Controls.Add(this.chkQueso);
            this.groupBox3.Location = new System.Drawing.Point(242, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extras";
            // 
            // chkQueso
            // 
            this.chkQueso.AutoSize = true;
            this.chkQueso.Location = new System.Drawing.Point(9, 18);
            this.chkQueso.Name = "chkQueso";
            this.chkQueso.Size = new System.Drawing.Size(57, 17);
            this.chkQueso.TabIndex = 0;
            this.chkQueso.Text = "Queso";
            this.chkQueso.UseVisualStyleBackColor = true;
            // 
            // chkChile
            // 
            this.chkChile.AutoSize = true;
            this.chkChile.Location = new System.Drawing.Point(9, 48);
            this.chkChile.Name = "chkChile";
            this.chkChile.Size = new System.Drawing.Size(49, 17);
            this.chkChile.TabIndex = 1;
            this.chkChile.Text = "Chile";
            this.chkChile.UseVisualStyleBackColor = true;
            // 
            // chkEnsalada
            // 
            this.chkEnsalada.AutoSize = true;
            this.chkEnsalada.Location = new System.Drawing.Point(9, 76);
            this.chkEnsalada.Name = "chkEnsalada";
            this.chkEnsalada.Size = new System.Drawing.Size(70, 17);
            this.chkEnsalada.TabIndex = 2;
            this.chkEnsalada.Text = "Ensalada";
            this.chkEnsalada.UseVisualStyleBackColor = true;
            // 
            // rbtnPersonal
            // 
            this.rbtnPersonal.AutoSize = true;
            this.rbtnPersonal.Location = new System.Drawing.Point(14, 31);
            this.rbtnPersonal.Name = "rbtnPersonal";
            this.rbtnPersonal.Size = new System.Drawing.Size(66, 17);
            this.rbtnPersonal.TabIndex = 0;
            this.rbtnPersonal.TabStop = true;
            this.rbtnPersonal.Text = "Personal";
            this.rbtnPersonal.UseVisualStyleBackColor = true;
            // 
            // rbtnMediana
            // 
            this.rbtnMediana.AutoSize = true;
            this.rbtnMediana.Location = new System.Drawing.Point(137, 30);
            this.rbtnMediana.Name = "rbtnMediana";
            this.rbtnMediana.Size = new System.Drawing.Size(66, 17);
            this.rbtnMediana.TabIndex = 1;
            this.rbtnMediana.TabStop = true;
            this.rbtnMediana.Text = "Mediana";
            this.rbtnMediana.UseVisualStyleBackColor = true;
            // 
            // rbtnGrande
            // 
            this.rbtnGrande.AutoSize = true;
            this.rbtnGrande.Location = new System.Drawing.Point(254, 30);
            this.rbtnGrande.Name = "rbtnGrande";
            this.rbtnGrande.Size = new System.Drawing.Size(60, 17);
            this.rbtnGrande.TabIndex = 2;
            this.rbtnGrande.TabStop = true;
            this.rbtnGrande.Text = "Grande";
            this.rbtnGrande.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(141, 234);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 31);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(150, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio Total";
            // 
            // txtCalcularTotal
            // 
            this.txtCalcularTotal.Enabled = false;
            this.txtCalcularTotal.Location = new System.Drawing.Point(141, 281);
            this.txtCalcularTotal.Name = "txtCalcularTotal";
            this.txtCalcularTotal.Size = new System.Drawing.Size(138, 20);
            this.txtCalcularTotal.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 386);
            this.Controls.Add(this.txtCalcularTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPasta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown npdCantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkEnsalada;
        private System.Windows.Forms.CheckBox chkChile;
        private System.Windows.Forms.CheckBox chkQueso;
        private System.Windows.Forms.RadioButton rbtnGrande;
        private System.Windows.Forms.RadioButton rbtnMediana;
        private System.Windows.Forms.RadioButton rbtnPersonal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalcularTotal;
    }
}

