namespace ServisTakip
{
    partial class RaporlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporlarForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitGoster = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbModelSec = new System.Windows.Forms.ComboBox();
            this.cmbFirmaAdi = new System.Windows.Forms.ComboBox();
            this.m_monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblCihazSayisi = new System.Windows.Forms.Label();
            this.lblGarantiDisi = new System.Windows.Forms.Label();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.lblGarantiIci = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(326, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 609);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "TARİH SEÇ";
            // 
            // btnKayitGoster
            // 
            this.btnKayitGoster.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitGoster.Appearance.Options.UseFont = true;
            this.btnKayitGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitGoster.Image")));
            this.btnKayitGoster.Location = new System.Drawing.Point(1, 375);
            this.btnKayitGoster.Name = "btnKayitGoster";
            this.btnKayitGoster.Size = new System.Drawing.Size(262, 37);
            this.btnKayitGoster.TabIndex = 5;
            this.btnKayitGoster.Text = "KAYITLARI GÖSTER";
            this.btnKayitGoster.Click += new System.EventHandler(this.btnKayitGoster_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(1, 418);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(262, 37);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "TARİH TEMİZLE";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(1, 461);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(262, 37);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "YAZDIR";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MODEL SEÇ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "FİRMA SEÇ";
            // 
            // cbModelSec
            // 
            this.cbModelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbModelSec.FormattingEnabled = true;
            this.cbModelSec.Location = new System.Drawing.Point(1, 283);
            this.cbModelSec.Name = "cbModelSec";
            this.cbModelSec.Size = new System.Drawing.Size(262, 28);
            this.cbModelSec.TabIndex = 10;
            // 
            // cmbFirmaAdi
            // 
            this.cmbFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFirmaAdi.FormattingEnabled = true;
            this.cmbFirmaAdi.Location = new System.Drawing.Point(1, 341);
            this.cmbFirmaAdi.Name = "cmbFirmaAdi";
            this.cmbFirmaAdi.Size = new System.Drawing.Size(262, 28);
            this.cmbFirmaAdi.TabIndex = 10;
            // 
            // m_monthCalendar
            // 
            this.m_monthCalendar.Location = new System.Drawing.Point(1, 48);
            this.m_monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.m_monthCalendar.Name = "m_monthCalendar";
            this.m_monthCalendar.TabIndex = 16;
            this.m_monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.m_monthCalendar_DateSelected);
            // 
            // lblCihazSayisi
            // 
            this.lblCihazSayisi.AutoSize = true;
            this.lblCihazSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazSayisi.Location = new System.Drawing.Point(12, 511);
            this.lblCihazSayisi.Name = "lblCihazSayisi";
            this.lblCihazSayisi.Size = new System.Drawing.Size(46, 18);
            this.lblCihazSayisi.TabIndex = 17;
            this.lblCihazSayisi.Text = "label4";
            this.lblCihazSayisi.Visible = false;
            // 
            // lblGarantiDisi
            // 
            this.lblGarantiDisi.AutoSize = true;
            this.lblGarantiDisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGarantiDisi.Location = new System.Drawing.Point(12, 570);
            this.lblGarantiDisi.Name = "lblGarantiDisi";
            this.lblGarantiDisi.Size = new System.Drawing.Size(46, 18);
            this.lblGarantiDisi.TabIndex = 18;
            this.lblGarantiDisi.Text = "label4";
            this.lblGarantiDisi.Visible = false;
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUcret.Location = new System.Drawing.Point(12, 540);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(46, 18);
            this.lblToplamUcret.TabIndex = 19;
            this.lblToplamUcret.Text = "label4";
            this.lblToplamUcret.Visible = false;
            // 
            // lblGarantiIci
            // 
            this.lblGarantiIci.AutoSize = true;
            this.lblGarantiIci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGarantiIci.Location = new System.Drawing.Point(12, 603);
            this.lblGarantiIci.Name = "lblGarantiIci";
            this.lblGarantiIci.Size = new System.Drawing.Size(46, 18);
            this.lblGarantiIci.TabIndex = 20;
            this.lblGarantiIci.Text = "label4";
            this.lblGarantiIci.Visible = false;
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 633);
            this.Controls.Add(this.lblGarantiIci);
            this.Controls.Add(this.lblToplamUcret);
            this.Controls.Add(this.lblGarantiDisi);
            this.Controls.Add(this.lblCihazSayisi);
            this.Controls.Add(this.m_monthCalendar);
            this.Controls.Add(this.cmbFirmaAdi);
            this.Controls.Add(this.cbModelSec);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnKayitGoster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "RaporlarForm";
            this.Text = "TAMİR RAPORLARI";
            this.Load += new System.EventHandler(this.RaporlarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnKayitGoster;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbModelSec;
        private System.Windows.Forms.ComboBox cmbFirmaAdi;
        private System.Windows.Forms.MonthCalendar m_monthCalendar;
        private System.Windows.Forms.Label lblCihazSayisi;
        private System.Windows.Forms.Label lblGarantiDisi;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.Label lblGarantiIci;
    }
}