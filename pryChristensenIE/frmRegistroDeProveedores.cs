using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryChristensenIE
{
    public partial class frmRegistroDeProveedores : Form
    {
        StreamReader objetoLectorArchivo;
        StreamWriter objetoEscribeArchivo;
        string rutaArchivo;

        string leerLinea;
        string[] separadorTexto;
        public frmRegistroDeProveedores()
        {
            InitializeComponent();

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRegistroDeProveedores_Load(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\Archivos\\Listado de aseguradores.csv";

            objetoLectorArchivo = new StreamReader(rutaArchivo);

            while (!objetoLectorArchivo.EndOfStream)
            {
                leerLinea = objetoLectorArchivo.ReadLine();

                separadorTexto = leerLinea.Split(';');

               
                dgvDatos.Rows.Add(separadorTexto);
            }

            objetoLectorArchivo.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\Archivos\\Listado de aseguradores.csv";

            objetoEscribeArchivo = new StreamWriter(rutaArchivo, true);

            objetoEscribeArchivo.WriteLine(txtNumero.Text + ";" +
                txtEntidad.Text + ";" + txtApertura.Text + ";" +
                txtExpediente.Text + ";" + cmbJuzg + ";" +
                txtDireccion.Text + ";" + cmbJurisdiccion.Text + ";" + cmbLiquidador.Text);

            objetoEscribeArchivo.Close();

            MessageBox.Show("Registro realizado");
            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtExpediente.Clear();
            cmbJuzg.DataSource = null;
            txtDireccion.Clear();
            cmbJurisdiccion.DataSource = null;
            cmbLiquidador.DataSource = null;
        }
        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNumero.Text = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEntidad.Text = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApertura.Text = dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExpediente.Text = dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbJuzg.Text = dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbJurisdiccion.Text = dgvDatos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbLiquidador.Text = dgvDatos.Rows[e.RowIndex].Cells[7].Value.ToString();




        }

        private void txtJurisdiccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDatos.SelectedRows)
            {
                dgvDatos.Rows.Remove(row);
            }
        }

        private void cmbJuzg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
