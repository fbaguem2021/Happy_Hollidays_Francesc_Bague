using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Hollidays_Francesc_Bague.views
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void msiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msiCadenas_Click(object sender, EventArgs e)
        {
            Cadenas formCadenas = new Cadenas();
            formCadenas.ShowDialog();
        }

        private void msiHoteles_Click(object sender, EventArgs e)
        {
            Hoteles formhoteles = new Hoteles();
            formhoteles.ShowDialog();
        }
    }
}
