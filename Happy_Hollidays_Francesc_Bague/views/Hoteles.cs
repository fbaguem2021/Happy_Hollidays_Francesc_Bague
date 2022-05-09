using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Happy_Hollidays_Francesc_Bague.models;
using Happy_Hollidays_Francesc_Bague.controllers;

namespace Happy_Hollidays_Francesc_Bague.views
{
    public partial class Hoteles : Form
    {
        public Hoteles()
        {
            InitializeComponent();
        }

        private void Hoteles_Load(object sender, EventArgs e)
        {
            initSources();
        }

        private void initSources()
        {
            List<ciudades> ciudades = CiudadController.SelectAll();
            bsCiudades.DataSource = ciudades;
            bsHoteles.DataSource = HotelesController.Select(ciudades[0]);
        }
        private void updateData(ciudades c)
        {
            bsHoteles.DataSource = HotelesController.Select(c);
        }

        private void msiNuevoHotel_Click(object sender, EventArgs e)
        {
            ManageHoteles f = new ManageHoteles();
            f.ShowDialog();
        }

        private void msiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateData( (ciudades) cmbCiudades.SelectedItem );
        }

        private void dgvHoteles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageHoteles f = new ManageHoteles(
                (hoteles)dgvHoteles.SelectedRows[0].DataBoundItem
            );
            f.ShowDialog();
            updateData( (ciudades)cmbCiudades.SelectedItem );
        }
    }
}
