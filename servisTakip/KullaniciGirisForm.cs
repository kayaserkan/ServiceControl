using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ServisTakip
{
    public partial class KullaniciGirisForm : Form
    {
        dbClass dbc = new dbClass();
        string str;
        Form1 f1 = new Form1();
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            MySqlCommand kullanici = new MySqlCommand("SELECT * FROM kullanici WHERE kullaniciadi = '" + tbKullaniciAdi.Text + "' and kullanicisifre= '" + tbKullaniciSifre.Text + "'", dbc.Baglanti());
            MySqlDataReader dr = kullanici.ExecuteReader();

            if (dr.Read())
            {
               Properties.Settings.Default.KullaniciYetki = dr["kullaniciyetki"].ToString();
               Properties.Settings.Default.Save();
               this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI VEYA PAROLA", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void KullaniciGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void KullaniciGirisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
	}
}
