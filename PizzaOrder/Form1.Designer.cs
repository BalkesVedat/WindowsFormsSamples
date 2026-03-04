namespace PizzaOrder
{
    partial class frmSiparis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaTipleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçenekEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçenekSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.cmbPizzaType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.chkListExtras = new System.Windows.Forms.CheckedListBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.pnlPizza = new System.Windows.Forms.Panel();
            this.pnlMusteri = new System.Windows.Forms.Panel();
            this.lblMusteriSec = new System.Windows.Forms.Label();
            this.cmbSelectCustomer = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.pnlPizza.SuspendLayout();
            this.pnlMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.pizzaTipleriToolStripMenuItem,
            this.malzemeİşlemleriToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "&Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // pizzaTipleriToolStripMenuItem
            // 
            this.pizzaTipleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçenekEkleToolStripMenuItem,
            this.seçenekSilToolStripMenuItem});
            this.pizzaTipleriToolStripMenuItem.Name = "pizzaTipleriToolStripMenuItem";
            this.pizzaTipleriToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pizzaTipleriToolStripMenuItem.Text = "Pizza Tipleri";
            // 
            // seçenekEkleToolStripMenuItem
            // 
            this.seçenekEkleToolStripMenuItem.Name = "seçenekEkleToolStripMenuItem";
            this.seçenekEkleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.seçenekEkleToolStripMenuItem.Text = "Seçenek Ekle";
            // 
            // seçenekSilToolStripMenuItem
            // 
            this.seçenekSilToolStripMenuItem.Name = "seçenekSilToolStripMenuItem";
            this.seçenekSilToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.seçenekSilToolStripMenuItem.Text = "Seçenek Sil";
            // 
            // malzemeİşlemleriToolStripMenuItem
            // 
            this.malzemeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malzemeEkleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.malzemeİşlemleriToolStripMenuItem.Name = "malzemeİşlemleriToolStripMenuItem";
            this.malzemeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.malzemeİşlemleriToolStripMenuItem.Text = "Malzeme İşlemleri";
            // 
            // malzemeEkleToolStripMenuItem
            // 
            this.malzemeEkleToolStripMenuItem.Name = "malzemeEkleToolStripMenuItem";
            this.malzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.malzemeEkleToolStripMenuItem.Text = "Malzeme Ekle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriKaydıToolStripMenuItem,
            this.güncellemeToolStripMenuItem,
            this.silmeToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // müşteriKaydıToolStripMenuItem
            // 
            this.müşteriKaydıToolStripMenuItem.Name = "müşteriKaydıToolStripMenuItem";
            this.müşteriKaydıToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.müşteriKaydıToolStripMenuItem.Text = "Müşteri Kaydı";
            // 
            // güncellemeToolStripMenuItem
            // 
            this.güncellemeToolStripMenuItem.Name = "güncellemeToolStripMenuItem";
            this.güncellemeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.güncellemeToolStripMenuItem.Text = "Güncelleme";
            // 
            // silmeToolStripMenuItem
            // 
            this.silmeToolStripMenuItem.Name = "silmeToolStripMenuItem";
            this.silmeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.silmeToolStripMenuItem.Text = "Silme";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(28, 56);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(236, 47);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Boyut";
            this.gbSize.Enter += new System.EventHandler(this.gbSize_Enter);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(165, 19);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(55, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Text = "Büyük";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(87, 19);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(45, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Orta";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(7, 20);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(56, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Text = "Küçük";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // cmbPizzaType
            // 
            this.cmbPizzaType.FormattingEnabled = true;
            this.cmbPizzaType.Items.AddRange(new object[] {
            "Margarita",
            "Milaneze",
            "Eros",
            "Vegan"});
            this.cmbPizzaType.Location = new System.Drawing.Point(83, 24);
            this.cmbPizzaType.Name = "cmbPizzaType";
            this.cmbPizzaType.Size = new System.Drawing.Size(181, 21);
            this.cmbPizzaType.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(25, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Pizza Tipi";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // chkListExtras
            // 
            this.chkListExtras.ColumnWidth = 75;
            this.chkListExtras.FormattingEnabled = true;
            this.chkListExtras.Items.AddRange(new object[] {
            "Sosis",
            "Sucuk",
            "Mısır",
            "Cheddar",
            "Çikolata",
            "Ananas",
            "Çilek",
            "Mozarella",
            "Ezine",
            "Otlu Peynir"});
            this.chkListExtras.Location = new System.Drawing.Point(28, 126);
            this.chkListExtras.MultiColumn = true;
            this.chkListExtras.Name = "chkListExtras";
            this.chkListExtras.Size = new System.Drawing.Size(236, 64);
            this.chkListExtras.TabIndex = 4;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Location = new System.Drawing.Point(25, 110);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(93, 13);
            this.lblExtras.TabIndex = 5;
            this.lblExtras.Text = "Ekstra Malzemeler";
            // 
            // pnlPizza
            // 
            this.pnlPizza.Controls.Add(this.lblType);
            this.pnlPizza.Controls.Add(this.lblExtras);
            this.pnlPizza.Controls.Add(this.gbSize);
            this.pnlPizza.Controls.Add(this.chkListExtras);
            this.pnlPizza.Controls.Add(this.cmbPizzaType);
            this.pnlPizza.Location = new System.Drawing.Point(21, 36);
            this.pnlPizza.Name = "pnlPizza";
            this.pnlPizza.Size = new System.Drawing.Size(287, 219);
            this.pnlPizza.TabIndex = 6;
            // 
            // pnlMusteri
            // 
            this.pnlMusteri.Controls.Add(this.lblMusteriSec);
            this.pnlMusteri.Controls.Add(this.cmbSelectCustomer);
            this.pnlMusteri.Location = new System.Drawing.Point(322, 37);
            this.pnlMusteri.Name = "pnlMusteri";
            this.pnlMusteri.Size = new System.Drawing.Size(323, 217);
            this.pnlMusteri.TabIndex = 7;
            this.pnlMusteri.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMusteri_Paint);
            // 
            // lblMusteriSec
            // 
            this.lblMusteriSec.AutoSize = true;
            this.lblMusteriSec.Location = new System.Drawing.Point(25, 23);
            this.lblMusteriSec.Name = "lblMusteriSec";
            this.lblMusteriSec.Size = new System.Drawing.Size(41, 13);
            this.lblMusteriSec.TabIndex = 5;
            this.lblMusteriSec.Text = "Müşteri";
            // 
            // cmbSelectCustomer
            // 
            this.cmbSelectCustomer.FormattingEnabled = true;
            this.cmbSelectCustomer.Items.AddRange(new object[] {
            "Muhammed Enes",
            "Esma",
            "Aleyna"});
            this.cmbSelectCustomer.Location = new System.Drawing.Point(83, 23);
            this.cmbSelectCustomer.Name = "cmbSelectCustomer";
            this.cmbSelectCustomer.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectCustomer.TabIndex = 4;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 507);
            this.Controls.Add(this.pnlMusteri);
            this.Controls.Add(this.pnlPizza);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSiparis";
            this.Text = "PizzaMizza Sipariş Ekranı";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.pnlPizza.ResumeLayout(false);
            this.pnlPizza.PerformLayout();
            this.pnlMusteri.ResumeLayout(false);
            this.pnlMusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaTipleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçenekEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçenekSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silmeToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.ComboBox cmbPizzaType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckedListBox chkListExtras;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Panel pnlPizza;
        private System.Windows.Forms.Panel pnlMusteri;
        private System.Windows.Forms.Label lblMusteriSec;
        private System.Windows.Forms.ComboBox cmbSelectCustomer;
    }
}

