namespace pryChristensenIE
{
    partial class frmLeerArchivos
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
            this.lblLectura = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLectura
            // 
            this.lblLectura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLectura.Location = new System.Drawing.Point(134, 207);
            this.lblLectura.Name = "lblLectura";
            this.lblLectura.Size = new System.Drawing.Size(495, 208);
            this.lblLectura.TabIndex = 6;
            this.lblLectura.Text = "-";
            this.lblLectura.Click += new System.EventHandler(this.lblLectura_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(221, 99);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(311, 77);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // frmLeerArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLectura);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmLeerArchivos";
            this.Text = " Leer Archivos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLectura;
        private System.Windows.Forms.Button btnLeer;
    }
}