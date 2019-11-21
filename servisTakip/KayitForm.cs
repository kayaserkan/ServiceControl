﻿using System;
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
            MySqlCommand ModelSecCommand = new MySqlCommand("SELECT *FROM modeltablo", dbc.Baglanti());
            MySqlDataReader ModelSecReader = ModelSecCommand.ExecuteReader();

            while(ModelSecReader.Read())
            {
                cmbModel.Items.Add(ModelSecReader["Model"]);
            }
            dbc.Baglanti().Close();
            cmbModel.Sorted = true;

            MySqlCommand FirmaSecCommand = new MySqlCommand("SELECT *FROM firmakayittablo", dbc.Baglanti());
            MySqlDataReader FirmaSecReader = FirmaSecCommand.ExecuteReader();

            while(FirmaSecReader.Read())
            {
                cmbFirmaAdi.Items.Add(FirmaSecReader["FirmaAdi"]);
            }
            dbc.Baglanti().Close();
            cmbFirmaAdi.Sorted = true;
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
    }
}