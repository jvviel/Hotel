using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            //frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuarto frmQt = new frmQuarto();
            //frmQt.MdiParent = this;
            frmQt.Show();
        }

        private void relatóToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmS = new frmSobre();
            //frmS.MdiParent = this;
            frmS.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void reservaDeQuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva frmRes = new frmReserva();
            //frmRes.MdiParent = this;
            frmRes.Show();
        }

        private void quartosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Relatorios.relatorioQuartos.impRelatorioQuartos();
        }

        private void quartosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.relatorioClientes.impRelatorioCliente();
        }
    }
}
