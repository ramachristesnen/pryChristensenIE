using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryChristensenIE
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroDeProveedores registroDeProveedores = new frmRegistroDeProveedores();        
            registroDeProveedores.ShowDialog();
        }

        private void archivoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivoDeProveedores archivoDeProveedores = new frmArchivoDeProveedores();       
            archivoDeProveedores.ShowDialog();
        }
    }
}
