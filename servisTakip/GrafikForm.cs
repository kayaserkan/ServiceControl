using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Charts;
using MySql.Data.MySqlClient;
using DevExpress.XtraPrinting;
using DevExpress.XtraCharts;

namespace ServisTakip
{
    public partial class GrafikForm : Form
    {
        dbClass dbc = new dbClass();
        public GrafikForm()
        {
            InitializeComponent();
        }

        private void GrafikForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if(cbModelSec != null)
            {
                if(tbYilSec.Text != "")
                {
                    Series series1 = new Series(cbModelSec.Text, ViewType.Bar);
                    chartCont.Series.Add(series1);

                    MySqlCommand servisCommand = new MySqlCommand("SELECT  AY, "+ cbModelSec.Text +" from densi.arizarapor where YIL = '" + tbYilSec.Text +"';", dbc.Baglanti());
                    MySqlDataReader servisReader = servisCommand.ExecuteReader();
                    while (servisReader.Read())
                    {
                        //chart1.Series["AC100"].Points.Add(Convert.ToDouble(servisReader[1])); // winform chart ile kullanılabilir.
                        //chart1.Series["AC100"].Points[0].AxisLabel = servisReader[0].ToString(); // winform chart ile kullanılabilir.
                        chartCont.Series[cbModelSec.Text].Points.Add(new DevExpress.XtraCharts.SeriesPoint(servisReader[0], Convert.ToInt16(servisReader[1])));
                    }
                    dbc.Baglanti().Close();
                }
            }
        }
    }
}
