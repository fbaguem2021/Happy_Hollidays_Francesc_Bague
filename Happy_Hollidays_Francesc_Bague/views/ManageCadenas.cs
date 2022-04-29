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
    public partial class ManageCadenas : Form
    {
        private Boolean editStatus = false;
        private cadenas cadena;
        public ManageCadenas()
        {
            InitializeComponent();
        }

        public ManageCadenas(cadenas cadena)
        {
            editStatus = true;
            this.cadena = cadena;
            InitializeComponent();
        }

        #region Eventos
        private void ManageCadenas_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(500, 200);
            this.MaximumSize = new Size(500, 200);

            if (editStatus)
            {
                tbCIF.Text = this.cadena.cif;
                tbNombre.Text = this.cadena.nombre;
                tbDireccion.Text = this.cadena.dir_fis;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                DialogResult dr = MessageBox.Show("Seguro que quieres añadir la cadena?", "¡¡ WARNING !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.Equals(DialogResult.Yes))
                {
                    cadenas cadena = new cadenas();
                    cadena.cif = tbCIF.Text;
                    cadena.nombre = tbNombre.Text;
                    cadena.dir_fis = tbDireccion.Text;

                    String err = CadenasController.Insert(cadena);

                    if (String.IsNullOrEmpty(err))
                    {
                        MessageBox.Show(err);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodoa
        private bool validateData()
        {
            bool cif = (
                !String.IsNullOrEmpty(tbCIF.Text) &&
                tbCIF.Text.Length <= 9
                );
            bool nombre = (
                !String.IsNullOrEmpty(tbNombre.Text) &&
                tbNombre.Text.Length <= 50
                );
            bool direccion = (
                !String.IsNullOrEmpty(tbDireccion.Text) &&
                tbDireccion.Text.Length <= 50
                );

            if (cif && nombre && direccion)
            {
                return true;
            }
            else
            {
                String message = "";
                if (!cif)
                {
                    message += "El CIF no puede estar vacio y no puede tener mas de 9 caracteres\n";
                }
                if (!nombre)
                {
                    message += "El nombre no puede estar vacio y no puede tener mas de 50 caracteres\n";
                }
                if (!direccion)
                {
                    message += "La Direccion no puede estar vacia y no puede tener mas de 50 caracteres";
                }
                MessageBox.Show(message, "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        #endregion
    }
}
