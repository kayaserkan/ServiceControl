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
    public partial class ServislerForm : Form
    {
        dbClass dbc = new dbClass();
        public ServislerForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MySqlCommand Command = new MySqlCommand("INSERT INTO servis (Sehir, FirmaAdi, Adres, Adres2, Telefon, CepTelefonu, Yetkili, MailAdresi) " +
            "VALUES(?,?,?,?,?,?,?,?)", dbc.Baglanti());

            Command.Parameters.AddWithValue("@P1", cbSehirSec.Text);
            Command.Parameters.AddWithValue("@P2", tbFirmaAdi.Text);
            Command.Parameters.AddWithValue("@P3", tbAdres.Text);
            Command.Parameters.AddWithValue("@P4", tbAdres2.Text);
            Command.Parameters.AddWithValue("@P5", tbTelefon.Text);
            Command.Parameters.AddWithValue("@P6", tbCepTelefonu.Text);
            Command.Parameters.AddWithValue("@P7", tbYetkili.Text);
            Command.Parameters.AddWithValue("@P8", tbMail.Text);

            Command.ExecuteNonQuery();
            dbc.Baglanti().Close();

            Guncelle();
        }

        private void Guncelle()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM servis", dbc.Baglanti()); 
            da.Fill(dt);
            gvServisler.DataSource = dt;
            dbc.Baglanti().Close();
        }

        private void ServislerForm_Load(object sender, EventArgs e)
        {
            Guncelle();
            //gridView1.OptionsView.ShowAutoFilterRow = true;// gridView de ilk satırda arama sütünu açıyor
        }

        private void cbSehirSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM servis where Sehir = '" + cbSehirSec.Text + "'", dbc.Baglanti());
            da.Fill(dt);
            gvServisler.DataSource = dt;
            dbc.Baglanti().Close();           
        }
    }
}