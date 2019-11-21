namespace ServisTakip
{
    partial class MalzemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeForm));
            this.lblGarantiIci = new System.Windows.Forms.Label();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.lblGarantiDisi = new System.Windows.Forms.Label();
            this.lblCihazSayisi = new System.Windows.Forms.Label();
            this.m_monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayitGoster = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGarantiIci
            // 
            this.lblGarantiIci.AutoSize = true;
            this.lblGarantiIci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGarantiIci.Location = new System.Drawing.Point(12, 496);
            this.lblGarantiIci.Name = "lblGarantiIci";
            this.lblGarantiIci.Size = new System.Drawing.Size(46, 18);
            this.lblGarantiIci.TabIndex = 34;
            this.lblGarantiIci.Text = "label4";
            this.lblGarantiIci.Visible = false;
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUcret.Location = new System.Drawing.Point(12, 433);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(46, 18);
            this.lblToplamUcret.TabIndex = 33;
            this.lblToplamUcret.Text = "label4";
            this.lblToplamUcret.Visible = false;
            // 
            // lblGarantiDisi
            // 
            this.lblGarantiDisi.AutoSize = true;
            this.lblGarantiDisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGarantiDisi.Location = new System.Drawing.Point(12, 463);
            this.lblGarantiDisi.Name = "lblGarantiDisi";
            this.lblGarantiDisi.Size = new System.Drawing.Size(46, 18);
            this.lblGarantiDisi.TabIndex = 32;
            this.lblGarantiDisi.Text = "label4";
            this.lblGarantiDisi.Visible = false;
            // 
            // lblCihazSayisi
            // 
            this.lblCihazSayisi.AutoSize = true;
            this.lblCihazSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazSayisi.Location = new System.Drawing.Point(12, 404);
            this.lblCihazSayisi.Name = "lblCihazSayisi";
            this.lblCihazSayisi.Size = new System.Drawing.Size(46, 18);
            this.lblCihazSayisi.TabIndex = 31;
            this.lblCihazSayisi.Text = "label4";
            this.lblCihazSayisi.Visible = false;
            // 
            // m_monthCalendar
            // 
            this.m_monthCalendar.Location = new System.Drawing.Point(7, 48);
            this.m_monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.m_monthCalendar.Name = "m_monthCalendar";
            this.m_monthCalendar.TabIndex = 30;
            this.m_monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.m_monthCalendar_DateSelected);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(7, 350);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(262, 37);
            this.simpleButton3.TabIndex = 27;
            this.simpleButton3.Text = "YAZDIR";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(7, 307);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(262, 37);
            this.simpleButton2.TabIndex = 26;
            this.simpleButton2.Text = "TARİH TEMİZLE";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnKayitGoster
            // 
            this.btnKayitGoster.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitGoster.Appearance.Options.UseFont = true;
            this.btnKayitGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitGoster.Image")));
            this.btnKayitGoster.Location = new System.Drawing.Point(7, 264);
            this.btnKayitGoster.Name = "btnKayitGoster";
            this.btnKayitGoster.Size = new System.Drawing.Size(262, 37);
            this.btnKayitGoster.TabIndex = 25;
            this.btnKayitGoster.Text = "KAYITLARI GÖSTER";
            this.btnKayitGoster.Click += new System.EventHandler(this.btnKayitGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "TARİH SEÇ";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(332, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 609);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MalzemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 633);
            this.Controls.Add(this.lblGarantiIci);
            this.Controls.Add(this.lblToplamUcret);
            this.Controls.Add(this.lblGarantiDisi);
            this.Controls.Add(this.lblCihazSayisi);
            this.Controls.Add(this.m_monthCalendar);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnKayitGoster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "MalzemeForm";
            this.Text = "MALZEME RAPORLARI";
            this.Load += new System.EventHandler(this.MalzemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGarantiIci;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.Label lblGarantiDisi;
        private System.Windows.Forms.Label lblCihazSayisi;
        private System.Windows.Forms.MonthCalendar m_monthCalendar;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnKayitGoster;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}