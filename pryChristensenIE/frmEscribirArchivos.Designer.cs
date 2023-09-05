namespace pryChristensenIE
{
    partial class frmEscribirArchivos
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
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEscribir
            // 
            this.txtEscribir.Location = new System.Drawing.Point(232, 165);
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(247, 20);
            this.txtEscribir.TabIndex = 7;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribir.Location = new System.Drawing.Point(232, 191);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(247, 107);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // frmEscribirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEscribir);
            this.Controls.Add(this.btnEscribir);
            this.Name = "frmEscribirArchivos";
            this.Text = "Escribir Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.Button btnEscribir;
    }
}