using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FrmPruebaFuente : Form
    {
        public FrmPruebaFuente()
        {
            InitializeComponent();
        }
        //  texto agregado con aceptar a vista previa
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Enabled)
            {
                lblVistaPrevia.Text = txbxTexto.Text;
            }
        }
        // seleccionamos si es negrita o no
        private void chBoxNegrita_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxNegrita.Checked)
            {
                lblVistaPrevia.Font = new Font(lblVistaPrevia.Font, FontStyle.Bold);
            }
            else
            {

                lblVistaPrevia.Font = new Font(lblVistaPrevia.Font, FontStyle.Regular);
            }

        }

        private void chboCursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (chboCursiva.Checked)
            {
                lblVistaPrevia.Font = new Font(lblVistaPrevia.Font, FontStyle.Italic);
            }
            else
            {

                lblVistaPrevia.Font = new Font(lblVistaPrevia.Font, FontStyle.Regular);
            }
        }

        private void nudTamaño_ValueChanged(object sender, EventArgs e)
        {
            lblVistaPrevia.Font = new Font(lblVistaPrevia.Font.FontFamily, (float)nudTamaño.Value);
        }
    }
}
