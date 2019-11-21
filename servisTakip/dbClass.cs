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
    class dbClass
    {
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection Con;

        public  MySqlConnection Baglanti()
        {
            try
            {
                ////Bu kısım densi sunucusu için 
                //build.UserID = "u7908774_serkan";
                //build.Password = "AdmiN616161";
                //build.Server = "94.73.145.192";
                //build.Port = 3306;
                //build.Database = "u7908774_densi";
                //build.SslMode = MySqlSslMode.None;
                //string connStr = build.ToString();
                //Con = new MySqlConnection(connStr);


                //Bu kısım firmalara verilen programlar için settinge kayıtlar yapıp db ayarlarını setting den çekiiyor
                build.UserID = Properties.Settings.Default.DbKullaniciAdi;
                build.Password = Properties.Settings.Default.DbKullaniciSifre;
                build.Server = Properties.Settings.Default.DbIp;
                build.Port = 3306;
                build.Database = Properties.Settings.Default.DbAdi;
                build.SslMode = MySqlSslMode.None;
                string connStr = build.ToString();
                Con = new MySqlConnection(connStr);
                Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İnternet bağlantınızı kontrol ediniz.");
            }
            finally
            {

            }
            return Con;
        }
    }
}
