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
    public partial class frmGirisYap : Form
    {
        public frmGirisYap()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            if (true)
            {
                frmAracKiralama frmAracKiralama = new frmAracKiralama();
                frmAracKiralama.Show();
                this.Hide();
            }
        }
    }
}
