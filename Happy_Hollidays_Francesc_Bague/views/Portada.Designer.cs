
namespace Happy_Hollidays_Francesc_Bague.views
{
    partial class Portada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            this.msBarraSuperior = new System.Windows.Forms.MenuStrip();
            this.msArchivos = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCadenas = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHoteles = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.msiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // msBarraSuperior
            // 
            this.msBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msArchivos});
            this.msBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.msBarraSuperior.Name = "msBarraSuperior";
            this.msBarraSuperior.Size = new System.Drawing.Size(800, 24);
            this.msBarraSuperior.TabIndex = 0;
            this.msBarraSuperior.Text = "menuStrip1";
            // 
            // msArchivos
            // 
            this.msArchivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCadenas,
            this.msiHoteles,
            this.msiSeparador,
            this.msiSalir});
            this.msArchivos.Name = "msArchivos";
            this.msArchivos.Size = new System.Drawing.Size(65, 20);
            this.msArchivos.Text = "Archivos";
            // 
            // msiCadenas
            // 
            this.msiCadenas.Name = "msiCadenas";
            this.msiCadenas.Size = new System.Drawing.Size(180, 22);
            this.msiCadenas.Text = "Cadenas";
            this.msiCadenas.Click += new System.EventHandler(this.msiCadenas_Click);
            // 
            // msiHoteles
            // 
            this.msiHoteles.Name = "msiHoteles";
            this.msiHoteles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.msiHoteles.Size = new System.Drawing.Size(180, 22);
            this.msiHoteles.Text = "Hoteles";
            // 
            // msiSeparador
            // 
            this.msiSeparador.Name = "msiSeparador";
            this.msiSeparador.Size = new System.Drawing.Size(177, 6);
            // 
            // msiSalir
            // 
            this.msiSalir.Image = ((System.Drawing.Image)(resources.GetObject("msiSalir.Image")));
            this.msiSalir.Name = "msiSalir";
            this.msiSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msiSalir.Size = new System.Drawing.Size(180, 22);
            this.msiSalir.Text = "Salir";
            this.msiSalir.Click += new System.EventHandler(this.msiSalir_Click);
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msBarraSuperior);
            this.MainMenuStrip = this.msBarraSuperior;
            this.Name = "Portada";
            this.Text = "Aplicación Hoteles";
            this.msBarraSuperior.ResumeLayout(false);
            this.msBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msBarraSuperior;
        private System.Windows.Forms.ToolStripMenuItem msArchivos;
        private System.Windows.Forms.ToolStripMenuItem msiCadenas;
        private System.Windows.Forms.ToolStripMenuItem msiHoteles;
        private System.Windows.Forms.ToolStripSeparator msiSeparador;
        private System.Windows.Forms.ToolStripMenuItem msiSalir;
    }
}