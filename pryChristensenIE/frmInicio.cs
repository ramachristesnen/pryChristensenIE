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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        

        private void frmInicio_Load(object sender, EventArgs e)
        {
            reloj.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (barraDeCarga.Value == 100)
            {
                //apago el reloj
                reloj.Enabled = false;
                this.Hide();
                frmPrincipal ventana = new frmPrincipal();
                ventana.ShowDialog();

            }
            else
            {
                barraDeCarga.Value += 5;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (barraDeCarga.Value == 100)
            {
                //apago el reloj
                reloj.Enabled = false;
                this.Hide();
                frmPrincipal ventana = new frmPrincipal();
                ventana.ShowDialog();

            }
            else
            {
                barraDeCarga.Value += 5;
            }
        }
    }
}