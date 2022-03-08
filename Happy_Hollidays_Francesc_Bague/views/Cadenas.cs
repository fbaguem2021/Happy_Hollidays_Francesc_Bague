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
    public partial class Cadenas : Form
    {
        public Cadenas()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Cadenas_Load(object sender, EventArgs e)
        {
            updateData();
        }
        private void dgvCadenas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvCadenas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                DialogResult dr = MessageBox.Show("Estas seguro de querer borrar?", "¡¡ AVISO !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr.Equals(DialogResult.Yes))
                {
                    cadenas selectedCadena = (cadenas) dgvCadenas.CurrentRow.DataBoundItem;
                    CadenasController.Delete(selectedCadena.cif);
                }
            }
        }
        private void msiAñadir_Click(object sender, EventArgs e)
        {
            ManageCadenas manageCadenas = new ManageCadenas();
            manageCadenas.ShowDialog();
        }
        private void msiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Metodos
        private void updateData()
        {
            bsCadenas.DataSource = CadenasController.selectAll();
        }

        #endregion

        
    }
}
