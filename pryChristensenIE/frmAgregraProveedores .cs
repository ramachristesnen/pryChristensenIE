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
    public partial class frmAgregrarProveedores : Form
    {
        public frmAgregrarProveedores()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            StreamWriter swArchivo = new StreamWriter(txtNombreArchivo.Text, true);

            if (File.Exists(txtNombreArchivo.Text) == true)
            {
                MessageBox.Show("Archivo " + txtNombreArchivo.Text + " fue Creado");

                swArchivo.WriteLine("Ejemplo de escritura");

                swArchivo.Close();
            }

            //StreamWriter swArchivo = new StreamWriter("EJEMPLO", true);

            if (File.Exists("EJEMPLO"))
            {
                MessageBox.Show("Archivo Creado");

                swArchivo.WriteLine("Ejemplo de escritura");

               swArchivo.Close();
            }
        }
    }
}
