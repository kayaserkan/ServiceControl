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
using DevExpress.XtraGrid.Views.Grid;

namespace ServisTakip
{
    public partial class CikisYapilacak : Form
    {
        public string firmaAdi;
        public string sehir;
        public string[] malzemeAdi;
        public string fiyat, tepDate;
        string trh;
        int Satir;
        public CikisYapilacak()
        {
            InitializeComponent();
            Temizle();
        }

        dbClass dbc = new dbClass();

        private void btnSiparisGir_Click(object sender, EventArgs e)
        {
            if (tbFirmaAdi.Text != "")
            {
                try
                {
                    //Firma kayıt için ilgili tabloya insert komutu yollanıyor......
                    MySqlCommand Command = new MySqlCommand("INSERT INTO yedekmalzeme(siparisverenfirma, sehir, malzeme1, malzeme1fiyat, malzeme2, malzeme2fiyat, malzeme3, malzeme3fiyat, malzeme4, malzeme4fiyat, malzeme5, malzeme5fiyat, toplamfiyat, tarih, kargo, iskonto) VALUES(" +
                    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", dbc.Baglanti());
                    Command.Parameters.AddWithValue("@P1", tbFirmaAdi.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P2", tbSehir.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P3", tbMalzeme1.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P4", Convert.ToDouble(tbMalzeme1Fiyat.Text));
                    Command.Parameters.AddWithValue("@P5", tbMalzeme2.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P6", Convert.ToDouble(tbMalzeme2Fiyat.Text));
                    Command.Parameters.AddWithValue("@P7", tbMalzeme3.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P8", Convert.ToDouble(tbMalzeme3Fiyat.Text));
                    Command.Parameters.AddWithValue("@P9", tbMalzeme4.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P10", Convert.ToDouble(tbMalzeme4Fiyat.Text));
                    Command.Parameters.AddWithValue("@P11", tbMalzeme5.Text.ToUpper());
                    Command.Parameters.AddWithValue("@P12", Convert.ToDouble(tbMalzeme5Fiyat.Text));
                    
                    if(rbIskontoYirmi.Checked == true)
                    {
                        Command.Parameters.AddWithValue("@P13", fiyattopla() - ((fiyattopla() / 100 ) * 20));
                    }
                    else if (rbIskontoYok.Checked == true)
                    {
                        Command.Parameters.AddWithValue("@P13", fiyattopla());
                    }

                    else if (rbIskontoOn.Checked == true)
                    {
                        Command.Parameters.AddWithValue("@P13", fiyattopla() - ((fiyattopla() / 100) * 10));
                    }
                    else if (rbIskontoOtuz.Checked == true)
                    {
                        Command.Parameters.AddWithValue("@P13", fiyattopla() - ((fiyattopla() / 100) * 30));
                    }

                    Command.Parameters.AddWithValue("@P14", tepDate);
                    
                    //kargo bilgisi 
                    if (cbKargo.Checked == true)
                        Command.Parameters.AddWithValue("@P15", true);
                    else
                        Command.Parameters.AddWithValue("@P15", false);


                    // iskonto kısmı seçili olan değere göre gridview e yazılıyor
                    if (rbIskontoYirmi.Checked == true)
                    {
                        Command.Parameters.AddWithValue("@P16", 20);
                    }
                    else if (rbIskontoYok.Checked == true)
                    {
                        Command.Parameters.AddWithValue("@P16", 0);
                    }

                    else if (rbIskontoOn.Checked == true)
                    {
                        Command.Parameters.AddWithValue("@P16",  10);
                    }
                    else if (rbIskontoOtuz.Checked == true)
                    {
                        Command.Parameters.AddWithValue("@P16", 30);
                            
                    }

                    Command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklendi!!!");
                    dbc.Baglanti().Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dbc.Baglanti().Close();
                    MalzemeTablosuGuncelle();
                }
            }
        }

        public double fiyattopla() // iskonto hesabını yapmak için kullanılan fonksiyon
        {
            double toplamfiyat = Convert.ToDouble(tbMalzeme1Fiyat.Text) + Convert.ToDouble(tbMalzeme2Fiyat.Text) +
                Convert.ToDouble(tbMalzeme3Fiyat.Text) + Convert.ToDouble(tbMalzeme4Fiyat.Text) + Convert.ToDouble(tbMalzeme5Fiyat.Text);
            return toplamfiyat;
        }

        private void CikisYapilacak_Load(object sender, EventArgs e)
        {
             DateTime dt = DateTime.Today;
             trh = dt.Date.ToString("yyyy/MM/dd");
             rbIskontoYirmi.Checked = true;
             DateChange();
        }

        public void MalzemeTablosuGuncelle()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM yedekmalzeme WHERE tarih = '" + tepDate + "'", dbc.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            dbc.Baglanti().Close();

            dataGridViewMalzemeListesi.Columns[0].Visible = false;
            dataGridViewMalzemeListesi.Columns[1].Caption = "FİRMA ADI";
            dataGridViewMalzemeListesi.Columns[2].Caption = "ŞEHİR";
            dataGridViewMalzemeListesi.Columns[3].Caption = "SİPARİŞ";
            dataGridViewMalzemeListesi.Columns[4].Caption = "FİYAT";
            dataGridViewMalzemeListesi.Columns[5].Caption = "SİPARİŞ";
            dataGridViewMalzemeListesi.Columns[6].Caption = "FİYAT";
            dataGridViewMalzemeListesi.Columns[7].Caption = "SİPARİŞ";
            dataGridViewMalzemeListesi.Columns[8].Caption = "FİYAT";
            dataGridViewMalzemeListesi.Columns[9].Caption = "SİPARİŞ";
            dataGridViewMalzemeListesi.Columns[10].Caption = "FİYAT";
            dataGridViewMalzemeListesi.Columns[11].Caption = "SİPARİŞ";
            dataGridViewMalzemeListesi.Columns[12].Caption = "FİYAT";
            dataGridViewMalzemeListesi.Columns[13].Caption = "TOPLAM";
            dataGridViewMalzemeListesi.Columns[14].Caption = "TARİH";
            dataGridViewMalzemeListesi.Columns[15].Caption = "İSKONTO";
            dataGridViewMalzemeListesi.Columns[16].Caption = "KARGO";



            dataGridViewMalzemeListesi.Columns[3].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[4].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[5].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[6].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[7].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[8].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[9].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[10].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[11].AppearanceCell.BackColor = Color.LightCyan;
            dataGridViewMalzemeListesi.Columns[12].AppearanceCell.BackColor = Color.LightCyan;

            Temizle();
            
            //for(int i = 0; i<dt.Rows.Count-1; i++)
            //{
            //    if (dt.Rows[i][15].ToString() != "0")
            //        dataGridViewMalzemeListesi.RowStyle
            //}
        }
        
        public void Temizle()
        {
            tbFirmaAdi.Text = "";
            tbSehir.Text = "";
            tbMalzeme1.Text = "";
            tbMalzeme1Fiyat.Text = "0";
            tbMalzeme2.Text = "";
            tbMalzeme2Fiyat.Text = "0";
            tbMalzeme3.Text = "";
            tbMalzeme3Fiyat.Text = "0";
            tbMalzeme4.Text = "";
            tbMalzeme4Fiyat.Text = "0";
            tbMalzeme5.Text = "";
            tbMalzeme5Fiyat.Text = "0";
            tbToplamFiyat.Text = "0";
        }

        private void dataGridViewMalzemeListesi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = dataGridViewMalzemeListesi.GetDataRow(dataGridViewMalzemeListesi.FocusedRowHandle);
                if (dr["siparisverenfirma"].ToString() != "")
                {
                    Satir = Convert.ToInt16(dr["id"]);
                    tbFirmaAdi.Text = dr["siparisverenfirma"].ToString();
                    tbSehir.Text = dr["sehir"].ToString();
                    tbMalzeme1.Text = dr["malzeme1"].ToString();
                    tbMalzeme1Fiyat.Text = dr["malzeme1fiyat"].ToString();
                    tbMalzeme2.Text = dr["malzeme2"].ToString();
                    tbMalzeme2Fiyat.Text = dr["malzeme2fiyat"].ToString();
                    tbMalzeme3.Text = dr["malzeme3"].ToString();
                    tbMalzeme3Fiyat.Text = dr["malzeme3fiyat"].ToString();
                    tbMalzeme4.Text = dr["malzeme4"].ToString();
                    tbMalzeme4Fiyat.Text = dr["malzeme4fiyat"].ToString();
                    tbMalzeme5.Text = dr["malzeme5"].ToString();
                    tbMalzeme5Fiyat.Text = dr["malzeme5fiyat"].ToString();
                    tbToplamFiyat.Text = dr["toplamfiyat"].ToString();
                }
            }

            catch(Exception ec)
            {

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateChange();
        }
        public void DateChange()
        {
            tepDate = monthCalendar1.ToString().Substring(59, 10);
            string[] arr = tepDate.Split('.');
            DateTime dt = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]));
            tepDate = dt.ToString(@"yyyy/MM/dd").Replace('.', '/');
            MalzemeTablosuGuncelle();
        }

        private void dataGridViewMalzemeListesi_RowStyle_1(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["kargo"]);
                if (category != "0")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                    e.HighPriority = true;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand Command = new MySqlCommand("DELETE FROM yedekmalzeme where id = @P1", dbc.Baglanti());

                Command.Parameters.AddWithValue("@P1", Satir);
                Command.ExecuteNonQuery();
                MalzemeTablosuGuncelle();
            }
            catch(Exception ec)
            {

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand Command = new MySqlCommand("UPDATE yedekmalzeme SET siparisverenfirma = @P1, sehir = @P2, malzeme1 = @P3, malzeme1fiyat = @P4," +
                   "malzeme2 = @P5, malzeme2fiyat = @P6, malzeme3 = @P7, malzeme3fiyat = @P8, malzeme4 = @P9, malzeme4fiyat = @P10, malzeme5 = @P11, malzeme5fiyat = @P12" +
                   ", toplamfiyat = @P13, kargo = @P15 WHERE id = @P16", dbc.Baglanti());

                Command.Parameters.AddWithValue("@P1", tbFirmaAdi.Text.ToUpper());
                Command.Parameters.AddWithValue("@P2", tbSehir.Text.ToUpper());
                Command.Parameters.AddWithValue("@P3", tbMalzeme1.Text.ToUpper());
                Command.Parameters.AddWithValue("@P4", tbMalzeme1Fiyat.Text);
                Command.Parameters.AddWithValue("@P5", tbMalzeme2.Text.ToUpper());
                Command.Parameters.AddWithValue("@P6", tbMalzeme2Fiyat.Text);
                Command.Parameters.AddWithValue("@P7", tbMalzeme3.Text.ToUpper());
                Command.Parameters.AddWithValue("@P8", tbMalzeme3Fiyat.Text);
                Command.Parameters.AddWithValue("@P9", tbMalzeme4.Text.ToUpper());
                Command.Parameters.AddWithValue("@P10", tbMalzeme4Fiyat.Text);
                Command.Parameters.AddWithValue("@P11", tbMalzeme5.Text.ToUpper());
                Command.Parameters.AddWithValue("@P12", tbMalzeme5Fiyat.Text);
                Command.Parameters.AddWithValue("@P13", tbToplamFiyat.Text);
               
                if (cbKargo.Checked == true)
                    Command.Parameters.AddWithValue("@P15", true);
                else
                    Command.Parameters.AddWithValue("@P15", false);

                Command.Parameters.AddWithValue("@P16", Satir);
                Command.ExecuteNonQuery();

                MessageBox.Show("Kayıt Eklendi!!!");
                dbc.Baglanti().Close();
            }
            catch(Exception ec)
            {

            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            MalzemeTablosuGuncelle();
        }
    }
}
