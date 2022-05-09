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
        private List<act_hotel> act_hoteles = new List<act_hotel>();
        private List<actividades> actividades = new List<actividades>();
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
            if (editionMode)
            updateData();
            {
                loadEditionData();
            }
        }
        private void updateData()
        {
            bsCiudad.DataSource = CiudadController.SelectAll();
            bsCadena.DataSource = CadenasController.selectAll();
            //bsActividades.DataSource = ActividadesController.Select();
            if (this.editionMode == true)
            {
                bsActividades.DataSource = ActividadesController.SelectByHotel(this.hotel);
            }
            else
            {
                bsActividades.DataSource = ActividadesController.Select();
            }
            cmbTipo.DataSource = TIPOS;
        }
        private void loadEditionData()
        {
            bsActividades.DataSource = ActividadesController.SelectByHotel(this.hotel);
            this.act_hoteles = ActHotelController.Select(this.hotel);
            bsAct_Hotel.DataSource = act_hoteles;
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
                //this.Close();
            }
            else
            {
                MessageBox.Show("La categoria ha de estar entre 1 y 5");
            }
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (editionMode)
            {
                act_hotel ah = new act_hotel();
                ah.id_ciudad = this.hotel.id_ciudad;
                ah.nombre = this.hotel.nombre;
                ah.id_act = (int)cmbActividades.SelectedValue;
                String a = ActHotelController.Insert(ah);
                Console.WriteLine(a);
                bsActividades.DataSource = ActividadesController.SelectByHotel(this.hotel);
            }
            else
            {
                MessageBox.Show("Primero deves crear un hotel");
            }
        }

        private void dgvActividades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvActividades.Columns[e.ColumnIndex].Name == "act_nombre")
            {
                dgvActividades.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ActividadesController.SelectById(act_hoteles[e.RowIndex].id_act).descripcion;
            }
        }
    }
}
