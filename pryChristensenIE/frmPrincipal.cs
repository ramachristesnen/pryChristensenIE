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

        private void agregarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregrarProveedores frmAgregrarProveedores = new frmAgregrarProveedores();   
            frmAgregrarProveedores.ShowDialog();    
        }

        private void leerArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeerArchivos frmLeerArchivos = new frmLeerArchivos();    
            frmLeerArchivos.ShowDialog();   
        }

        private void escribirArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmEscribirArchivos frmEscribirArchivos = new frmEscribirArchivos();     
           frmEscribirArchivos.ShowDialog();
        }
    }
}
