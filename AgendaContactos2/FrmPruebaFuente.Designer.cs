namespace Presentación
{
    partial class FrmPruebaFuente
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
            CBoFuentes = new ComboBox();
            cbColor = new ComboBox();
            txbxTexto = new TextBox();
            paVistaPrevia = new Panel();
            lblVistaPrevia = new Label();
            chBoxNegrita = new CheckBox();
            chboCursiva = new CheckBox();
            nudTamaño = new NumericUpDown();
            btnAceptar = new Button();
            lblFuentes = new Label();
            lblColores = new Label();
            lblTexto = new Label();
            lblTamaño = new Label();
            rbtIzquierda = new RadioButton();
            rbtCentrado = new RadioButton();
            rbtDerecha = new RadioButton();
            paVistaPrevia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTamaño).BeginInit();
            SuspendLayout();
            // 
            // CBoFuentes
            // 
            CBoFuentes.FormattingEnabled = true;
            CBoFuentes.Location = new Point(79, 29);
            CBoFuentes.Name = "CBoFuentes";
            CBoFuentes.Size = new Size(276, 28);
            CBoFuentes.TabIndex = 0;
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Location = new Point(579, 29);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(260, 28);
            cbColor.TabIndex = 1;
            // 
            // txbxTexto
            // 
            txbxTexto.Location = new Point(79, 172);
            txbxTexto.Name = "txbxTexto";
            txbxTexto.Size = new Size(415, 27);
            txbxTexto.TabIndex = 2;
            // 
            // paVistaPrevia
            // 
            paVistaPrevia.Controls.Add(lblVistaPrevia);
            paVistaPrevia.Location = new Point(79, 318);
            paVistaPrevia.Name = "paVistaPrevia";
            paVistaPrevia.Size = new Size(437, 211);
            paVistaPrevia.TabIndex = 3;
            // 
            // lblVistaPrevia
            // 
            lblVistaPrevia.Location = new Point(18, 20);
            lblVistaPrevia.Name = "lblVistaPrevia";
            lblVistaPrevia.Size = new Size(397, 176);
            lblVistaPrevia.TabIndex = 0;
            lblVistaPrevia.Text = "Vista Previa";
            // 
            // chBoxNegrita
            // 
            chBoxNegrita.AutoSize = true;
            chBoxNegrita.Location = new Point(137, 256);
            chBoxNegrita.Name = "chBoxNegrita";
            chBoxNegrita.Size = new Size(78, 24);
            chBoxNegrita.TabIndex = 4;
            chBoxNegrita.Text = "negrita";
            chBoxNegrita.UseVisualStyleBackColor = true;
            chBoxNegrita.CheckedChanged += chBoxNegrita_CheckedChanged;
            // 
            // chboCursiva
            // 
            chboCursiva.AutoSize = true;
            chboCursiva.Location = new Point(385, 254);
            chboCursiva.Name = "chboCursiva";
            chboCursiva.Size = new Size(76, 24);
            chboCursiva.TabIndex = 5;
            chboCursiva.Text = "cursiva";
            chboCursiva.UseVisualStyleBackColor = true;
            chboCursiva.CheckedChanged += chboCursiva_CheckedChanged;
            // 
            // nudTamaño
            // 
            nudTamaño.Location = new Point(665, 251);
            nudTamaño.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudTamaño.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            nudTamaño.Name = "nudTamaño";
            nudTamaño.Size = new Size(174, 27);
            nudTamaño.TabIndex = 6;
            nudTamaño.Value = new decimal(new int[] { 6, 0, 0, 0 });
            nudTamaño.ValueChanged += nudTamaño_ValueChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(511, 170);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblFuentes
            // 
            lblFuentes.AutoSize = true;
            lblFuentes.Location = new Point(12, 34);
            lblFuentes.Name = "lblFuentes";
            lblFuentes.Size = new Size(62, 20);
            lblFuentes.TabIndex = 11;
            lblFuentes.Text = "Fuentes:";
            // 
            // lblColores
            // 
            lblColores.AutoSize = true;
            lblColores.Location = new Point(511, 32);
            lblColores.Name = "lblColores";
            lblColores.Size = new Size(62, 20);
            lblColores.TabIndex = 12;
            lblColores.Text = "Colores:";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(21, 179);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(48, 20);
            lblTexto.TabIndex = 13;
            lblTexto.Text = "Texto:";
            // 
            // lblTamaño
            // 
            lblTamaño.AutoSize = true;
            lblTamaño.Location = new Point(845, 255);
            lblTamaño.Name = "lblTamaño";
            lblTamaño.Size = new Size(61, 20);
            lblTamaño.TabIndex = 14;
            lblTamaño.Text = "Tamaño";
            // 
            // rbtIzquierda
            // 
            rbtIzquierda.AutoSize = true;
            rbtIzquierda.Location = new Point(665, 338);
            rbtIzquierda.Name = "rbtIzquierda";
            rbtIzquierda.Size = new Size(92, 24);
            rbtIzquierda.TabIndex = 15;
            rbtIzquierda.TabStop = true;
            rbtIzquierda.Text = "Izquierda";
            rbtIzquierda.UseVisualStyleBackColor = true;
            // 
            // rbtCentrado
            // 
            rbtCentrado.AutoSize = true;
            rbtCentrado.Location = new Point(665, 409);
            rbtCentrado.Name = "rbtCentrado";
            rbtCentrado.Size = new Size(91, 24);
            rbtCentrado.TabIndex = 16;
            rbtCentrado.TabStop = true;
            rbtCentrado.Text = "Centrado";
            rbtCentrado.UseVisualStyleBackColor = true;
            // 
            // rbtDerecha
            // 
            rbtDerecha.AutoSize = true;
            rbtDerecha.Location = new Point(665, 470);
            rbtDerecha.Name = "rbtDerecha";
            rbtDerecha.Size = new Size(85, 24);
            rbtDerecha.TabIndex = 17;
            rbtDerecha.TabStop = true;
            rbtDerecha.Text = "Derecha";
            rbtDerecha.UseVisualStyleBackColor = true;
            // 
            // FrmPruebaFuente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(985, 541);
            Controls.Add(rbtDerecha);
            Controls.Add(rbtCentrado);
            Controls.Add(rbtIzquierda);
            Controls.Add(lblTamaño);
            Controls.Add(lblTexto);
            Controls.Add(lblColores);
            Controls.Add(lblFuentes);
            Controls.Add(btnAceptar);
            Controls.Add(nudTamaño);
            Controls.Add(chboCursiva);
            Controls.Add(chBoxNegrita);
            Controls.Add(paVistaPrevia);
            Controls.Add(txbxTexto);
            Controls.Add(cbColor);
            Controls.Add(CBoFuentes);
            Name = "FrmPruebaFuente";
            Text = "FrmPruebaFuente";
            paVistaPrevia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudTamaño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBoFuentes;
        private ComboBox cbColor;
        private TextBox txbxTexto;
        private Panel paVistaPrevia;
        private Label lblVistaPrevia;
        private CheckBox chBoxNegrita;
        private CheckBox chboCursiva;
        private NumericUpDown nudTamaño;
        private Button btnAceptar;
        private Label lblFuentes;
        private Label lblColores;
        private Label lblTexto;
        private Label lblTamaño;
        private RadioButton rbtIzquierda;
        private RadioButton rbtCentrado;
        private RadioButton rbtDerecha;
    }
}