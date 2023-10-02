namespace pryChristensenIE
{
    partial class frmRegistroDeProveedores
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtLiquidador = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtJuzg = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(30, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 20;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(681, 151);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 19;
            this.btnGrabar.Text = "grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtLiquidador
            // 
            this.txtLiquidador.Location = new System.Drawing.Point(671, 85);
            this.txtLiquidador.Name = "txtLiquidador";
            this.txtLiquidador.Size = new System.Drawing.Size(100, 20);
            this.txtLiquidador.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(560, 85);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 17;
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Location = new System.Drawing.Point(454, 85);
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(100, 20);
            this.txtJurisdiccion.TabIndex = 16;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(136, 85);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(100, 20);
            this.txtApertura.TabIndex = 15;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(30, 85);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(100, 20);
            this.txtEntidad.TabIndex = 14;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(242, 85);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtExpediente.TabIndex = 13;
            // 
            // txtJuzg
            // 
            this.txtJuzg.Location = new System.Drawing.Point(348, 85);
            this.txtJuzg.Name = "txtJuzg";
            this.txtJuzg.Size = new System.Drawing.Size(100, 20);
            this.txtJuzg.TabIndex = 12;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Entidad,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDatos.Location = new System.Drawing.Point(30, 206);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(741, 200);
            this.dgvDatos.TabIndex = 11;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N*";
            this.Column1.Name = "Column1";
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apertura";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "N* Expediente";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Juzg.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jurisdicción";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Dirección";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Liquidador responsable";
            this.Column7.Name = "Column7";
            // 
            // frmRegistroDeProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtLiquidador);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtJurisdiccion);
            this.Controls.Add(this.txtApertura);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.txtJuzg);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmRegistroDeProveedores";
            this.Text = "frmRegistroDeProveedores";
            this.Load += new System.EventHandler(this.frmRegistroDeProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtLiquidador;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtJurisdiccion;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtJuzg;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}