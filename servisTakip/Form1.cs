using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KayitForm kf;
        ServisTakipForm stf;
        AtolyeKontrolForm akf;
        FirmaIslemleriForm fif;
        AyarlarForm af;
        ServislerForm sf;
        RaporlarForm rf;
        MalzemeIslemleriForm mf;
        KullaniciGirisForm kgf;
        CikisYapilacak cy;
        MalzemeForm mrf;
        GrafikForm gf;

        public string kullaniciYetki;

        private void btnKayitEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(kf == null || kf.IsDisposed)
            {
                kf = new KayitForm();
                kf.MdiParent = this;
                kf.Show();
            }          
        }

        private void btnCihazSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stf == null || stf.IsDisposed)
            {
                stf = new ServisTakipForm();
                stf.MdiParent = this;
                stf.Show();
            }
        }

        private void btnAtolyeKontrol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (akf == null || akf.IsDisposed)
            {
                akf = new AtolyeKontrolForm();
                akf.MdiParent = this;
                akf.Show();
            }
        }

        private void btnFirmaIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fif == null || fif.IsDisposed)
            {
                fif = new FirmaIslemleriForm();
                fif.MdiParent = this;
                fif.Show();
            }
        }

        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (af == null || af.IsDisposed)
            {
                af = new AyarlarForm();
                af.MdiParent = this;
                af.Show();
            }
        }

        private void btnServisler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sf == null || sf.IsDisposed)
            {
                sf = new ServislerForm();
                sf.MdiParent = this;
                sf.Show();
            }
        }

        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rf == null || rf.IsDisposed)
            {
                rf = new RaporlarForm();
                rf.MdiParent = this;
                rf.Show();
            }
        }

        private void btnMalzemeIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mf == null || mf.IsDisposed)
            {
                mf = new MalzemeIslemleriForm();
                mf.MdiParent = this;
                mf.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kgf = new KullaniciGirisForm(); // Kullanıcı girişi formunu açıyor
            //kgf.ShowDialog();
            //MessageBox.Show(Properties.Settings.Default.KullaniciYetki);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(cy == null || cy.IsDisposed)
            {
                cy = new CikisYapilacak();
                cy.MdiParent = this;
                cy.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(mrf == null || mrf.IsDisposed)
            {
                mrf = new MalzemeForm();
                mrf.MdiParent = this;
                mrf.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gf == null || gf.IsDisposed)
            {
                gf = new GrafikForm();
                gf.MdiParent = this;
                gf.Show();
            }
        }        
    }
}
