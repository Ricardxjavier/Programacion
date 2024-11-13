namespace Calculadora_de_KM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Galon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.Maximo = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.BCal = new System.Windows.Forms.Button();
            this.BBorra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Galon,
            this.Costo,
            this.KM});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 70);
            this.dataGridView1.TabIndex = 0;
            // 
            // Galon
            // 
            this.Galon.HeaderText = "Cosumo L/100KM";
            this.Galon.Name = "Galon";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo x KM";
            this.Costo.Name = "Costo";
            // 
            // KM
            // 
            this.KM.HeaderText = "KM x Galon";
            this.KM.Name = "KM";
            // 
            // Minimo
            // 
            this.Minimo.AutoSize = true;
            this.Minimo.Location = new System.Drawing.Point(16, 24);
            this.Minimo.Name = "Minimo";
            this.Minimo.Size = new System.Drawing.Size(92, 13);
            this.Minimo.TabIndex = 1;
            this.Minimo.Text = "Consumo Mínimo:";
            this.Minimo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(110, 21);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 2;
            this.txtMin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Maximo
            // 
            this.Maximo.AutoSize = true;
            this.Maximo.Location = new System.Drawing.Point(16, 51);
            this.Maximo.Name = "Maximo";
            this.Maximo.Size = new System.Drawing.Size(93, 13);
            this.Maximo.TabIndex = 3;
            this.Maximo.Text = "Consumo Máximo:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(110, 47);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 4;
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(19, 79);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(40, 13);
            this.precio.TabIndex = 5;
            this.precio.Text = "Precio:";
            this.precio.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(110, 76);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // BCal
            // 
            this.BCal.Location = new System.Drawing.Point(245, 21);
            this.BCal.Name = "BCal";
            this.BCal.Size = new System.Drawing.Size(103, 32);
            this.BCal.TabIndex = 7;
            this.BCal.Text = "Calcular";
            this.BCal.UseVisualStyleBackColor = true;
            this.BCal.Click += new System.EventHandler(this.BCal_Click);
            // 
            // BBorra
            // 
            this.BBorra.Location = new System.Drawing.Point(245, 64);
            this.BBorra.Name = "BBorra";
            this.BBorra.Size = new System.Drawing.Size(103, 32);
            this.BBorra.TabIndex = 8;
            this.BBorra.Text = "Borrar";
            this.BBorra.UseVisualStyleBackColor = true;
            this.BBorra.Click += new System.EventHandler(this.BBorra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 223);
            this.Controls.Add(this.BBorra);
            this.Controls.Add(this.BCal);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.Maximo);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.Minimo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Galon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM;
        private System.Windows.Forms.Label Minimo;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label Maximo;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button BCal;
        private System.Windows.Forms.Button BBorra;
    }
}

