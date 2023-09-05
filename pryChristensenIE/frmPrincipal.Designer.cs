namespace pryChristensenIE
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProveedoresToolStripMenuItem,
            this.leerArchivosToolStripMenuItem,
            this.escribirArchivosToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // agregarProveedoresToolStripMenuItem
            // 
            this.agregarProveedoresToolStripMenuItem.Name = "agregarProveedoresToolStripMenuItem";
            this.agregarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.agregarProveedoresToolStripMenuItem.Text = "Agregar Proveedores";
            this.agregarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.agregarProveedoresToolStripMenuItem_Click);
            // 
            // leerArchivosToolStripMenuItem
            // 
            this.leerArchivosToolStripMenuItem.Name = "leerArchivosToolStripMenuItem";
            this.leerArchivosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.leerArchivosToolStripMenuItem.Text = "Leer Archivos";
            this.leerArchivosToolStripMenuItem.Click += new System.EventHandler(this.leerArchivosToolStripMenuItem_Click);
            // 
            // escribirArchivosToolStripMenuItem
            // 
            this.escribirArchivosToolStripMenuItem.Name = "escribirArchivosToolStripMenuItem";
            this.escribirArchivosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.escribirArchivosToolStripMenuItem.Text = "Escribir Archivos";
            this.escribirArchivosToolStripMenuItem.Click += new System.EventHandler(this.escribirArchivosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Proveedores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerArchivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirArchivosToolStripMenuItem;
    }
}