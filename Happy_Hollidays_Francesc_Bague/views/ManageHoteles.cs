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
    public partial class ManageHoteles : Form
    {
        private readonly List<String> TIPOS = new List<String>(new String[] { "PLAYA", "MONTAÑA" });
        private bool editionMode;
        private hoteles hotel;
        public ManageHoteles()
        {
            InitializeComponent();
            this.editionMode = false;
            this.hotel = new hoteles();
            this.Text = "Alta Hotel";
        }
        public ManageHoteles(hoteles hotel)
        {
            InitializeComponent();
            this.editionMode = true;
            this.hotel = hotel;
            this.Text = "Modificación Hotel";
        }

        private void ManageHoteles_Load(object sender, EventArgs e)
        {
            updateData();
            if (editionMode)
            {
                loadEditionData();
            }
        }
        private void updateData()
        {
            bsCiudad.DataSource = CiudadController.SelectAll();
            bsCadena.DataSource = CadenasController.selectAll();
            cmbTipo.DataSource = TIPOS;
        }
        private void loadEditionData()
        {
            cmbCiudad   .SelectedValue   = this.hotel.id_ciudad;
            tbNombre    .Text            = this.hotel.nombre;
            tbCategoria .Text            = this.hotel.categoria.ToString();
            tbDirección .Text            = this.hotel.direccion;
            tbTelefono  .Text            = this.hotel.telefono.ToString();
            cmbCadena   .SelectedValue   = this.hotel.cif;
            cmbTipo     .SelectedItem    = this.hotel.tipo.ToString();
        }

        private void tbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = 
                !char.IsDigit(e.KeyChar) && 
                !char.IsControl(e.KeyChar);
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = 
                !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tbCategoria.Text) >= 1 && Int32.Parse(tbCategoria.Text) <= 9)
            {
                this.hotel.id_ciudad = (int)cmbCiudad.SelectedValue;
                this.hotel.nombre = tbNombre.Text;
                this.hotel.categoria = Int32.Parse(tbCategoria.Text);
                this.hotel.direccion = tbDirección.Text;
                this.hotel.telefono = Int32.Parse(tbTelefono.Text);
                this.hotel.tipo = cmbTipo.SelectedValue.ToString();
                this.hotel.cif = cmbCadena.SelectedValue.ToString();

                if (editionMode)
                {
                    HotelesController.Update(this.hotel);
                }
                else
                {
                    HotelesController.Insert(this.hotel);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("La categoria ha de estar entre 1 y 5");
            }
        }
    }
}
