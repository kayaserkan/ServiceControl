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
    public partial class MalzemeIslemleriForm : Form
    {
        dbClass dbc = new dbClass();
        DataTable dtMalzmemeDoldur;
        DataTable dt;

        public MalzemeIslemleriForm()
        {
            InitializeComponent();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            MySqlCommand Command = new MySqlCommand("INSERT INTO modeltablo (Model) VALUES (?); ", dbc.Baglanti());
            Command.Parameters.AddWithValue("@P1", tbModelEkle.Text.ToLower());
            Command.ExecuteNonQuery();

            if (tbModelEkle.Text != "")
            {
                MySqlCommand ModelEkle = new MySqlCommand("create table if not exists " + tbModelEkle.Text.ToLower() + " like pc100;", dbc.Baglanti());
                ModelEkle.ExecuteNonQuery();
                MySqlCommand MysqlArizaTabloModelEkle = new MySqlCommand("ALTER TABLE `densi`.`arizarapor` ADD  `" + tbModelEkle.Text.ToLower() + "` INT null", dbc.Baglanti());
                MysqlArizaTabloModelEkle.ExecuteNonQuery();
            }
        }

        private void MalzemeIslemleriForm_Load(object sender, EventArgs e)
        {
            MySqlCommand modelDoldurCommand = new MySqlCommand("SELECT *FROM modeltablo", dbc.Baglanti());
            MySqlDataReader dr = modelDoldurCommand.ExecuteReader();

            while(dr.Read())
            {
                cbModelSec.Properties.Items.Add(dr["model"]);
            }
            dbc.Baglanti().Close();
            cbModelSec.Properties.Sorted = true;
        }

        private void cbModelSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM " + cbModelSec.Text.ToLower(), dbc.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            dbc.Baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr["ID"].ToString() != "")
            {
                tbMalzemeAdi.Text = dr["MalzemeAdi"].ToString();
                tbMalzemeKodu.Text = dr["MalzemeKodu"].ToString();
                tbDolapNo.Text = dr["DolapNumarasi"].ToString();
                tbSiraNo.Text = dr["SiraNumarasi"].ToString();
                tbStokSayisi.Text = dr["StokSayisi"].ToString();
                tbKritikStok.Text = dr["KritikStok"].ToString();
                tbTedarikci.Text = dr["Tedarikci"].ToString();
                tbFiyat.Text = dr["Fiyat"].ToString();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + cbModelSec.Text.ToLower() + " (MalzemeKodu, MalzemeAdi, DolapNumarasi, SiraNumarasi, StokSayisi, KritikStok, Tedarikci, Fiyat)" +
                " VALUES ( ?, ?, ?, ?, ?, ?, ?, ?)", dbc.Baglanti());
            cmd.Parameters.AddWithValue("@P1", tbMalzemeKodu.Text);
            cmd.Parameters.AddWithValue("@P2", tbMalzemeAdi.Text);
            cmd.Parameters.AddWithValue("@P3", tbDolapNo.Text);
            cmd.Parameters.AddWithValue("@P4", tbSiraNo.Text);
            cmd.Parameters.AddWithValue("@P5", tbStokSayisi.Text);
            cmd.Parameters.AddWithValue("@P6", tbKritikStok.Text);
            cmd.Parameters.AddWithValue("@P7", tbTedarikci.Text);
            cmd.Parameters.AddWithValue("@P8", tbFiyat.Text);

            cmd.ExecuteNonQuery();
            dbc.Baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
