namespace ServisTakip
{
    partial class SebepForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SebepForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUretim = new System.Windows.Forms.RadioButton();
            this.rbTeknikServis = new System.Windows.Forms.RadioButton();
            this.rbMalzeme = new System.Windows.Forms.RadioButton();
            this.rbAmbalaj = new System.Windows.Forms.RadioButton();
            this.rbKullanici = new System.Windows.Forms.RadioButton();
            this.rbDiger = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDiger);
            this.groupBox1.Controls.Add(this.rbKullanici);
            this.groupBox1.Controls.Add(this.rbAmbalaj);
            this.groupBox1.Controls.Add(this.rbMalzeme);
            this.groupBox1.Controls.Add(this.rbTeknikServis);
            this.groupBox1.Controls.Add(this.rbUretim);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARIZA SEBEBİNİ SEÇİNİZ";
            // 
            // rbUretim
            // 
            this.rbUretim.AutoSize = true;
            this.rbUretim.Location = new System.Drawing.Point(17, 60);
            this.rbUretim.Name = "rbUretim";
            this.rbUretim.Size = new System.Drawing.Size(81, 21);
            this.rbUretim.TabIndex = 2;
            this.rbUretim.Text = "ÜRETİM";
            this.rbUretim.UseVisualStyleBackColor = true;
            // 
            // rbTeknikServis
            // 
            this.rbTeknikServis.AutoSize = true;
            this.rbTeknikServis.Location = new System.Drawing.Point(215, 60);
            this.rbTeknikServis.Name = "rbTeknikServis";
            this.rbTeknikServis.Size = new System.Drawing.Size(131, 21);
            this.rbTeknikServis.TabIndex = 3;
            this.rbTeknikServis.Text = "TEKNİK SERVİS";
            this.rbTeknikServis.UseVisualStyleBackColor = true;
            // 
            // rbMalzeme
            // 
            this.rbMalzeme.AutoSize = true;
            this.rbMalzeme.Location = new System.Drawing.Point(396, 60);
            this.rbMalzeme.Name = "rbMalzeme";
            this.rbMalzeme.Size = new System.Drawing.Size(95, 21);
            this.rbMalzeme.TabIndex = 4;
            this.rbMalzeme.Text = "MALZEME";
            this.rbMalzeme.UseVisualStyleBackColor = true;
            // 
            // rbAmbalaj
            // 
            this.rbAmbalaj.AutoSize = true;
            this.rbAmbalaj.Location = new System.Drawing.Point(17, 127);
            this.rbAmbalaj.Name = "rbAmbalaj";
            this.rbAmbalaj.Size = new System.Drawing.Size(91, 21);
            this.rbAmbalaj.TabIndex = 5;
            this.rbAmbalaj.Text = "AMBALAJ";
            this.rbAmbalaj.UseVisualStyleBackColor = true;
            // 
            // rbKullanici
            // 
            this.rbKullanici.AutoSize = true;
            this.rbKullanici.Location = new System.Drawing.Point(215, 127);
            this.rbKullanici.Name = "rbKullanici";
            this.rbKullanici.Size = new System.Drawing.Size(98, 21);
            this.rbKullanici.TabIndex = 6;
            this.rbKullanici.Text = "KULLANICI";
            this.rbKullanici.UseVisualStyleBackColor = true;
            // 
            // rbDiger
            // 
            this.rbDiger.AutoSize = true;
            this.rbDiger.Checked = true;
            this.rbDiger.Location = new System.Drawing.Point(396, 127);
            this.rbDiger.Name = "rbDiger";
            this.rbDiger.Size = new System.Drawing.Size(72, 21);
            this.rbDiger.TabIndex = 7;
            this.rbDiger.TabStop = true;
            this.rbDiger.Text = "DİĞER";
            this.rbDiger.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(284, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(263, 57);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "VAZGEÇ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(263, 57);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SebepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 273);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SebepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARIZA SEBEBİ SEÇİMİ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDiger;
        private System.Windows.Forms.RadioButton rbKullanici;
        private System.Windows.Forms.RadioButton rbAmbalaj;
        private System.Windows.Forms.RadioButton rbMalzeme;
        private System.Windows.Forms.RadioButton rbTeknikServis;
        private System.Windows.Forms.RadioButton rbUretim;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}