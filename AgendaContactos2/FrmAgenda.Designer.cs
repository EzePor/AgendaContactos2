namespace AgendaContactos2
{
    partial class FrmAgendaContactos
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
            btnSalir = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox = new TextBox();
            listaContacto = new ListView();
            nUdEdad = new NumericUpDown();
            chBoxFormMax = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUdEdad).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkOliveGreen;
            btnSalir.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(326, 747);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(99, 52);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightGreen;
            button1.Location = new Point(50, 632);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(144, 88);
            button1.TabIndex = 1;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOliveGreen;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightGreen;
            button2.Location = new Point(258, 632);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(144, 91);
            button2.TabIndex = 2;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Presentación.Properties.Resources._552632;
            pictureBox1.Location = new Point(-34, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox
            // 
            textBox.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(14, 731);
            textBox.Margin = new Padding(3, 4, 3, 4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(277, 64);
            textBox.TabIndex = 4;
            // 
            // listaContacto
            // 
            listaContacto.BackColor = Color.DarkOliveGreen;
            listaContacto.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listaContacto.ForeColor = SystemColors.ControlDarkDark;
            listaContacto.Location = new Point(14, 426);
            listaContacto.Margin = new Padding(3, 4, 3, 4);
            listaContacto.Name = "listaContacto";
            listaContacto.Size = new Size(411, 155);
            listaContacto.TabIndex = 5;
            listaContacto.UseCompatibleStateImageBehavior = false;
            // 
            // nUdEdad
            // 
            nUdEdad.Location = new Point(67, 323);
            nUdEdad.Name = "nUdEdad";
            nUdEdad.Size = new Size(274, 27);
            nUdEdad.TabIndex = 6;
            nUdEdad.ValueChanged += nUdEdad_ValueChanged;
            // 
            // chBoxFormMax
            // 
            chBoxFormMax.AutoSize = true;
            chBoxFormMax.Location = new Point(102, 377);
            chBoxFormMax.Name = "chBoxFormMax";
            chBoxFormMax.Size = new Size(189, 24);
            chBoxFormMax.TabIndex = 7;
            chBoxFormMax.Text = "Formulario Maximizado";
            chBoxFormMax.UseVisualStyleBackColor = true;
            chBoxFormMax.CheckedChanged += chBoxFormMax_CheckedChanged;
            // 
            // FrmAgendaContactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(437, 804);
            Controls.Add(chBoxFormMax);
            Controls.Add(nUdEdad);
            Controls.Add(listaContacto);
            Controls.Add(textBox);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            MinimumSize = new Size(455, 851);
            Name = "FrmAgendaContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Contactos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUdEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox;
        private ListView listaContacto;
        private NumericUpDown nUdEdad;
        private CheckBox chBoxFormMax;
    }
}