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
using DevExpress.XtraPrinting;

namespace ServisTakip
{
    public partial class RaporlarForm : Form
    {
        dbClass dbc = new dbClass();
        MySqlCommand FirmaAramaCommand;
        MySqlDataReader FirmaAramaReader;
        DataTable DtRaporlama = new DataTable();
        MySqlDataAdapter DaRaporlama;

        string firstDate = "", raporFirstDate = "";
        string lastDate = "", raporLastDate = "";

        bool telefonGoster;
        bool mailGoster;
        bool aksesuarGoster;
        bool kargoGoster;
        bool imalKoduGoster;

        double ucretsay;
        int cihazsayac, garantiIciSayac, garantiDisiSayac;
        int garantisayac;

        public RaporlarForm()
        {
            InitializeComponent();
        }
                
        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            MySqlCommand ModelSecCommand = new MySqlCommand("SELECT *FROM modeltablo", dbc.Baglanti());
            MySqlDataReader ModelSecReader = ModelSecCommand.ExecuteReader();

            while (ModelSecReader.Read())
            {
                cbModelSec.Items.Add(ModelSecReader["Model"]);
            }
            dbc.Baglanti().Close();
            cbModelSec.Sorted = true;

            MySqlCommand FirmaSecCommand = new MySqlCommand("SELECT *FROM firmakayittablo", dbc.Baglanti());
            MySqlDataReader FirmaSecReader = FirmaSecCommand.ExecuteReader();

            while (FirmaSecReader.Read())
            {
                cmbFirmaAdi.Items.Add(FirmaSecReader["FirmaAdi"]);
            }
            dbc.Baglanti().Close();
            cmbFirmaAdi.Sorted = true;

            telefonGoster = Properties.Settings.Default.RaporlarTelefonGoster;
            mailGoster = Properties.Settings.Default.RaporlarMailGoster;
            aksesuarGoster = Properties.Settings.Default.RaporlarAksesuarGoster;
            kargoGoster = Properties.Settings.Default.RaporlarKArgoUcretiGoster;
            imalKoduGoster = Properties.Settings.Default.RaporlarImalKoduGoster;
        }    
        
        #region Kayıtları Göster butonClick
        private void btnKayitGoster_Click(object sender, EventArgs e)
        {
            try
            {
                ucretsay = 0;
                string dtrstr;

                dbc.Baglanti();

                if (rbGirisTarihi.Checked == true)
                {
                    dtrstr = string.Format("SELECT * FROM kayittablo where FirmaAdi LIKE '%" + cmbFirmaAdi.Text + "%' AND  Model LIKE '%" + cbModelSec.Text + "%' AND GelisTarih BETWEEN '{0}' AND '{1}'", firstDate, lastDate);
                }
                else
                {
                    dtrstr = string.Format("SELECT * FROM kayittablo where FirmaAdi LIKE '%" + cmbFirmaAdi.Text + "%' AND  Model LIKE '%" + cbModelSec.Text + "%' AND CikisTarih BETWEEN '{0}' AND '{1}'", firstDate, lastDate);
                }

                DtRaporlama.Clear();
                DaRaporlama = new MySqlDataAdapter(dtrstr, dbc.Baglanti());
                DaRaporlama.Fill(DtRaporlama);
                dbc.Baglanti().Close();
                gridView1.OptionsSelection.MultiSelect = true;
                gridControl1.DataSource = DtRaporlama;
                gridView1.Columns[0].Visible = false;

                if (!telefonGoster)
                    gridView1.Columns[10].Visible = false;
                if (!mailGoster)
                    gridView1.Columns[18].Visible = false;
                if (!aksesuarGoster)
                    gridView1.Columns[8].Visible = false;
                if (!kargoGoster)
                    gridView1.Columns[17].Visible = false;
                if (!imalKoduGoster)
                    gridView1.Columns[5].Visible = false;

                for (int i = 0; i < DtRaporlama.Rows.Count; i++) // garanti dışı yapılan cihazların ücretleri hesaplanıyor
                {
                    if (DtRaporlama.Rows[i][13].ToString() == "")
                    {
                    }

                    else
                    {
                        ucretsay += Convert.ToDouble(DtRaporlama.Rows[i][13]);
                    }

                    if (DtRaporlama.Rows[i][14].ToString() == "GARANTİ İÇİ" || DtRaporlama.Rows[i][14].ToString() == "GARANTI IÇI" || DtRaporlama.Rows[i][14].ToString() == "GARANTI İCİ")
                    {
                        garantiIciSayac++;
                    }
                    else
                    {
                        garantiDisiSayac++;
                    }
                }
                gridView1.BestFitColumns(); // kolonları en uygun genişliğe ayarlıyor
                gridView1.OptionsView.ShowAutoFilterRow = true; // gridView de ilk satırda arama sütünu açıyor

                gridView1.Columns[1].Caption = "FİRMA ADI";
                gridView1.Columns[2].Caption = "MODEL";
                gridView1.Columns[3].Caption = "MODEL DETAY";
                gridView1.Columns[4].Caption = "SERİ NO";
                gridView1.Columns[6].Caption = "ŞİKAYET";
                gridView1.Columns[7].Caption = "FORM NO";
                gridView1.Columns[9].Caption = "GETİREN";
                gridView1.Columns[11].Caption = "GELİŞ TARİHİ";
                gridView1.Columns[12].Caption = "ÇIKIŞ TARİHİ";
                gridView1.Columns[13].Caption = "ÜCRET";
                gridView1.Columns[14].Caption = "GARANTİ DURUMU";
                gridView1.Columns[15].Caption = "YAPILAN İŞLEM";
                gridView1.Columns[16].Caption = "TEKNİSYEN"; 
                gridView1.Columns[19].Caption = "SÜRE";
                gridView1.Columns[20].Caption = "HATA";

                lblToplamUcret.Text = "TOPLAM = " + ucretsay.ToString() + " $ + KDV ";
                lblToplamUcret.Visible = true;
                lblCihazSayisi.Text = DtRaporlama.Rows.Count.ToString() + " ADET CİHAZ KAYIDI VARDIR";
                lblCihazSayisi.Visible = true;
                lblGarantiIci.Text = "G.İÇİ CİHAZ = " + garantiIciSayac.ToString() + " ADET";
                lblGarantiIci.Visible = true;
                lblGarantiDisi.Text = "G.DIŞI CİHAZ = " + garantiDisiSayac.ToString() + " ADET";
                lblGarantiDisi.Visible = true;
                garantiDisiSayac = garantiIciSayac = 0;


                MySqlCommand kullaniciCommand = new MySqlCommand("select count(*) as Kullanici from densi.kayittablo where hata ='KULLANICI' and gelistarih between '" + firstDate + "' and '" + lastDate + "';", dbc.Baglanti());
                MySqlDataReader kullaniciReader = kullaniciCommand.ExecuteReader();
                while (kullaniciReader.Read())
                {
                    lblKullanici.Text = "KULLANICI= " + kullaniciReader["Kullanici"].ToString();
                }
                lblKullanici.Visible = true;

                MySqlCommand uretimCommand = new MySqlCommand("select count(*) as Uretim from densi.kayittablo where hata ='ÜRETIM' and gelistarih between '" + firstDate + "' and '" + lastDate + "';", dbc.Baglanti());
                MySqlDataReader uretimReader = uretimCommand.ExecuteReader();
                while (uretimReader.Read())
                {
                    lblUretim.Text = "ÜRETİM= " + uretimReader["Uretim"].ToString();
                }
                lblUretim.Visible = true;

                MySqlCommand servisCommand = new MySqlCommand("select count(*) as Servis from densi.kayittablo where hata ='TEKNIK SERVIS' and gelistarih between '" + firstDate + "' and '" + lastDate + "';", dbc.Baglanti());
                MySqlDataReader servisReader = servisCommand.ExecuteReader();
                while (servisReader.Read())
                {
                    lblServis.Text = "SERVİS= " + servisReader["Servis"].ToString();
                }
                lblServis.Visible = true;

                MySqlCommand malzemeCommand = new MySqlCommand("select count(*) as Malzeme from densi.kayittablo where hata ='MALZEME' and gelistarih between '" + firstDate + "' and '" + lastDate + "';", dbc.Baglanti());
                MySqlDataReader malzemeReader = malzemeCommand.ExecuteReader();
                while (malzemeReader.Read())
                {
                    lblMalzeme.Text = "MALZEME= " + malzemeReader["malzeme"].ToString();
                }
                lblMalzeme.Visible = true;

                MySqlCommand ambalajCommand = new MySqlCommand("select count(*) as Ambalaj from densi.kayittablo where hata ='AMBALAJ' and gelistarih between '" + firstDate + "' and '" + lastDate + "';", dbc.Baglanti());
                MySqlDataReader ambalajReader = ambalajCommand.ExecuteReader();
                while (ambalajReader.Read())
                {
                    lblAmbalaj.Text = "AMBALAJ= " + ambalajReader["Ambalaj"].ToString();
                }
                lblAmbalaj.Visible = true;

                MySqlCommand digerCommand = new MySqlCommand("select count(*) as Diger from densi.kayittablo where hata ='DİGER' and gelistarih between '" + firstDate + "' and '" + lastDate + "';", dbc.Baglanti());
                MySqlDataReader digerReader = digerCommand.ExecuteReader();
                while (digerReader.Read())
                {
                    lblDiger.Text = "DİĞER= " + digerReader["Diger"].ToString();
                }
                lblDiger.Visible = true;

                dbc.Baglanti().Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void m_monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (firstDate == "")
            {
                firstDate = m_monthCalendar.ToString().Substring(59, 10);
                raporFirstDate = firstDate;
                string[] arr = firstDate.Split('.');
                DateTime dt = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]));
                firstDate = dt.ToString(@"yyyy/MM/dd").Replace('.', '/');
            }
            else if (lastDate == "")
            {
                lastDate = m_monthCalendar.ToString().Substring(59, 10); //Tarihler belirlenmek için calender den string alınıp sadece tarih kısmı ayıklanıyor
                raporLastDate = lastDate;
                string[] arr = lastDate.Split('.');
                DateTime dt = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0])); // + 1 bugünün raporunu verebilsin diye
                lastDate = dt.ToString(@"yyyy/MM/dd").Replace('.', '/');
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            firstDate = ""; lastDate = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //gridControl1.ShowRibbonPrintPreview();
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem()); // rapor önizleme sayfasında tarih aralığı yazdırmak için kullanılıyor
            link.Component = gridControl1;
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            PageInfoBrick baslikBrick = e.Graph.DrawPageInfo(PageInfo.UserName, "DENSİ ENDÜSTRİYEL TARTI SİSTEMLERİ ", Color.Black, new RectangleF(20, 20, 100, 20), BorderSide.None);
            baslikBrick.LineAlignment = BrickAlignment.Center;
            baslikBrick.Alignment = BrickAlignment.Center;
            baslikBrick.AutoWidth = true;

            // rapor önizleme sayfasında tarih aralığı yazdırmak için kullanılıyor
            PageInfoBrick brick = e.Graph.DrawPageInfo(PageInfo.DateTime, raporFirstDate + " / " + raporLastDate, Color.Black, new RectangleF(0, 0, 100, 20), BorderSide.None);
            brick.LineAlignment = BrickAlignment.Far;
            brick.Alignment = BrickAlignment.Far;
            brick.AutoWidth = true;
        }
    }
}
