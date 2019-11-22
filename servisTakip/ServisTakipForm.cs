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
using System.Xml;

namespace ServisTakip
{
    public partial class ServisTakipForm : Form
    {
        public ServisTakipForm()
        {
            InitializeComponent();
        }

        dbClass dbc = new dbClass();
        DataTable SearchDataTable = new DataTable();
        DataTable CompenantDataTable = new DataTable();
        int searchIndex = 0;
        string firstDate = "", lastDate = "";
        DateTime dt = new DateTime();
        public string str; Form1 f1 = new Form1();
        public string DolarSatis, kdvsiz, kdvli, firma, cihaz, serino;
        double kur, fiyat;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {                
                if (tbUcret != null)
                    tbUcret.Text = tbUcret.Text.Replace(',', '.');

                if (tbCikisTarihi.Text == "")
                {
                    MySqlCommand Command = new MySqlCommand("UPDATE kayittablo SET FirmaAdi = @P1, Model = @P2, ModelDetay = @P3, Sikayet = @P4, Aksesuar = @P5," +
                    "Telefon = @P6, Ucret = @P8, GarantiDurumu = @P9, YapilanIslem = @P10, Teknisyen = @P11, MailAdresi = @P12, tamirsuresi = @P13 WHERE FormNo = @P14", dbc.Baglanti());
                    Command.Parameters.AddWithValue("@P1", cmbFirmaAdi.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P2", cmbModel.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P3", tbModelDetay.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P4", tbSikayet.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P5", tbAksesuar.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P6", tbTelefon.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P8", tbUcret.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P9", cbGaranti.Text);
                    Command.Parameters.AddWithValue("@P10", tbYapilanIslem.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P11", cbTeknisyen.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P12", tbMail.Text.ToUpper());
                    if(tbSure.Text =="")
                    {
                        tbSure.Text = "0";
                    }
                    Command.Parameters.AddWithValue("@P13", tbSure.Text);
                    Command.Parameters.AddWithValue("@P14", tbFormNo.Text.ToUpper());
                    Command.ExecuteNonQuery();
                    dbc.Baglanti().Close();
                    MessageBox.Show("Kayıt Güncellendi!!!");
                }
                else
                {
                    MySqlCommand Command = new MySqlCommand("UPDATE kayittablo SET FirmaAdi = @P1, Model = @P2, ModelDetay = @P3, Sikayet = @P4, Aksesuar = @P5," +
                    "Telefon = @P6, CikisTarih = @P7, Ucret = @P8, GarantiDurumu = @P9, YapilanIslem = @P10, Teknisyen = @P11, MailAdresi = @P12, tamirsuresi = @P13 WHERE FormNo = @P14", dbc.Baglanti());
                    Command.Parameters.AddWithValue("@P1", cmbFirmaAdi.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P2", cmbModel.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P3", tbModelDetay.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P4", tbSikayet.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P5", tbAksesuar.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P6", tbTelefon.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P7", lastDate);//dt.Date.ToString("yyyy/MM/dd"));
                    Command.Parameters.AddWithValue("@P8", tbUcret.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P9", cbGaranti.Text);
                    Command.Parameters.AddWithValue("@P10", tbYapilanIslem.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P11", cbTeknisyen.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P12", tbMail.Text.ToUpper());
                    if (tbSure.Text == "")
                    {
                        tbSure.Text = "0";
                    }
                    Command.Parameters.AddWithValue("@P13", tbSure.Text);
                    Command.Parameters.AddWithValue("@P14", tbFormNo.Text.ToUpper());
                    Command.ExecuteNonQuery();
                    dbc.Baglanti().Close();
                    MessageBox.Show("Kayıt Güncellendi!!!");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                dbc.Baglanti().Close();
            }
        }

        #region arama işlemleri sırayla hücrelerin doluluğuna göre yapılıyor
        private void btnArama_Click(object sender, EventArgs e)
        {
            SearchDataTable.Clear();
            CompenantDataTable.Clear();
            try
            {
                if (cmbFirmaAdi.Text != "" && tbGelisTarihi.Text != "" && tbCikisTarihi.Text != "")
                {
                    if (firstDate == "")
                    {
                        firstDate = tbGelisTarihi.Text;
                        string[] arr = firstDate.Split('.');
                        DateTime dt = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]));
                        firstDate = dt.ToString(@"MM/dd/yyyy").Replace('.', '/');

                    }

                    if (lastDate == "")
                    {
                        lastDate = tbCikisTarihi.Text;
                        string[] arr = lastDate.Split('.');
                        DateTime dt = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]));
                        lastDate = dt.ToString(@"MM/dd/yyyy").Replace('.', '/');
                    }

                    string Command = string.Format("SELECT *FROM kayittablo WHERE FirmaAdi='" + cmbFirmaAdi.Text + "' AND GelisTarih BETWEEN #{0}# AND #{1}#", firstDate, lastDate);

                    MySqlDataAdapter da = new MySqlDataAdapter(Command, dbc.Baglanti());
                    da.Fill(SearchDataTable);
                    gcSearch.DataSource = SearchDataTable;

                    cmbFirmaAdi.Text = SearchDataTable.Rows[searchIndex][1].ToString();
                    cmbModel.Text = SearchDataTable.Rows[searchIndex][2].ToString();
                    tbModelDetay.Text = SearchDataTable.Rows[searchIndex][3].ToString();
                    tbSeriNo.Text = SearchDataTable.Rows[searchIndex][4].ToString();
                    tbImalKod.Text = SearchDataTable.Rows[searchIndex][5].ToString();
                    tbSikayet.Text = SearchDataTable.Rows[searchIndex][6].ToString();
                    tbFormNo.Text = SearchDataTable.Rows[searchIndex][7].ToString();
                    tbAksesuar.Text = SearchDataTable.Rows[searchIndex][8].ToString();
                    tbGetiren.Text = SearchDataTable.Rows[searchIndex][9].ToString();
                    tbTelefon.Text = SearchDataTable.Rows[searchIndex][10].ToString();
                    tbGelisTarihi.Text = SearchDataTable.Rows[searchIndex][11].ToString();//.ToString().Substring(0, 10);
                    tbCikisTarihi.Text = SearchDataTable.Rows[searchIndex][12].ToString();
                    tbUcret.Text = SearchDataTable.Rows[searchIndex][13].ToString();
                    cbGaranti.Text = SearchDataTable.Rows[searchIndex][14].ToString();
                    tbYapilanIslem.Text = SearchDataTable.Rows[searchIndex][15].ToString();
                    cbTeknisyen.Text = SearchDataTable.Rows[searchIndex][16].ToString();
                    tbKargo.Text = SearchDataTable.Rows[searchIndex][17].ToString();
                    tbMail.Text = SearchDataTable.Rows[searchIndex][18].ToString();
                    tbSure.Text = SearchDataTable.Rows[searchIndex][19].ToString();

                    string CompCommand = "SELECT * FROM " + cmbModel.Text;
                    MySqlDataAdapter dac = new MySqlDataAdapter(CompCommand, dbc.Baglanti());
                    dac.Fill(CompenantDataTable);
                    gcMalzeme.DataSource = CompenantDataTable;
                }

                else if (cmbFirmaAdi.Text != "" && cmbModel.Text != "" && tbSeriNo.Text != "")
                {
                    MySqlCommand Command = new MySqlCommand("SELECT * FROM kayittablo WHERE FirmaAdi = @P1 AND Model = @P2 AND SeriNo = @P3",dbc.Baglanti());
                    Command.Parameters.AddWithValue("@P1", cmbFirmaAdi.Text);
                    Command.Parameters.AddWithValue("@P2", cmbModel.Text.ToLower());
                    Command.Parameters.AddWithValue("@P3", tbSeriNo.Text);

                    DataTableFill(Command.CommandText);

                    cmbFirmaAdi.Text = SearchDataTable.Rows[searchIndex][1].ToString();
                    cmbModel.Text = SearchDataTable.Rows[searchIndex][2].ToString();
                    tbModelDetay.Text = SearchDataTable.Rows[searchIndex][3].ToString();
                    tbSeriNo.Text = SearchDataTable.Rows[searchIndex][4].ToString();
                    tbImalKod.Text = SearchDataTable.Rows[searchIndex][5].ToString();
                    tbSikayet.Text = SearchDataTable.Rows[searchIndex][6].ToString();
                    tbFormNo.Text = SearchDataTable.Rows[searchIndex][7].ToString();
                    tbAksesuar.Text = SearchDataTable.Rows[searchIndex][8].ToString();
                    tbGetiren.Text = SearchDataTable.Rows[searchIndex][9].ToString();
                    tbTelefon.Text = SearchDataTable.Rows[searchIndex][10].ToString();
                    tbGelisTarihi.Text = SearchDataTable.Rows[searchIndex][11].ToString();//.ToString().Substring(0, 10);
                    tbCikisTarihi.Text = SearchDataTable.Rows[searchIndex][12].ToString();
                    tbUcret.Text = SearchDataTable.Rows[searchIndex][13].ToString();
                    cbGaranti.Text = SearchDataTable.Rows[searchIndex][14].ToString();
                    tbYapilanIslem.Text = SearchDataTable.Rows[searchIndex][15].ToString();
                    cbTeknisyen.Text = SearchDataTable.Rows[searchIndex][16].ToString();
                    tbKargo.Text = SearchDataTable.Rows[searchIndex][17].ToString();
                    tbMail.Text = SearchDataTable.Rows[searchIndex][18].ToString();
                    tbSure.Text = SearchDataTable.Rows[searchIndex][19].ToString();

                    string CompCommand = "SELECT * FROM " + cmbModel.Text;
                    MySqlDataAdapter dac = new MySqlDataAdapter(CompCommand, dbc.Baglanti());
                    dac.Fill(CompenantDataTable);
                    gcMalzeme.DataSource = CompenantDataTable;
                }

                else if (tbFormNo.Text != "" && cmbFirmaAdi.Text != "")
                {
                    MySqlCommand Command = new MySqlCommand("SELECT * FROM kayittablo WHERE FirmaAdi = @P1  AND FormNo = @P2", dbc.Baglanti());
                    Command.Parameters.AddWithValue("@P1", cmbFirmaAdi.Text);
                    Command.Parameters.AddWithValue("@P2", tbFormNo);

                    DataTableFill(Command.CommandText);

                    cmbFirmaAdi.Text = SearchDataTable.Rows[searchIndex][1].ToString();
                    cmbModel.Text = SearchDataTable.Rows[searchIndex][2].ToString();
                    tbModelDetay.Text = SearchDataTable.Rows[searchIndex][3].ToString();
                    tbSeriNo.Text = SearchDataTable.Rows[searchIndex][4].ToString();
                    tbImalKod.Text = SearchDataTable.Rows[searchIndex][5].ToString();
                    tbSikayet.Text = SearchDataTable.Rows[searchIndex][6].ToString();
                    tbFormNo.Text = SearchDataTable.Rows[searchIndex][7].ToString();
                    tbAksesuar.Text = SearchDataTable.Rows[searchIndex][8].ToString();
                    tbGetiren.Text = SearchDataTable.Rows[searchIndex][9].ToString();
                    tbTelefon.Text = SearchDataTable.Rows[searchIndex][10].ToString();
                    tbGelisTarihi.Text = SearchDataTable.Rows[searchIndex][11].ToString();//.ToString().Substring(0, 10);
                    tbCikisTarihi.Text = SearchDataTable.Rows[searchIndex][12].ToString();
                    tbUcret.Text = SearchDataTable.Rows[searchIndex][13].ToString();
                    cbGaranti.Text = SearchDataTable.Rows[searchIndex][14].ToString();
                    tbYapilanIslem.Text = SearchDataTable.Rows[searchIndex][15].ToString();
                    cbTeknisyen.Text = SearchDataTable.Rows[searchIndex][16].ToString();
                    tbMail.Text = SearchDataTable.Rows[searchIndex][18].ToString();
                    tbKargo.Text = SearchDataTable.Rows[searchIndex][17].ToString();
                    tbSure.Text = SearchDataTable.Rows[searchIndex][19].ToString();

                    string CompCommand = "SELECT * FROM " + cmbModel.Text;
                    MySqlDataAdapter dac = new MySqlDataAdapter(CompCommand, dbc.Baglanti());
                    dac.Fill(CompenantDataTable);
                    gcMalzeme.DataSource = CompenantDataTable;
                }

                else if (tbFormNo.Text != "")
                {
                    string Command = "SELECT * FROM kayittablo WHERE FormNo = '" + tbFormNo.Text + "';";
                    
                    MySqlDataAdapter da = new MySqlDataAdapter(Command, dbc.Baglanti());
                    da.Fill(SearchDataTable);
                    gcSearch.DataSource = SearchDataTable;
                    
                    cmbFirmaAdi.Text = SearchDataTable.Rows[searchIndex][1].ToString();
                    cmbModel.Text = SearchDataTable.Rows[searchIndex][2].ToString();
                    tbModelDetay.Text = SearchDataTable.Rows[searchIndex][3].ToString();
                    tbSeriNo.Text = SearchDataTable.Rows[searchIndex][4].ToString();
                    tbImalKod.Text = SearchDataTable.Rows[searchIndex][5].ToString();
                    tbSikayet.Text = SearchDataTable.Rows[searchIndex][6].ToString();
                    tbFormNo.Text = SearchDataTable.Rows[searchIndex][7].ToString();
                    tbAksesuar.Text = SearchDataTable.Rows[searchIndex][8].ToString();
                    tbGetiren.Text = SearchDataTable.Rows[searchIndex][9].ToString();
                    tbTelefon.Text = SearchDataTable.Rows[searchIndex][10].ToString();
                    tbGelisTarihi.Text = SearchDataTable.Rows[searchIndex][11].ToString();//.Substring(0, 10);
                    tbCikisTarihi.Text = SearchDataTable.Rows[searchIndex][12].ToString();//.Substring(0, 10);
                    tbUcret.Text = SearchDataTable.Rows[searchIndex][13].ToString();
                    cbGaranti.Text = SearchDataTable.Rows[searchIndex][14].ToString();
                    tbYapilanIslem.Text = SearchDataTable.Rows[searchIndex][15].ToString();
                    cbTeknisyen.Text = SearchDataTable.Rows[searchIndex][16].ToString();
                    tbKargo.Text = SearchDataTable.Rows[searchIndex][17].ToString();
                    tbMail.Text = SearchDataTable.Rows[searchIndex][18].ToString();
                    tbSure.Text = SearchDataTable.Rows[searchIndex][19].ToString();

                    string CompCommand = "SELECT * FROM " + cmbModel.Text.ToLower();
                    MySqlDataAdapter dac = new MySqlDataAdapter(CompCommand, dbc.Baglanti());
                    dac.Fill(CompenantDataTable);
                    gcMalzeme.DataSource = CompenantDataTable;
                }

                else if (tbSeriNo.Text != "")
                {
                    //MySqlCommand Command = new MySqlCommand("SELECT * FROM kayittablo WHERE SeriNo = @P1", dbc.Baglanti());
                    //Command.Parameters.AddWithValue("@P1", tbSeriNo.Text);
                    //dbc.Baglanti().Close();

                    string Command = "SELECT * FROM kayittablo WHERE SeriNo = '" + tbSeriNo.Text + "';";
                    MySqlDataAdapter da = new MySqlDataAdapter(Command, dbc.Baglanti());
                    da.Fill(SearchDataTable);
                    gcSearch.DataSource = SearchDataTable;

                    cmbFirmaAdi.Text = SearchDataTable.Rows[searchIndex][1].ToString();
                    cmbModel.Text = SearchDataTable.Rows[searchIndex][2].ToString();
                    tbModelDetay.Text = SearchDataTable.Rows[searchIndex][3].ToString();
                    tbSeriNo.Text = SearchDataTable.Rows[searchIndex][4].ToString();
                    tbImalKod.Text = SearchDataTable.Rows[searchIndex][5].ToString();
                    tbSikayet.Text = SearchDataTable.Rows[searchIndex][6].ToString();
                    tbFormNo.Text = SearchDataTable.Rows[searchIndex][7].ToString();
                    tbAksesuar.Text = SearchDataTable.Rows[searchIndex][8].ToString();
                    tbGetiren.Text = SearchDataTable.Rows[searchIndex][9].ToString();
                    tbTelefon.Text = SearchDataTable.Rows[searchIndex][10].ToString();
                    tbGelisTarihi.Text = SearchDataTable.Rows[searchIndex][11].ToString();//.Substring(0, 10);
                    tbCikisTarihi.Text = SearchDataTable.Rows[searchIndex][12].ToString();
                    tbUcret.Text = SearchDataTable.Rows[searchIndex][13].ToString();
                    cbGaranti.Text = SearchDataTable.Rows[searchIndex][14].ToString();
                    tbYapilanIslem.Text = SearchDataTable.Rows[searchIndex][15].ToString();
                    cbTeknisyen.Text = SearchDataTable.Rows[searchIndex][16].ToString();
                    tbKargo.Text = SearchDataTable.Rows[searchIndex][17].ToString();
                    tbMail.Text = SearchDataTable.Rows[searchIndex][18].ToString();
                    tbSure.Text = SearchDataTable.Rows[searchIndex][19].ToString();
                    dbc.Baglanti().Close();

                    string CompCommand = "SELECT * FROM " + cmbModel.Text.ToLower();
                    MySqlDataAdapter dac = new MySqlDataAdapter(CompCommand, dbc.Baglanti());
                    dac.Fill(CompenantDataTable);
                    gcMalzeme.DataSource = CompenantDataTable;
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                dbc.Baglanti().Close();
                if (gcSearch.Visible )
                {
                    gridView1.Columns[0].Visible = Properties.Settings.Default.IdGoster;
                    gridView1.Columns[3].Visible = Properties.Settings.Default.ModelDetayGoster;
                    gridView1.Columns[18].Visible = Properties.Settings.Default.MailGoster;
                    gridView1.Columns[16].Visible = Properties.Settings.Default.TeknisyenGoster;
                    gridView1.Columns[9].Visible = Properties.Settings.Default.GetirenGoster;
                    gridView1.Columns[10].Visible = Properties.Settings.Default.TelefonGoster;
                    gridView1.Columns[5].Visible = Properties.Settings.Default.ImalKoduGoster;
                    gridView1.Columns[8].Visible = Properties.Settings.Default.AksesuarGoster;
                }

                else if (gcMalzeme.Visible)
                {
                    gridView2.Columns[3].Visible = Properties.Settings.Default.DolapNumarasiGoster;
                    gridView2.Columns[4].Visible = Properties.Settings.Default.SıraNumarasiGoster;
                    gridView2.Columns[5].Visible = Properties.Settings.Default.StokSayisiGoster;
                    gridView2.Columns[7].Visible = Properties.Settings.Default.TedarikciGoster;
                    gridView2.Columns[6].Visible = Properties.Settings.Default.KritikStokGoster;
                }
            }
        }
        #endregion
        public void DataTableFill(string komut)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(komut, dbc.Baglanti());
            da.Fill(SearchDataTable);
            gcSearch.DataSource = SearchDataTable;
        }
        public void CompDataTableFill(string komut)
        {
            
        }

        #region Formdaki hücreler temizleniyor
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbFirmaAdi.Text = "";
            cmbModel.SelectedIndex = -1;
            tbModelDetay.Text = "";
            tbSeriNo.Text = "";
            tbImalKod.Text = "";
            tbSikayet.Text = "";
            tbFormNo.Text = "";
            tbAksesuar.Text = "";
            tbGetiren.Text = "";
            tbTelefon.Text = "";
            tbGelisTarihi.Text = "";
            tbCikisTarihi.Text = "";
            tbUcret.Text = "";
            cbGaranti.Text = "";
            tbYapilanIslem.Text = "";
            cbTeknisyen.Text = "";
            tbKargo.Text = "";
            tbSure.Text = "";

            SearchDataTable.Clear();
        }
        #endregion
        private void ServisTakipForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            gcMalzeme.Visible = Properties.Settings.Default.MalzemeGoster;
            gcSearch.Visible = Properties.Settings.Default.KayitGoster;
            

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

            MySqlCommand TeknisyenCommand = new MySqlCommand("SELECT *FROM  teknisyen", dbc.Baglanti());
            MySqlDataReader TeknisyenDataReader = TeknisyenCommand.ExecuteReader();

            while (TeknisyenDataReader.Read())
            {
                cbTeknisyen.Items.Add(TeknisyenDataReader["teknisyen"]);
            }
            dbc.Baglanti().Close();
            cbTeknisyen.Sorted = true;
        }                
        private void tbCikisTarihi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lastDate = tbCikisTarihi.Text;
                string[] arr = lastDate.Split('.');
                DateTime dt = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]));
                lastDate = dt.ToString(@"yyyy/MM/dd").Replace('.', '/');
            }
            catch(Exception ex)
            {

            }
        }

        #region ShortCut Key ler tanımlanıyor
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.G | Keys.Control))
            {
                btnGuncelle.PerformClick();
                return true;
            }

            if (keyData == (Keys.S | Keys.Control))
            {
                btnArama.PerformClick();
                return true;
            }

            if (keyData == (Keys.T | Keys.Control))
            {
                btnTemizle.PerformClick();
                return true;
            }

            if (keyData == (Keys.F | Keys.Control))
            {
                tbFormNo.Focus();
                return true;
            }

            if (keyData == (Keys.Y | Keys.Control))
            {
                tbYapilanIslem.Focus();
                return true;
            }

            if (keyData == (Keys.U | Keys.Control))
            {
                simpleButton19.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
     
        #region Döviz kurları merkez bankası webservisinden çekiliyor
        void TCMBDovizKuruAl()
        {
            string today = "http://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            //string USD_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string USD_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            //string EURO_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            //string EURO_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            //DolarAlis = USD_Alis;
            DolarSatis = USD_Satis;
        }
        #endregion

        #region Döviz kuru bilgisi çekildikten sonra ücret kısmındaki buton eventi ile messagebox dan çıktı alınıyor
        private void simpleButton19_Click(object sender, EventArgs e)
        {
            if (tbUcret.Text == "")
            {
                MessageBox.Show("Dolar Cinsinden Fiyat Giriniz");
            }
            else
            {
                TCMBDovizKuruAl();
                kur = Convert.ToDouble(DolarSatis);
                fiyat = Convert.ToDouble(tbUcret.Text);
                kdvsiz = "    " + tbUcret.Text + " $       = " + (fiyat * kur).ToString("#.##") + " TL dir";
                kdvli = "KDV Dahil = " + (fiyat * kur * 1.18).ToString("#.##") + " TL dir";
            }
            MessageBox.Show(kdvsiz + '\n' + kdvli, "           HESAPLAMA");
        }
        #endregion

        #region seri numarasına göre arama yapıldıktan sonra listeleme yapılan gridview1 deki hücreler değiştirildikce ilgili kısımlarda bilgiler değiştiriliyor
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr["FirmaAdi"].ToString() != "")
                {
                    cmbFirmaAdi.Text = dr["FirmaAdi"].ToString();
                    cmbModel.Text = dr["Model"].ToString();
                    tbModelDetay.Text = dr["ModelDetay"].ToString();
                    tbSikayet.Text = dr["Sikayet"].ToString();
                    tbAksesuar.Text = dr["Aksesuar"].ToString();
                    tbGetiren.Text = dr["Getiren"].ToString();
                    tbGelisTarihi.Text = dr["GelisTarih"].ToString();
                    tbCikisTarihi.Text = dr["CikisTarih"].ToString();
                    cbGaranti.Text = dr["GarantiDurumu"].ToString();
                    tbUcret.Text = dr["Ucret"].ToString();
                    tbSeriNo.Text = dr["SeriNo"].ToString();
                    tbImalKod.Text = dr["ImalKodu"].ToString();
                    tbFormNo.Text = dr["FormNo"].ToString();
                    tbTelefon.Text = dr["Telefon"].ToString();
                    tbMail.Text = dr["MailAdresi"].ToString();
                    tbKargo.Text = dr["KargoUcreti"].ToString();
                    cbTeknisyen.Text = dr["Teknisyen"].ToString();
                    tbYapilanIslem.Text = dr["YapilanIslem"].ToString();
                }
            }
            catch(Exception ec)
            {

            }
        }
        #endregion

    }
}
