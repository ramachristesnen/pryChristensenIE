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
    public partial class frmLeerArchivos : Form
    {
        public frmLeerArchivos()
        {
            InitializeComponent();
        }

        private void lblLectura_Click(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //leer la carpeta y ver de utilizar un archivo

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.ShowDialog();

            StreamReader srArchivos = new StreamReader(openFileDialog.FileName.ToString());

            while (srArchivos.EndOfStream == false)
            {
                lblLectura.Text += srArchivos.ReadLine() + Environment.NewLine;
            }
        }
    }
}
