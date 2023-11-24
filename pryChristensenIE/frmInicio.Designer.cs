namespace pryChristensenIE
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.barraDeCarga = new System.Windows.Forms.ProgressBar();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barraDeCarga
            // 
            this.barraDeCarga.Location = new System.Drawing.Point(207, 346);
            this.barraDeCarga.Name = "barraDeCarga";
            this.barraDeCarga.Size = new System.Drawing.Size(313, 32);
            this.barraDeCarga.TabIndex = 0;
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::pryChristensenIE.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(729, 437);
            this.Controls.Add(this.barraDeCarga);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boston Seguros";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar barraDeCarga;
        private System.Windows.Forms.Timer reloj;
    }
}

