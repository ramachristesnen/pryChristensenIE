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
    public partial class frmRegistrarse : Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();

        }
        ClsBasedeDatos objAcceso = new ClsBasedeDatos();
        private void frmRegistrarse_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseña2.Text)
            {
                objAcceso.RegistroUsuarios(txtUsuario.Text, txtContraseña.Text);
                MessageBox.Show("Usuario registrado exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInicioDeSesion frm = new frmInicioDeSesion();
            frm.ShowDialog();
        }
    }
}
