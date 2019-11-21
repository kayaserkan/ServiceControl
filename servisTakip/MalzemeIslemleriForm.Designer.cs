namespace ServisTakip
{
    partial class MalzemeIslemleriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeIslemleriForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbModelSec = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.tbMalzemeAdi = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.tbMalzemeKodu = new System.Windows.Forms.TextBox();
            this.tbDolapNo = new System.Windows.Forms.TextBox();
            this.tbStokSayisi = new System.Windows.Forms.TextBox();
            this.tbSiraNo = new System.Windows.Forms.TextBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.tbModelEkle = new System.Windows.Forms.TextBox();
            this.btnModelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.tbTedarikci = new System.Windows.Forms.TextBox();
            this.tbKritikStok = new System.Windows.Forms.TextBox();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModelSec.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(345, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(855, 631);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(327, 35);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "MODEL SEÇ";
            // 
            // cbModelSec
            // 
            this.cbModelSec.Location = new System.Drawing.Point(12, 53);
            this.cbModelSec.Name = "cbModelSec";
            this.cbModelSec.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbModelSec.Properties.Appearance.Options.UseFont = true;
            this.cbModelSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbModelSec.Size = new System.Drawing.Size(327, 28);
            this.cbModelSec.TabIndex = 2;
            this.cbModelSec.SelectedIndexChanged += new System.EventHandler(this.cbModelSec_SelectedIndexChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 87);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(327, 35);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "MALZEME ADI";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(12, 162);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(151, 35);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "MALZEME KODU";
            // 
            // tbMalzemeAdi
            // 
            this.tbMalzemeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMalzemeAdi.Location = new System.Drawing.Point(12, 128);
            this.tbMalzemeAdi.Name = "tbMalzemeAdi";
            this.tbMalzemeAdi.Size = new System.Drawing.Size(327, 28);
            this.tbMalzemeAdi.TabIndex = 5;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton4.Location = new System.Drawing.Point(188, 162);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(151, 35);
            this.simpleButton4.TabIndex = 6;
            this.simpleButton4.Text = "DOLAP NO";
            // 
            // tbMalzemeKodu
            // 
            this.tbMalzemeKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMalzemeKodu.Location = new System.Drawing.Point(12, 203);
            this.tbMalzemeKodu.Name = "tbMalzemeKodu";
            this.tbMalzemeKodu.Size = new System.Drawing.Size(151, 28);
            this.tbMalzemeKodu.TabIndex = 7;
            // 
            // tbDolapNo
            // 
            this.tbDolapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDolapNo.Location = new System.Drawing.Point(188, 203);
            this.tbDolapNo.Name = "tbDolapNo";
            this.tbDolapNo.Size = new System.Drawing.Size(151, 28);
            this.tbDolapNo.TabIndex = 8;
            // 
            // tbStokSayisi
            // 
            this.tbStokSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbStokSayisi.Location = new System.Drawing.Point(188, 278);
            this.tbStokSayisi.Name = "tbStokSayisi";
            this.tbStokSayisi.Size = new System.Drawing.Size(151, 28);
            this.tbStokSayisi.TabIndex = 12;
            // 
            // tbSiraNo
            // 
            this.tbSiraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSiraNo.Location = new System.Drawing.Point(12, 278);
            this.tbSiraNo.Name = "tbSiraNo";
            this.tbSiraNo.Size = new System.Drawing.Size(151, 28);
            this.tbSiraNo.TabIndex = 11;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton5.Location = new System.Drawing.Point(188, 237);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(151, 35);
            this.simpleButton5.TabIndex = 10;
            this.simpleButton5.Text = "STOK SAYISI";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(12, 237);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(151, 35);
            this.simpleButton6.TabIndex = 9;
            this.simpleButton6.Text = "SIRA NO";
            // 
            // tbModelEkle
            // 
            this.tbModelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbModelEkle.Location = new System.Drawing.Point(12, 574);
            this.tbModelEkle.Name = "tbModelEkle";
            this.tbModelEkle.Size = new System.Drawing.Size(327, 28);
            this.tbModelEkle.TabIndex = 14;
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelEkle.Appearance.Options.UseFont = true;
            this.btnModelEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnModelEkle.Image")));
            this.btnModelEkle.Location = new System.Drawing.Point(12, 608);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(327, 35);
            this.btnModelEkle.TabIndex = 13;
            this.btnModelEkle.Text = "MODEL EKLE";
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // tbTedarikci
            // 
            this.tbTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTedarikci.Location = new System.Drawing.Point(188, 353);
            this.tbTedarikci.Name = "tbTedarikci";
            this.tbTedarikci.Size = new System.Drawing.Size(151, 28);
            this.tbTedarikci.TabIndex = 18;
            // 
            // tbKritikStok
            // 
            this.tbKritikStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKritikStok.Location = new System.Drawing.Point(12, 353);
            this.tbKritikStok.Name = "tbKritikStok";
            this.tbKritikStok.Size = new System.Drawing.Size(151, 28);
            this.tbKritikStok.TabIndex = 17;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.Image")));
            this.simpleButton7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton7.Location = new System.Drawing.Point(188, 312);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(151, 35);
            this.simpleButton7.TabIndex = 16;
            this.simpleButton7.Text = "TEDARİKCİ";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.Image")));
            this.simpleButton8.Location = new System.Drawing.Point(12, 312);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(151, 35);
            this.simpleButton8.TabIndex = 15;
            this.simpleButton8.Text = "KRİTİK STOK";
            // 
            // tbFiyat
            // 
            this.tbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFiyat.Location = new System.Drawing.Point(12, 428);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(151, 28);
            this.tbFiyat.TabIndex = 20;
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(12, 387);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(151, 35);
            this.simpleButton9.TabIndex = 19;
            this.simpleButton9.Text = "FİYAT";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(12, 503);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(327, 35);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "MALZEME GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.Image")));
            this.simpleButton10.Location = new System.Drawing.Point(12, 462);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(327, 35);
            this.simpleButton10.TabIndex = 22;
            this.simpleButton10.Text = "MALZEME EKLE";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // MalzemeIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 655);
            this.Controls.Add(this.simpleButton10);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.tbTedarikci);
            this.Controls.Add(this.tbKritikStok);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.tbModelEkle);
            this.Controls.Add(this.btnModelEkle);
            this.Controls.Add(this.tbStokSayisi);
            this.Controls.Add(this.tbSiraNo);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.tbDolapNo);
            this.Controls.Add(this.tbMalzemeKodu);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.tbMalzemeAdi);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cbModelSec);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "MalzemeIslemleriForm";
            this.Text = "MALZEME İŞLEMLERİ";
            this.Load += new System.EventHandler(this.MalzemeIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModelSec.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cbModelSec;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.TextBox tbMalzemeAdi;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.TextBox tbMalzemeKodu;
        private System.Windows.Forms.TextBox tbDolapNo;
        private System.Windows.Forms.TextBox tbStokSayisi;
        private System.Windows.Forms.TextBox tbSiraNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private System.Windows.Forms.TextBox tbModelEkle;
        private DevExpress.XtraEditors.SimpleButton btnModelEkle;
        private System.Windows.Forms.TextBox tbTedarikci;
        private System.Windows.Forms.TextBox tbKritikStok;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private System.Windows.Forms.TextBox tbFiyat;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
    }
}