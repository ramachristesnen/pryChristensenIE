namespace pryChristensenIE
{
    partial class frmArchivoDeProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivoDeProveedores));
            this.lblDatos = new System.Windows.Forms.Label();
            this.twCarpetasProvedores = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.SystemColors.Control;
            this.lblDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(407, 66);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(233, 248);
            this.lblDatos.TabIndex = 4;
            // 
            // twCarpetasProvedores
            // 
            this.twCarpetasProvedores.Location = new System.Drawing.Point(160, 66);
            this.twCarpetasProvedores.Margin = new System.Windows.Forms.Padding(2);
            this.twCarpetasProvedores.Name = "twCarpetasProvedores";
            this.twCarpetasProvedores.Size = new System.Drawing.Size(225, 248);
            this.twCarpetasProvedores.TabIndex = 3;
            this.twCarpetasProvedores.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.twCarpetasProvedores_NodeMouseDoubleClick);
            // 
            // frmArchivoDeProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.twCarpetasProvedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArchivoDeProveedores";
            this.Text = "Archivo De Proveedores";
            this.Load += new System.EventHandler(this.frmArchivoDeProveedores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TreeView twCarpetasProvedores;
    }
}