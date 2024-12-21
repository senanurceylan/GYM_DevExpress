namespace GYM_DevExpress
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnEkipman = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDersler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGirisCikis = new DevExpress.XtraBars.BarButtonItem();
            this.BtnYeniUye = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPuanlama = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRandevu = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUyeIlerleme = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUyeSil = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnEkipman,
            this.BtnDersler,
            this.BtnGirisCikis,
            this.BtnYeniUye,
            this.BtnKasa,
            this.BtnPersoneller,
            this.BtnPuanlama,
            this.BtnRandevu,
            this.BtnUyeIlerleme,
            this.BtnUyeSil,
            this.BtnAyarlar,
            this.BtnNotlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1175, 183);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // BtnEkipman
            // 
            this.BtnEkipman.Caption = "EKİPMAN";
            this.BtnEkipman.Id = 1;
            this.BtnEkipman.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEkipman.ImageOptions.SvgImage")));
            this.BtnEkipman.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkipman.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnEkipman.Name = "BtnEkipman";
            this.BtnEkipman.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // BtnDersler
            // 
            this.BtnDersler.Caption = "DERSLER";
            this.BtnDersler.Id = 2;
            this.BtnDersler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDersler.ImageOptions.SvgImage")));
            this.BtnDersler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDersler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnDersler.Name = "BtnDersler";
            // 
            // BtnGirisCikis
            // 
            this.BtnGirisCikis.Caption = "GİRİŞ ÇIKIŞ";
            this.BtnGirisCikis.Id = 3;
            this.BtnGirisCikis.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGirisCikis.ImageOptions.SvgImage")));
            this.BtnGirisCikis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisCikis.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnGirisCikis.Name = "BtnGirisCikis";
            // 
            // BtnYeniUye
            // 
            this.BtnYeniUye.Caption = "YENİ ÜYE";
            this.BtnYeniUye.Id = 4;
            this.BtnYeniUye.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnYeniUye.ImageOptions.SvgImage")));
            this.BtnYeniUye.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniUye.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnYeniUye.Name = "BtnYeniUye";
            this.BtnYeniUye.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnYeniUye_ItemClick);
            // 
            // BtnKasa
            // 
            this.BtnKasa.Caption = "KASA";
            this.BtnKasa.Id = 5;
            this.BtnKasa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKasa.ImageOptions.SvgImage")));
            this.BtnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKasa.Name = "BtnKasa";
            // 
            // BtnPersoneller
            // 
            this.BtnPersoneller.Caption = "PERSONELLER";
            this.BtnPersoneller.Id = 6;
            this.BtnPersoneller.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPersoneller.ImageOptions.SvgImage")));
            this.BtnPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnPersoneller.Name = "BtnPersoneller";
            this.BtnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersoneller_ItemClick);
            // 
            // BtnPuanlama
            // 
            this.BtnPuanlama.Caption = "PUANLAMA";
            this.BtnPuanlama.Id = 7;
            this.BtnPuanlama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPuanlama.ImageOptions.Image")));
            this.BtnPuanlama.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPuanlama.ImageOptions.LargeImage")));
            this.BtnPuanlama.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPuanlama.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnPuanlama.Name = "BtnPuanlama";
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.Caption = "RANDEVU YÖNETİMİ";
            this.BtnRandevu.Id = 8;
            this.BtnRandevu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRandevu.ImageOptions.Image")));
            this.BtnRandevu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRandevu.ImageOptions.LargeImage")));
            this.BtnRandevu.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRandevu.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnRandevu.Name = "BtnRandevu";
            // 
            // BtnUyeIlerleme
            // 
            this.BtnUyeIlerleme.Caption = "ÜYE İLERLEME";
            this.BtnUyeIlerleme.Id = 9;
            this.BtnUyeIlerleme.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUyeIlerleme.ImageOptions.SvgImage")));
            this.BtnUyeIlerleme.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyeIlerleme.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnUyeIlerleme.Name = "BtnUyeIlerleme";
            // 
            // BtnUyeSil
            // 
            this.BtnUyeSil.Caption = "ÜYE SİL";
            this.BtnUyeSil.Id = 10;
            this.BtnUyeSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUyeSil.ImageOptions.SvgImage")));
            this.BtnUyeSil.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyeSil.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnUyeSil.Name = "BtnUyeSil";
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Caption = "AYARLAR";
            this.BtnAyarlar.Id = 11;
            this.BtnAyarlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAyarlar.ImageOptions.SvgImage")));
            this.BtnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAyarlar.Name = "BtnAyarlar";
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.Caption = "NOTLAR";
            this.BtnNotlar.Id = 12;
            this.BtnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.Image")));
            this.BtnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.LargeImage")));
            this.BtnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnNotlar.Name = "BtnNotlar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnEkipman);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDersler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnGirisCikis);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnYeniUye);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPuanlama);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnRandevu);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUyeIlerleme);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUyeSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAyarlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnNotlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 653);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnEkipman;
        private DevExpress.XtraBars.BarButtonItem BtnDersler;
        private DevExpress.XtraBars.BarButtonItem BtnGirisCikis;
        private DevExpress.XtraBars.BarButtonItem BtnYeniUye;
        private DevExpress.XtraBars.BarButtonItem BtnKasa;
        private DevExpress.XtraBars.BarButtonItem BtnPersoneller;
        private DevExpress.XtraBars.BarButtonItem BtnPuanlama;
        private DevExpress.XtraBars.BarButtonItem BtnRandevu;
        private DevExpress.XtraBars.BarButtonItem BtnUyeIlerleme;
        private DevExpress.XtraBars.BarButtonItem BtnUyeSil;
        private DevExpress.XtraBars.BarButtonItem BtnAyarlar;
        private DevExpress.XtraBars.BarButtonItem BtnNotlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

