namespace AgendaContactos2
{
    public partial class FrmAgendaContactos : Form
    {
        public FrmAgendaContactos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha agregado un contacto");
        }

        private void nUdEdad_ValueChanged(object sender, EventArgs e)
        {
            if (nUdEdad.Value % 5 == 0)
            {
                this.Text = "Agenda de contacto: " + DateTime.Now;
            }
        }

        private void chBoxFormMax_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxFormMax.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}