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
    public partial class MalzemeForm : Form
    {
        dbClass dbc = new dbClass();
        MySqlCommand FirmaAramaCommand;
        MySqlDataReader FirmaAramaReader;
        DataTable DtRaporlama = new DataTable();
        MySqlDataAdapter DaRaporlama;

        double ucretsay;
        string firstDate, lastDate, raporFirstDate, raporLastDate;
        int garantiIciSayac, garantiDisiSayac;
        public MalzemeForm()
        {
            InitializeComponent();
        }

        private void MalzemeForm_Load(object sender, EventArgs e)
        {
            firstDate = ""; lastDate = "";
        }

        private void btnKayitGoster_Click(object sender, EventArgs e)
        {
            try
            {
                ucretsay = 0;
                string dtrstr;

                dbc.Baglanti();

                dtrstr = string.Format("SELECT * FROM yedekmalzeme where tarih BETWEEN '{0}' AND '{1}'", firstDate, lastDate);

                DtRaporlama.Clear();
                DaRaporlama = new MySqlDataAdapter(dtrstr, dbc.Baglanti());
                DaRaporlama.Fill(DtRaporlama);
                dbc.Baglanti().Close();
                gridView1.OptionsSelection.MultiSelect = true;
                gridControl1.DataSource = DtRaporlama;
                gridView1.Columns[0].Visible = false;

                for (int i = 0; i < DtRaporlama.Rows.Count; i++) // garanti dışı yapılan cihazların ücretleri hesaplanıyor
                {
                    if (DtRaporlama.Rows[i][13].ToString() == "")
                    {
                    }

                    else
                    {
                        ucretsay += Convert.ToDouble(DtRaporlama.Rows[i][13]);
                    }

                    //if (DtRaporlama.Rows[i][14].ToString() == "GARANTİ İÇİ" || DtRaporlama.Rows[i][14].ToString() == "GARANTI IÇI" || DtRaporlama.Rows[i][14].ToString() == "GARANTI İCİ")
                    //{
                    //    garantiIciSayac++;
                    //}
                    //else
                    //{
                    //    garantiDisiSayac++;
                    //}
                }

                gridView1.BestFitColumns(); // kolonları en uygun genişliğe ayarlıyor
                gridView1.OptionsView.ShowAutoFilterRow = true; // gridView de ilk satırda arama sütünu açıyor
                lblToplamUcret.Text = "TOPLAM = " + ucretsay.ToString() + " $ + KDV ";
                lblToplamUcret.Visible = true;
                lblCihazSayisi.Text = DtRaporlama.Rows.Count.ToString() + " ADET CİHAZ KAYIDI VARDIR";
                lblCihazSayisi.Visible = true;
                //lblGarantiIci.Text = "G.İÇİ CİHAZ = " + garantiIciSayac.ToString() + " ADET";
                //lblGarantiIci.Visible = true;
                //lblGarantiDisi.Text = "G.DIŞI CİHAZ = " + garantiDisiSayac.ToString() + " ADET";
                //lblGarantiDisi.Visible = true;
                garantiDisiSayac = garantiIciSayac = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            firstDate = lastDate = "";
        }

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
    }
}