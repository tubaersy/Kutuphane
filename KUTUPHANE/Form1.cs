using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmKITAP frm1 = new frmKITAP();
            frm1.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmUYE frm2 = new frmUYE();
            frm2.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmODUNC frm3 = new frmODUNC();
            frm3.ShowDialog();
        }

        private void KitapListesiRaporuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKITAPLIST frm4 = new frmKITAPLIST();
            frm4.ShowDialog();
        }

        private void ÜyeListesiRaporuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUYELIST frm5 = new frmUYELIST();
            frm5.ShowDialog();
        }

        private void ÖdünçKitapListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmODUNCLIST frm6 = new frmODUNCLIST();
            frm6.ShowDialog();
        }

        private void KaçAdetKitapVerildiAlındıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKACADET frm7 = new frmKACADET();
            frm7.ShowDialog();
        }

        private void TarihlerArasıAlınanKtaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIKITARIH frm8 = new frmIKITARIH();
            frm8.ShowDialog();
        }
    }
}
