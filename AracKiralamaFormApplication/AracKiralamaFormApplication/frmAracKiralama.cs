using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaFormApplication
{
    public partial class frmAracKiralama : Form
    {
        public frmAracKiralama()
        {
            InitializeComponent();
        }

        private void isteklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIstek frmIstek = new frmIstek();
            if (Application.OpenForms["frmIstek"] == null)
            {
                frmIstek.WindowState = FormWindowState.Maximized;
                frmIstek.MdiParent = this;
                frmIstek.Show();
            }
        }

        private void kiralanabilirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKiralanabilirAraclar frmKiralanabilirAraclar = new frmKiralanabilirAraclar();
            if (Application.OpenForms["frmKiralanabilirAraclar"] == null)
            {
                frmKiralanabilirAraclar.WindowState = FormWindowState.Maximized;
                frmKiralanabilirAraclar.MdiParent = this;
                frmKiralanabilirAraclar.Show();
            }
        }

        private void kiralanmışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKiralanmisAraclar frmKiralanmisAraclar = new frmKiralanmisAraclar();
            if (Application.OpenForms["frmKiralanmisAraclar"] == null)
            {
                frmKiralanmisAraclar.WindowState = FormWindowState.Maximized;
                frmKiralanmisAraclar.MdiParent = this;
                frmKiralanmisAraclar.Show();
            }
        }

        private void araçKiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracKiralamaIslemi frmAracKiralamaIslemi = new frmAracKiralamaIslemi();
            if (Application.OpenForms["frmAracKiralamaIslemi"] == null)
            {
                frmAracKiralamaIslemi.WindowState = FormWindowState.Maximized;
                frmAracKiralamaIslemi.MdiParent = this;
                frmAracKiralamaIslemi.Show();
            }
        }

        private void frmAracKiralama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
