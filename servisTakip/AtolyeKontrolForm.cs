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
    public partial class AtolyeKontrolForm : Form
    {
        dbClass dbc = new dbClass();
        DataTable CihazDataTable = new DataTable();
        ServisTakipForm stf = new ServisTakipForm();
        public static Form1 f1 = new Form1();
        public static string firmaadi, sikayet, firma, cihaz;
                                         
        bool atolyeMAilAdresiGoster, atolyeKargoUcretiGoster;

        public static string aciklama;
        public AtolyeKontrolForm()
        {
            InitializeComponent();
        }
        private void btnCihazlariGoster_Click(object sender, EventArgs e)
        {
            CihazDataTable.Clear();
            int garantiici = 0; int garantidisi = 0; int yapilacakCihaz = 0;
            try
            {
                string Comamnd = "SELECT * FROM kayittablo WHERE cikistarih  IS NULL ORDER BY FirmaAdi ASC";
                MySqlDataAdapter da = new MySqlDataAdapter(Comamnd, dbc.Baglanti());
                da.Fill(CihazDataTable);
                GvAtolye.DataSource = CihazDataTable;

                gridView1.Columns[9].Visible = false;
                gridView1.Columns[10].Visible = false;
                gridView1.Columns[12].Visible = false;

                for (int i = 0; i < CihazDataTable.Rows.Count; i++)
                {
                    if (CihazDataTable.Rows[i][14].ToString() == "Garanti Dışı" || CihazDataTable.Rows[i][14].ToString() == "GARANTİ DIŞI" || CihazDataTable.Rows[i][14].ToString() == "GARANTI DISI")
                    {
                        garantidisi++;
                    }
                    else if (CihazDataTable.Rows[i][14].ToString() == "Garanti İçi" || CihazDataTable.Rows[i][14].ToString() == "GARANTİ İÇİ" || CihazDataTable.Rows[i][14].ToString() == "GARANTI ICI")
                    {
                        garantiici++;
                    }
                    else if (CihazDataTable.Rows[i][14].ToString() == "")
                    {
                        yapilacakCihaz++;
                    }
                }

                if (Properties.Settings.Default.CihazlariGoster == true)
                {
                    label1.Visible = true;
                    label1.Text = "ATÖLYEDEKİ CİHAZ SAYISI = " + CihazDataTable.Rows.Count.ToString();
                }
                else
                {
                    label1.Visible = false;

                }

                if (Properties.Settings.Default.GDisiCihazlar == true)
                {
                    label2.Visible = true;
                    label2.Text = "GARANTİ DIŞI = " + garantidisi.ToString();
                }
                else
                {
                    label2.Visible = false;

                }

                if (Properties.Settings.Default.GIciCihazlar == true)
                {
                    label3.Visible = true;
                    label3.Text = "GARANTİ İÇİ = " + garantiici.ToString();
                }
                else
                {
                    label3.Visible = false;

                }

                if (Properties.Settings.Default.Yapilacak == true)
                {
                    label4.Visible = true;
                    label4.Text = "YAPILACAK CİHAZ = " + yapilacakCihaz;
                }
                else
                {
                    label4.Visible = false;

                }

                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                dbc.Baglanti().Close();
                if (!atolyeKargoUcretiGoster)
                {
                    gridView1.Columns[17].Visible = false;
                }
                if (!atolyeMAilAdresiGoster)
                {
                    gridView1.Columns[18].Visible = false;
                }
            }
            //gridView1.BestFitColumns(); // kolonları en uygun genişliğe ayarlıyor
            gridView1.OptionsView.ShowAutoFilterRow = true;// gridView de ilk satırda arama sütünu açıyor
            gridView1.OptionsBehavior.Editable = true;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ServisTakipForm stf = new ServisTakipForm();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            firma = dr["FirmaAdi"].ToString();
            cihaz = dr["Model"].ToString();
            //MessageBox.Show(dr["SeriNo"].ToString() + dr["FirmaAdi"].ToString() + dr["Model"].ToString());
        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            //MessageBox.Show(dr["FirmaAdi"].ToString() + dr["Sikayet"].ToString());
            firmaadi = dr["FirmaAdi"].ToString();
            sikayet = dr["Sikayet"].ToString();
        }
        private void AtolyeKontrolForm_Load(object sender, EventArgs e)
        {
            atolyeKargoUcretiGoster = Properties.Settings.Default.AtolyeKargoUcretiGoster;
            atolyeMAilAdresiGoster = Properties.Settings.Default.AtolyeMailGoster;
        }        
    }
}