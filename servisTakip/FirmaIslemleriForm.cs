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
    public partial class FirmaIslemleriForm : Form
    {
        public FirmaIslemleriForm()
        {
            InitializeComponent();
        }
        dbClass dbc = new dbClass();
        int id;
        private void FirmaIslemleriForm_Load(object sender, EventArgs e)
        {
            Guncelle();
            gridView1.OptionsView.ShowAutoFilterRow = true;// gridView de ilk satırda arama sütünu açıyor
            gridView1.OptionsBehavior.Editable = true;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand Command = new MySqlCommand("INSERT INTO firmakayittablo (FirmaAdi, Adres1, Adres2, Adres3, Telefon1, Telefon2, Yetkili, Email, Statu) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?)", dbc.Baglanti());
                Command.Parameters.AddWithValue("@P1", tbFirmaAdi.Text);
                Command.Parameters.AddWithValue("@P2", tbAdres1.Text);
                Command.Parameters.AddWithValue("@P3", tbAdres2.Text);
                Command.Parameters.AddWithValue("@P4", tbAdres3.Text);
                Command.Parameters.AddWithValue("@P5", tbTelefon.Text);
                Command.Parameters.AddWithValue("@P6", tbTelefon2.Text);
                Command.Parameters.AddWithValue("@P7", tbYetkili.Text);
                Command.Parameters.AddWithValue("@P8", tbMail.Text);
                Command.Parameters.AddWithValue("@P9", tbStatu.Text);
                Command.ExecuteNonQuery();
                dbc.Baglanti().Close();
                MessageBox.Show("Firma Eklendi!!!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                dbc.Baglanti().Close();
                Guncelle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr["FirmaAdi"].ToString() != "")
            {
                id = Convert.ToInt16(dr["ID"].ToString());
                tbFirmaAdi.Text = dr["FirmaAdi"].ToString();
                tbAdres1.Text = dr["Adres1"].ToString();
                tbAdres2.Text = dr["Adres2"].ToString();
                tbAdres3.Text = dr["Adres3"].ToString();
                tbTelefon.Text = dr["Telefon1"].ToString();
                tbTelefon2.Text = dr["Telefon2"].ToString();
                tbYetkili.Text = dr["Yetkili"].ToString();
                tbMail.Text = dr["Email"].ToString();
                tbStatu.Text = dr["Statu"].ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand Command = new MySqlCommand("UPDATE firmakayittablo SET FirmaAdi = @P1, Adres1 = @P2, Adres2 = @P3, Adres3 = @P4, Telefon1 = @P5," +
                "Telefon2 = @P6, Yetkili = @P7, Email = @P8, Statu = @P9 WHERE ID = @P10", dbc.Baglanti());
                Command.Parameters.AddWithValue("@P1", tbFirmaAdi.Text);
                Command.Parameters.AddWithValue("@P2", tbAdres1.Text);
                Command.Parameters.AddWithValue("@P3", tbAdres2.Text);
                Command.Parameters.AddWithValue("@P4", tbAdres3.Text);
                Command.Parameters.AddWithValue("@P5", tbTelefon.Text);
                Command.Parameters.AddWithValue("@P6", tbTelefon2.Text);
                Command.Parameters.AddWithValue("@P7", tbYetkili.Text);
                Command.Parameters.AddWithValue("@P8", tbMail.Text);
                Command.Parameters.AddWithValue("@P9", tbStatu.Text);
                Command.Parameters.AddWithValue("@P10", id);
                Command.ExecuteNonQuery();
                dbc.Baglanti().Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                dbc.Baglanti().Close();
                Guncelle();
            }
        }

        public void Guncelle()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM firmakayittablo", dbc.Baglanti());         
            da.Fill(dt);
            gvKayitliFirmalar.DataSource = dt;
            dbc.Baglanti().Close();
            id = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand Command = new MySqlCommand("DELETE FROM firmakayittablo WHERE ID = @P1", dbc.Baglanti());
                Command.Parameters.AddWithValue("@P1", id);
                Command.ExecuteNonQuery();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                dbc.Baglanti().Close();
                Guncelle();
            }
        }
    }
}
