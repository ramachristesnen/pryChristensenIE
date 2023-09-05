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
    public partial class frmEscribirArchivos : Form
    {
        public frmEscribirArchivos()
        {
            InitializeComponent();
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            StreamWriter swArchivo = new StreamWriter("EJEMPLO", true);

            if (File.Exists("EJEMPLO") == true)
            {
                swArchivo.WriteLine(txtEscribir.Text);

                swArchivo.Close();
            }
        }
    }
}
