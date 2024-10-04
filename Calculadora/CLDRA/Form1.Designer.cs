namespace CLDRA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnUno = new Button();
            btnTres = new Button();
            btnDos = new Button();
            btnCuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSiete = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnBorrar = new Button();
            btnBorrarTodo = new Button();
            btnQuitar = new Button();
            btnDividir = new Button();
            btnCuadrado = new Button();
            btnRaizCuadrada = new Button();
            btnMultiplicar = new Button();
            btnResta = new Button();
            btnSumar = new Button();
            btnResultado = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnSigno = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 12);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(390, 54);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.Location = new Point(12, 294);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(62, 58);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(148, 294);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(62, 58);
            btnTres.TabIndex = 6;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Location = new Point(80, 294);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(62, 58);
            btnDos.TabIndex = 5;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Location = new Point(12, 230);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(62, 58);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(80, 230);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(62, 58);
            btnCinco.TabIndex = 7;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(148, 230);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(62, 58);
            btnSeis.TabIndex = 8;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Location = new Point(12, 166);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(62, 58);
            btnSiete.TabIndex = 9;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnNueve
            // 
            btnNueve.Location = new Point(148, 166);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(62, 58);
            btnNueve.TabIndex = 10;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Location = new Point(80, 166);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(62, 58);
            btnOcho.TabIndex = 10;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(12, 102);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(62, 58);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "ce";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(80, 102);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(62, 58);
            btnBorrarTodo.TabIndex = 12;
            btnBorrarTodo.Text = "c";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(148, 102);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(62, 58);
            btnQuitar.TabIndex = 13;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(272, 166);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(62, 58);
            btnDividir.TabIndex = 14;
            btnDividir.Tag = "/";
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += clickOperador;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Location = new Point(340, 102);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(62, 58);
            btnCuadrado.TabIndex = 15;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += clickOperador;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Location = new Point(272, 102);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(62, 58);
            btnRaizCuadrada.TabIndex = 16;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(340, 166);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(62, 58);
            btnMultiplicar.TabIndex = 17;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(340, 230);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(62, 58);
            btnResta.TabIndex = 18;
            btnResta.Tag = "-";
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += clickOperador;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(272, 230);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(62, 58);
            btnSumar.TabIndex = 18;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(272, 294);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(130, 58);
            btnResultado.TabIndex = 19;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.Location = new Point(148, 358);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(62, 58);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.Location = new Point(80, 358);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(62, 58);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.Location = new Point(12, 358);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(62, 58);
            btnSigno.TabIndex = 20;
            btnSigno.Text = "±";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += btnSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnResultado);
            Controls.Add(btnSumar);
            Controls.Add(btnResta);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnCuadrado);
            Controls.Add(btnDividir);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnOcho);
            Controls.Add(btnNueve);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnCuatro);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnTres;
        private Button btnDos;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSiete;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnBorrar;
        private Button btnBorrarTodo;
        private Button btnQuitar;
        private Button btnDividir;
        private Button btnCuadrado;
        private Button btnRaizCuadrada;
        private Button btnMultiplicar;
        private Button btnResta;
        private Button btnSumar;
        private Button btnResultado;
        private Button btnPunto;
        private Button btnCero;
        private Button btnSigno;
    }
}
