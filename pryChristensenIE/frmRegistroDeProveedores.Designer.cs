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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeProveedores));
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLiquidador = new System.Windows.Forms.ComboBox();
            this.cmbJurisdiccion = new System.Windows.Forms.ComboBox();
            this.cmbJuzg = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(95, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(103, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(5, 392);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(117, 23);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(95, 283);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(103, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(95, 109);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(103, 20);
            this.txtApertura.TabIndex = 3;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(95, 66);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(103, 20);
            this.txtEntidad.TabIndex = 2;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(95, 151);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(103, 20);
            this.txtExpediente.TabIndex = 4;
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
            this.dgvDatos.Location = new System.Drawing.Point(230, 21);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(839, 329);
            this.dgvDatos.TabIndex = 11;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Entidad";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apertura";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "N*Expediente";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Juzg";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Jurisdiccion";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 37);
            this.label8.TabIndex = 28;
            this.label8.Text = "Liquidador Responsable";
            // 
            // cmbLiquidador
            // 
            this.cmbLiquidador.FormattingEnabled = true;
            this.cmbLiquidador.Items.AddRange(new object[] {
            "LIQUIDADOR RESPONSABLE",
            "Dra. María Cristina Ubbriaco",
            "Sr. Ricardo Crosetto",
            "Dra. María Alejandra Spagnolo",
            "Cont. Orlando Marcelo Suarez",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Martín Riera",
            "Dra. Alicia Nilda Sturla",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Claudia Marcela Pariente",
            "Cont. Héctor Jorge García",
            "Dra. Verónica Ortíz Auger",
            "Dr. Ezequiel Cará",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Luis Petrate Arguello",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Andrea Susana Rojas",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. María Alejandra Spagnolo",
            "Cont. Roberto Falvo",
            "Dra. María Mendía"});
            this.cmbLiquidador.Location = new System.Drawing.Point(93, 330);
            this.cmbLiquidador.Name = "cmbLiquidador";
            this.cmbLiquidador.Size = new System.Drawing.Size(105, 21);
            this.cmbLiquidador.TabIndex = 8;
            this.cmbLiquidador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbJurisdiccion
            // 
            this.cmbJurisdiccion.FormattingEnabled = true;
            this.cmbJurisdiccion.Items.AddRange(new object[] {
            "JURISD",
            "CABA",
            "Resistencia-Chaco",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Mercedes- Pcia. de Bs. As.",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Río Cuarto-Córdoba",
            "CABA",
            "CABA",
            "CABA",
            "Salta",
            "Bahía Blanca-Pcia. de Bs. As.",
            "CABA",
            "CABA",
            "Córdoba",
            "Lomas de Zamora-Pcia. de Bs. As.",
            "CABA",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "Lomas de Zamora-Pcia. de Bs. As.",
            "Rosario-Santa Fe",
            "CABA",
            "Chaco",
            "CABA",
            "CABA",
            "Villa María - Córdoba",
            "CABA",
            "CABA",
            "Tandil-Pcia. de Bs. As.",
            "Tucumán",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Rosario-Santa Fe",
            "CABA",
            "Rosario-Santa Fe",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "JURISD",
            "CABA",
            "Resistencia-Chaco",
            "Mercedes- Pcia. de Bs. As.",
            "Río Cuarto-Córdoba",
            "Salta",
            "Bahía Blanca-Pcia. de Bs. As.",
            "Córdoba",
            "Lomas de Zamora-Pcia. de Bs. As.",
            "Rosario-Santa Fe",
            "Chaco",
            "Villa María - Córdoba",
            "Tandil-Pcia. de Bs. As.",
            "Tucumán",
            "La Plata",
            "Tres Arroyos-Bs.As.",
            "T. Lauquen-Bs. As.",
            "Mendoza",
            "San Juan",
            "Venado Tuerto-Santa Fe",
            "Rafaela - Santa Fe",
            "Juzgado es Montevideo 546, piso 7º"});
            this.cmbJurisdiccion.Location = new System.Drawing.Point(95, 243);
            this.cmbJurisdiccion.Name = "cmbJurisdiccion";
            this.cmbJurisdiccion.Size = new System.Drawing.Size(103, 21);
            this.cmbJurisdiccion.TabIndex = 6;
            // 
            // cmbJuzg
            // 
            this.cmbJuzg.FormattingEnabled = true;
            this.cmbJuzg.Items.AddRange(new object[] {
            "JUZG.",
            "Comercial N° 2, Secretaría N° 3",
            "Civil y Comercial, 6ta. Nominación",
            "Comercial N° 19, Secretaría N° 38",
            "Comercial N° 16, Secretaría N° 31",
            "Comercial N° 24, Secretaría N° 47",
            "Comercial N° 3, Secretaría N° 5",
            "Comercial N° 8, Secretaría N° 15",
            "Comercial N° 15, Secretaría N° 30",
            "Comercial N° 5, Secretaría N° 9",
            "Civil y Comercial N° 9, sec. N° 8",
            "Comercial N° 26, Secretaría 52",
            "Comercial N° 24, Secretaría N° 48",
            "Comercial N° 1, Secretaría N° 1",
            "Comercial N° 25, Secretaría N° 50",
            "Comercial N° 5, Secretaría N° 10",
            "Comercial N° 9, Secretaría N° 18",
            "Comercial N° 4, Secretaría N° 8",
            "Comercial N° 12, Secretaría N° 24",
            "Comercial Nº 14, Secretaría N° 28",
            "Comercial Nº 26 Secretaría N° 51",
            "Comercial N° 1, Secretaría N° 2",
            "Civil Y Comercial de la 2da. Nom.",
            "Comercial N° 13, Secretaría N° 25",
            "Comercial N° 21, Secretaría 41",
            "Comercial N° 25, Secretaría N° 49",
            "Comercial N° 23, Secretaría N° 45",
            "Civil y Comercial N° 2, Sec. Unica",
            "Civil y Comercial N° 7",
            "Comercial N° 23, Secretaría N° 46",
            "Comercial N° 10, Secretaría N° 20",
            "Juzg. de distrito de la 8a nominación",
            "Civil y Comercial 13 nominacion",
            "Civil Y Comercial de la 10° Nom.",
            "Comercial N° 22, Secretaría N° 43",
            "Comercial N° 3, Secretaría N° 6",
            "Concursos y Registro N° 2",
            "Juzg. de la 1° Inst.de 26 Nominación en lo Civil y Comercial de Concursos y Socie" +
                "dades N° 2",
            "Civil y Comercial 4ta nominación",
            "Comercial N° 4, Secretaría N° 7",
            "Civil, Comercial y Especial N° 1",
            "Comercial N° 23, Secretaría N° 45",
            "Comercial N° 25, Secretaría N° 50",
            "Comercial N° 26, Secretaría N° 52",
            "Civil y Comercial 2 Nominación",
            "Civil y Com. 7 Nom., N° 4, Sec. 13",
            "Civil y Comercial 8va. nominación",
            "Comercial N° 22, Secretaría N° 44",
            "Comercial N° 15, Secretaría N° 29",
            "Comercial N° 25, Secretaría N° 50",
            "Comercial N° 7, Secretaría N° 14",
            "Comercial N° 20, Secretaría N° 39",
            "Comercial N° 5, Secretaría N° 9",
            "Civil y Comercial 3ra. nominación",
            "Comercial N° 3, Secretaría N° 5",
            "Comercial N° 26, Secretaría N° 52",
            "Civil y Comercial de la 2a Nominación",
            "Comercial N° 26, Secretaría N° 52",
            "Civil y Comercial 13 Nominación",
            "Comercial N° 9, Secretaría N° 17",
            "Comercial N° 2, Secretaría N° 4",
            "Civil y Comercial N° 4",
            "Comercial 23, Secretaría 45",
            "Comercial 16, Secretaría 32",
            "Comercial 13, Secretaría 26",
            "Comercial 18, Secretaría 35",
            "Comercial Nº 9, Secretaría 18",
            "Comercial 17, Secretaría 33",
            "Juzg. 1º Dist. De la 4ª Nom.",
            "Comercial 8, Secretaría 16",
            "Comercial 14, Secretaria 27",
            "Comercial 31, Secretaría 61"});
            this.cmbJuzg.Location = new System.Drawing.Point(95, 197);
            this.cmbJuzg.Name = "cmbJuzg";
            this.cmbJuzg.Size = new System.Drawing.Size(103, 21);
            this.cmbJuzg.TabIndex = 5;
            this.cmbJuzg.SelectedIndexChanged += new System.EventHandler(this.cmbJuzg_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(952, 392);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmRegistroDeProveedores
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 421);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbJuzg);
            this.Controls.Add(this.cmbJurisdiccion);
            this.Controls.Add(this.cmbLiquidador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApertura);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.dgvDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDeProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Proveedores";
            this.Load += new System.EventHandler(this.frmRegistroDeProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLiquidador;
        private System.Windows.Forms.ComboBox cmbJurisdiccion;
        private System.Windows.Forms.ComboBox cmbJuzg;
        private System.Windows.Forms.Button btnLimpiar;
    }
}