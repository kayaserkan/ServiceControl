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
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }
        dbClass dbc = new dbClass();
       
        private void m_buttonRec_Click_1(object sender, EventArgs e)
        {
            if (cmbFirmaAdi.Text != "")
            {
                try
                {
                                        //Firma kayıt için ilgili tabloya insert komutu yollanıyor......
                    MySqlCommand Command = new MySqlCommand("INSERT INTO kayittablo(FirmaAdi, Model, ModelDetay, SeriNo, ImalKodu, Sikayet, FormNo, Aksesuar, Getiren, Telefon, GelisTarih, KargoUcreti, MailAdresi) VALUES(" +
                    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", dbc.Baglanti());
                    Command.Parameters.AddWithValue("@P1", cmbFirmaAdi.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P2", cmbModel.Text);
                    Command.Parameters.AddWithValue("@P3", tbModelDetay.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P4", tbSeriNo.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P5", tbImalKod.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P6", tbSikayet.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P7", tbFormNo.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P8", tbAksesuar.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P9", tbGetiren.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P10", tbTelefon.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P11", tbGelisTarihi.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P12", tbKargo.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P13", tbMail.Text);
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklendi!!!");
                    dbc.Baglanti().Close();

                    if(DateTime.Now.Month == 1)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'OCAK'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if(DateTime.Now.Month == 2)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'SUBAT'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 3)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'MART'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 4)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'NISAN'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 5)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'MAYIS'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 6)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'HAZIRAN'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 7)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'TEMMUZ'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 8)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'AGUSTOS'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 9)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'EYLUL'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 10)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'EKIM'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 11)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'KASIM'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    else if (DateTime.Now.Month == 12)
                    {
                        MySqlCommand ArizaEkleCommand = new MySqlCommand("UPDATE arizarapor SET " + cmbModel.Text + " =" + cmbModel.Text + " + 1 WHERE YIL = " + DateTime.Today.Year.ToString() + " and AY = 'ARALIK'", dbc.Baglanti());
                        ArizaEkleCommand.ExecuteNonQuery();
                    }
                    dbc.Baglanti().Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dbc.Baglanti().Close();
                }
            }
        }
        private void KayitForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            
            DateTime dt = DateTime.Today;
            tbGelisTarihi.Text = dt.Date.ToString("yyyy/MM/dd");

            cmbModel.Items.Clear();
            try
            {
                MySqlCommand ModelSecCommand = new MySqlCommand("SELECT *FROM modeltablo", dbc.Baglanti());
                MySqlDataReader ModelSecReader = ModelSecCommand.ExecuteReader();

                while (ModelSecReader.Read())
                {
                    cmbModel.Items.Add(ModelSecReader["Model"]);
                }
                dbc.Baglanti().Close();
                cmbModel.Sorted = true;

                MySqlCommand FirmaSecCommand = new MySqlCommand("SELECT *FROM firmakayittablo", dbc.Baglanti());
                MySqlDataReader FirmaSecReader = FirmaSecCommand.ExecuteReader();

                while (FirmaSecReader.Read())
                {
                    cmbFirmaAdi.Items.Add(FirmaSecReader["FirmaAdi"]);
                }
                dbc.Baglanti().Close();
                cmbFirmaAdi.Sorted = true;
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmbFirmaAdi_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            tbModelDetay.Text = "";
            cmbFirmaAdi.Text = "";
            tbSikayet.Text = "";
            tbAksesuar.Text = "";
            tbGetiren.Text = "";
            tbSeriNo.Text = "";
            tbImalKod.Text = "";
            tbFormNo.Text = "";
            tbTelefon.Text = "";
            tbMail.Text = "";
            tbKargo.Text = "";
            cmbModel.Text = "";

        }
        #region ShortCut Key ler tanımlanıyor
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.K | Keys.Control))
            {
                m_buttonRec.PerformClick();
                return true;
            }

            if (keyData == (Keys.T | Keys.Control))
            {
                simpleButton14.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Today.Year.ToString() + " and AY = " + DateTime.Now.Month.ToString());
        }
    }
}
