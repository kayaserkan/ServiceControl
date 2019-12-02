using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakip
{
    public partial class SebepForm : Form
    {
        public SebepForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(rbDiger.Checked == true)
                Properties.Settings.Default.ArizaSebebi = "DİĞER";
            else if (rbUretim.Checked == true)
                Properties.Settings.Default.ArizaSebebi = "ÜRETİM";
            else if (rbTeknikServis.Checked == true)
                Properties.Settings.Default.ArizaSebebi = "TEKNİK SERVİS";
            else if (rbMalzeme.Checked == true)
                Properties.Settings.Default.ArizaSebebi = "MALZEME";
            else if (rbKullanici.Checked == true)
                Properties.Settings.Default.ArizaSebebi = "KULLANICI";
            else if(rbAmbalaj.Checked == true)
                Properties.Settings.Default.ArizaSebebi = "AMBALAJ";
            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
