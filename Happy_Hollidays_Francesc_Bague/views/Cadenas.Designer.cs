
namespace Happy_Hollidays_Francesc_Bague.views
{
    partial class Cadenas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadenas));
            this.msOpciones = new System.Windows.Forms.MenuStrip();
            this.msiAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCadenas = new System.Windows.Forms.DataGridView();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirfisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCadenas = new System.Windows.Forms.BindingSource(this.components);
            this.msOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadenas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCadenas)).BeginInit();
            this.SuspendLayout();
            // 
            // msOpciones
            // 
            this.msOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAñadir,
            this.msiSalir});
            this.msOpciones.Location = new System.Drawing.Point(0, 0);
            this.msOpciones.Name = "msOpciones";
            this.msOpciones.Size = new System.Drawing.Size(800, 24);
            this.msOpciones.TabIndex = 0;
            this.msOpciones.Text = "menuStrip1";
            // 
            // msiAñadir
            // 
            this.msiAñadir.Image = ((System.Drawing.Image)(resources.GetObject("msiAñadir.Image")));
            this.msiAñadir.Name = "msiAñadir";
            this.msiAñadir.Size = new System.Drawing.Size(113, 20);
            this.msiAñadir.Text = "Añadir Cadena";
            this.msiAñadir.Click += new System.EventHandler(this.msiAñadir_Click);
            // 
            // msiSalir
            // 
            this.msiSalir.Image = ((System.Drawing.Image)(resources.GetObject("msiSalir.Image")));
            this.msiSalir.Name = "msiSalir";
            this.msiSalir.Size = new System.Drawing.Size(57, 20);
            this.msiSalir.Text = "Salir";
            this.msiSalir.Click += new System.EventHandler(this.msiSalir_Click);
            // 
            // dgvCadenas
            // 
            this.dgvCadenas.AllowUserToAddRows = false;
            this.dgvCadenas.AllowUserToDeleteRows = false;
            this.dgvCadenas.AutoGenerateColumns = false;
            this.dgvCadenas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadenas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cifDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.dirfisDataGridViewTextBoxColumn,
            this.hotelesDataGridViewTextBoxColumn});
            this.dgvCadenas.DataSource = this.bsCadenas;
            this.dgvCadenas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCadenas.Location = new System.Drawing.Point(0, 24);
            this.dgvCadenas.Name = "dgvCadenas";
            this.dgvCadenas.ReadOnly = true;
            this.dgvCadenas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadenas.Size = new System.Drawing.Size(800, 426);
            this.dgvCadenas.TabIndex = 1;
            this.dgvCadenas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadenas_CellDoubleClick);
            this.dgvCadenas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCadenas_KeyUp);
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.FillWeight = 25F;
            this.cifDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 25F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirfisDataGridViewTextBoxColumn
            // 
            this.dirfisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dirfisDataGridViewTextBoxColumn.DataPropertyName = "dir_fis";
            this.dirfisDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dirfisDataGridViewTextBoxColumn.HeaderText = "Direccion Fiscal";
            this.dirfisDataGridViewTextBoxColumn.Name = "dirfisDataGridViewTextBoxColumn";
            this.dirfisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelesDataGridViewTextBoxColumn
            // 
            this.hotelesDataGridViewTextBoxColumn.DataPropertyName = "hoteles";
            this.hotelesDataGridViewTextBoxColumn.HeaderText = "hoteles";
            this.hotelesDataGridViewTextBoxColumn.Name = "hotelesDataGridViewTextBoxColumn";
            this.hotelesDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelesDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsCadenas
            // 
            this.bsCadenas.DataSource = typeof(Happy_Hollidays_Francesc_Bague.models.cadenas);
            // 
            // Cadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCadenas);
            this.Controls.Add(this.msOpciones);
            this.MainMenuStrip = this.msOpciones;
            this.Name = "Cadenas";
            this.Text = "Cadenas";
            this.Load += new System.EventHandler(this.Cadenas_Load);
            this.msOpciones.ResumeLayout(false);
            this.msOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadenas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCadenas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOpciones;
        private System.Windows.Forms.ToolStripMenuItem msiAñadir;
        private System.Windows.Forms.ToolStripMenuItem msiSalir;
        private System.Windows.Forms.BindingSource bsCadenas;
        private System.Windows.Forms.DataGridView dgvCadenas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirfisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelesDataGridViewTextBoxColumn;
    }
}