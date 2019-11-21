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
    public partial class AyarlarForm : Form
    {
        public AyarlarForm()
        {
            InitializeComponent();
        }

        dbClass dbc = new dbClass();

        private void AyarlarForm_Load(object sender, EventArgs e)
        {
            try
            {
                rbKayitlariGoster.Checked = Properties.Settings.Default.KayitGoster;
                rbMalzemeleriGoster.Checked = Properties.Settings.Default.MalzemeGoster;

                cbGetirenGoster.Checked = Properties.Settings.Default.MailYolla;
                cbCihazSayisi.Checked = Properties.Settings.Default.CihazlariGoster;
                cbGiciGoster.Checked = Properties.Settings.Default.GIciCihazlar;
                cbGdisiGoster.Checked = Properties.Settings.Default.GDisiCihazlar;
                cbYapilacak.Checked = Properties.Settings.Default.Yapilacak;
                cbGetirenGoster.Checked = Properties.Settings.Default.GetirenGoster;
                cbAksesuarGoster.Checked = Properties.Settings.Default.AksesuarGoster;
                cbMailGoster.Checked = Properties.Settings.Default.MailGoster;
                cbModelDetayGoster.Checked = Properties.Settings.Default.ModelDetayGoster;
                cbTeknisyenGoster.Checked = Properties.Settings.Default.TeknisyenGoster;
                cbTelefonGoster.Checked = Properties.Settings.Default.TelefonGoster;
                cbImalKodGoster.Checked = Properties.Settings.Default.ImalKoduGoster;
                cbDolapNumarasiGoster.Checked = Properties.Settings.Default.DolapNumarasiGoster;
                cbSiraNumarasi.Checked = Properties.Settings.Default.SıraNumarasiGoster;
                cbStokSayisiGoster.Checked = Properties.Settings.Default.StokSayisiGoster;
                cbTedarikci.Checked = Properties.Settings.Default.TedarikciGoster;
                cbKritikStokGoster.Checked = Properties.Settings.Default.KritikStokGoster;
                cbRaporAksesuarGoster.Checked = Properties.Settings.Default.RaporlarAksesuarGoster;
                cbRaporlarImalKoduGoster.Checked = Properties.Settings.Default.RaporlarImalKoduGoster;
                cbRaporlarKargoUcretiGoster.Checked = Properties.Settings.Default.RaporlarKArgoUcretiGoster;
                cbRaporlarMailGoster.Checked = Properties.Settings.Default.RaporlarMailGoster;
                cbRaporlarTelefonGoster.Checked = Properties.Settings.Default.RaporlarTelefonGoster;
                cbAtolyeMailGoster.Checked = Properties.Settings.Default.AtolyeMailGoster;
                cbAtolyeKatgoGoster.Checked = Properties.Settings.Default.AtolyeKargoUcretiGoster;

                MySqlCommand TeknisyenCommand = new MySqlCommand("SELECT *FROM  teknisyen", dbc.Baglanti());
                MySqlDataReader TeknisyenDataReader = TeknisyenCommand.ExecuteReader();

                while (TeknisyenDataReader.Read())
                {
                    cmbTeknisyen.Items.Add(TeknisyenDataReader["teknisyen"]);
                }
                dbc.Baglanti().Close();
                cmbTeknisyen.Sorted = true;
            }
            catch(Exception eayr)
            {

            }
        }            
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.KayitGoster = rbKayitlariGoster.Checked;
            Properties.Settings.Default.MalzemeGoster = rbMalzemeleriGoster.Checked;
            Properties.Settings.Default.MailYolla = cbGetirenGoster.Checked;

            Properties.Settings.Default.IdGoster = cbIdGoster.Checked;
            Properties.Settings.Default.AksesuarGoster = cbAksesuarGoster.Checked;
            Properties.Settings.Default.MailGoster = cbMailGoster.Checked;
            Properties.Settings.Default.ModelDetayGoster = cbModelDetayGoster.Checked;
            Properties.Settings.Default.TeknisyenGoster = cbTeknisyenGoster.Checked;
            Properties.Settings.Default.GetirenGoster = cbGetirenGoster.Checked;
            Properties.Settings.Default.TelefonGoster = cbTelefonGoster.Checked;
            Properties.Settings.Default.ImalKoduGoster = cbImalKodGoster.Checked;
            Properties.Settings.Default.DolapNumarasiGoster = cbDolapNumarasiGoster.Checked;
            Properties.Settings.Default.SıraNumarasiGoster = cbSiraNumarasi.Checked;
            Properties.Settings.Default.StokSayisiGoster = cbStokSayisiGoster.Checked;
            Properties.Settings.Default.TedarikciGoster = cbTedarikci.Checked;
            Properties.Settings.Default.KritikStokGoster = cbKritikStokGoster.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnAtolyeKontrolAyarlar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CihazlariGoster = cbCihazSayisi.Checked;
            Properties.Settings.Default.GIciCihazlar = cbGiciGoster.Checked;
            Properties.Settings.Default.GDisiCihazlar = cbGdisiGoster.Checked;
            Properties.Settings.Default.Yapilacak = cbYapilacak.Checked;
            Properties.Settings.Default.AtolyeKargoUcretiGoster = cbAtolyeKatgoGoster.Checked;
            Properties.Settings.Default.AtolyeMailGoster = cbAtolyeMailGoster.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnTeknisyenKaydet_Click(object sender, EventArgs e)
        {
            MySqlCommand TeknisyenEkleCommand  = new MySqlCommand("INSERT INTO teknisyen (teknisyen) VALUES (?)", dbc.Baglanti());
            TeknisyenEkleCommand.Parameters.AddWithValue("@P1", cmbTeknisyen.Text.ToUpper());
            TeknisyenEkleCommand.ExecuteNonQuery();
            MessageBox.Show("Teknisyen Eklendi!!!");
            cmbTeknisyen.Text = "";
        }

        private void btnTeknisyenSil_Click(object sender, EventArgs e)
        {
            MySqlCommand TeknisyenSilComamnd = new MySqlCommand("DELETE FROM teknisyen WHERE teknisyen = @P1", dbc.Baglanti());
            TeknisyenSilComamnd.Parameters.AddWithValue("@P1", cmbTeknisyen.Text);
            TeknisyenSilComamnd.ExecuteNonQuery();
            MessageBox.Show("Teknisyen Silindi!!!");
        }

        private void btnRaporlariKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RaporlarAksesuarGoster = cbRaporAksesuarGoster.Checked;
            Properties.Settings.Default.RaporlarImalKoduGoster = cbRaporlarImalKoduGoster.Checked;
            Properties.Settings.Default.RaporlarKArgoUcretiGoster = cbRaporlarKargoUcretiGoster.Checked;
            Properties.Settings.Default.RaporlarMailGoster = cbRaporlarMailGoster.Checked;
            Properties.Settings.Default.RaporlarTelefonGoster = cbRaporlarTelefonGoster.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnSunucuAyariKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DbAdi = tbDbAdi.Text;
            Properties.Settings.Default.DbIp = tbDbIp.Text;
            Properties.Settings.Default.DbKullaniciAdi = tbKullaniciAdi.Text;
            Properties.Settings.Default.DbKullaniciSifre = tbKullaniciSifre.Text;
            Properties.Settings.Default.Save();
        }
    }
}
