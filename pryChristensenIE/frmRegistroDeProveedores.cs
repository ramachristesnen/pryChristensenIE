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

            rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";

            objetoLectorArchivo = new StreamReader(rutaArchivo);

            while (!objetoLectorArchivo.EndOfStream)
            {
                leerLinea = objetoLectorArchivo.ReadLine();

                separadorTexto = leerLinea.Split(';');

                //lblDatos.Text+=objetoLectorArchivo.ReadLine();
                dgvDatos.Rows.Add(separadorTexto);
            }

            objetoLectorArchivo.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";

            objetoEscribeArchivo = new StreamWriter(rutaArchivo, true);

            objetoEscribeArchivo.WriteLine(txtApertura.Text + ";" +
                txtEntidad.Text + ";" + txtExpediente.Text + ";" +
                txtNumero.Text + ";" + txtDireccion + ";" +
                txtJuzg + ";" + txtJurisdiccion + ";" + txtLiquidador);

            objetoEscribeArchivo.Close();

            MessageBox.Show("Registro realizado");
        }
        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            txtEntidad.Text = dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtApertura.Text = dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtExpediente.Text = dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNumero.Text = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtJuzg.Text = dgvDatos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtJurisdiccion.Text = dgvDatos.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtLiquidador.Text = dgvDatos.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
