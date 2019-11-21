namespace ServisTakip
{
    partial class ServislerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServislerForm));
            this.cbSehirSec = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tbFirmaAdi = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gvServisler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdres = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdres2 = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefon = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCepTelefonu = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.tbYetkili = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMail = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSehirSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFirmaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdres2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCepTelefonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSehirSec
            // 
            this.cbSehirSec.Location = new System.Drawing.Point(12, 78);
            this.cbSehirSec.Name = "cbSehirSec";
            this.cbSehirSec.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSehirSec.Properties.Appearance.Options.UseFont = true;
            this.cbSehirSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSehirSec.Properties.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon ",
            "Ağrı ",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cbSehirSec.Size = new System.Drawing.Size(335, 28);
            this.cbSehirSec.TabIndex = 0;
            this.cbSehirSec.SelectedIndexChanged += new System.EventHandler(this.cbSehirSec_SelectedIndexChanged);
            // 
            // tbFirmaAdi
            // 
            this.tbFirmaAdi.Location = new System.Drawing.Point(12, 132);
            this.tbFirmaAdi.Name = "tbFirmaAdi";
            this.tbFirmaAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFirmaAdi.Properties.Appearance.Options.UseFont = true;
            this.tbFirmaAdi.Size = new System.Drawing.Size(335, 28);
            this.tbFirmaAdi.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 499);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(335, 41);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gvServisler
            // 
            this.gvServisler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvServisler.Location = new System.Drawing.Point(353, 53);
            this.gvServisler.MainView = this.gridView1;
            this.gvServisler.Name = "gvServisler";
            this.gvServisler.Size = new System.Drawing.Size(847, 568);
            this.gvServisler.TabIndex = 3;
            this.gvServisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvServisler;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ŞEHİR SEÇ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "FİRMA ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADRES";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(12, 186);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdres.Properties.Appearance.Options.UseFont = true;
            this.tbAdres.Size = new System.Drawing.Size(335, 28);
            this.tbAdres.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ADRES";
            // 
            // tbAdres2
            // 
            this.tbAdres2.Location = new System.Drawing.Point(12, 240);
            this.tbAdres2.Name = "tbAdres2";
            this.tbAdres2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdres2.Properties.Appearance.Options.UseFont = true;
            this.tbAdres2.Size = new System.Drawing.Size(335, 28);
            this.tbAdres2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "TELEFON";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(12, 294);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTelefon.Properties.Appearance.Options.UseFont = true;
            this.tbTelefon.Size = new System.Drawing.Size(335, 28);
            this.tbTelefon.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "CEP TELEFONU";
            // 
            // tbCepTelefonu
            // 
            this.tbCepTelefonu.Location = new System.Drawing.Point(12, 348);
            this.tbCepTelefonu.Name = "tbCepTelefonu";
            this.tbCepTelefonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCepTelefonu.Properties.Appearance.Options.UseFont = true;
            this.tbCepTelefonu.Size = new System.Drawing.Size(335, 28);
            this.tbCepTelefonu.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "YETKİLİ";
            // 
            // tbYetkili
            // 
            this.tbYetkili.Location = new System.Drawing.Point(12, 402);
            this.tbYetkili.Name = "tbYetkili";
            this.tbYetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYetkili.Properties.Appearance.Options.UseFont = true;
            this.tbYetkili.Size = new System.Drawing.Size(335, 28);
            this.tbYetkili.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "MAİL ADRESİ";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(12, 456);
            this.tbMail.Name = "tbMail";
            this.tbMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMail.Properties.Appearance.Options.UseFont = true;
            this.tbMail.Size = new System.Drawing.Size(335, 28);
            this.tbMail.TabIndex = 16;
            // 
            // ServislerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 633);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbYetkili);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCepTelefonu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAdres2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvServisler);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.tbFirmaAdi);
            this.Controls.Add(this.cbSehirSec);
            this.Name = "ServislerForm";
            this.Text = "SERVİSLER FORM";
            this.Load += new System.EventHandler(this.ServislerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbSehirSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFirmaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdres2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCepTelefonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbSehirSec;
        private DevExpress.XtraEditors.TextEdit tbFirmaAdi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gvServisler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit tbAdres;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit tbAdres2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tbTelefon;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit tbCepTelefonu;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit tbYetkili;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit tbMail;
    }
}