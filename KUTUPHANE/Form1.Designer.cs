namespace KUTUPHANE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rAPORLARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiRaporuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListesiRaporuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçKitapListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaçAdetKitapVerildiAlındıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihlerArasıAlınanKtaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rAPORLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 43);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAPORLARToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rAPORLARToolStripMenuItem1
            // 
            this.rAPORLARToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapListesiRaporuToolStripMenuItem1,
            this.üyeListesiRaporuToolStripMenuItem1,
            this.ödünçKitapListesiRaporuToolStripMenuItem,
            this.kaçAdetKitapVerildiAlındıToolStripMenuItem,
            this.tarihlerArasıAlınanKtaplarToolStripMenuItem});
            this.rAPORLARToolStripMenuItem1.Name = "rAPORLARToolStripMenuItem1";
            this.rAPORLARToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.rAPORLARToolStripMenuItem1.Text = "RAPORLAR";
            // 
            // kitapListesiRaporuToolStripMenuItem1
            // 
            this.kitapListesiRaporuToolStripMenuItem1.Name = "kitapListesiRaporuToolStripMenuItem1";
            this.kitapListesiRaporuToolStripMenuItem1.Size = new System.Drawing.Size(312, 22);
            this.kitapListesiRaporuToolStripMenuItem1.Text = "Kitap Listesi Raporu";
            this.kitapListesiRaporuToolStripMenuItem1.Click += new System.EventHandler(this.KitapListesiRaporuToolStripMenuItem1_Click);
            // 
            // üyeListesiRaporuToolStripMenuItem1
            // 
            this.üyeListesiRaporuToolStripMenuItem1.Name = "üyeListesiRaporuToolStripMenuItem1";
            this.üyeListesiRaporuToolStripMenuItem1.Size = new System.Drawing.Size(312, 22);
            this.üyeListesiRaporuToolStripMenuItem1.Text = "Üye Listesi Raporu";
            this.üyeListesiRaporuToolStripMenuItem1.Click += new System.EventHandler(this.ÜyeListesiRaporuToolStripMenuItem1_Click);
            // 
            // ödünçKitapListesiRaporuToolStripMenuItem
            // 
            this.ödünçKitapListesiRaporuToolStripMenuItem.Name = "ödünçKitapListesiRaporuToolStripMenuItem";
            this.ödünçKitapListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.ödünçKitapListesiRaporuToolStripMenuItem.Text = "Bütün Ödünç Verilen Kitapların Listesi Raporu";
            this.ödünçKitapListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.ÖdünçKitapListesiRaporuToolStripMenuItem_Click);
            // 
            // kaçAdetKitapVerildiAlındıToolStripMenuItem
            // 
            this.kaçAdetKitapVerildiAlındıToolStripMenuItem.Name = "kaçAdetKitapVerildiAlındıToolStripMenuItem";
            this.kaçAdetKitapVerildiAlındıToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.kaçAdetKitapVerildiAlındıToolStripMenuItem.Text = "Kaç Adet Kitap Verildi/Alındı";
            this.kaçAdetKitapVerildiAlındıToolStripMenuItem.Click += new System.EventHandler(this.KaçAdetKitapVerildiAlındıToolStripMenuItem_Click);
            // 
            // tarihlerArasıAlınanKtaplarToolStripMenuItem
            // 
            this.tarihlerArasıAlınanKtaplarToolStripMenuItem.Name = "tarihlerArasıAlınanKtaplarToolStripMenuItem";
            this.tarihlerArasıAlınanKtaplarToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.tarihlerArasıAlınanKtaplarToolStripMenuItem.Text = "Tarihler Arası Alınan Kitaplar";
            this.tarihlerArasıAlınanKtaplarToolStripMenuItem.Click += new System.EventHandler(this.TarihlerArasıAlınanKtaplarToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(1, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 43);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::KUTUPHANE.Properties.Resources.iconfinder_contacts_1055082;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(354, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "ÖDÜNÇ KİTAP";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::KUTUPHANE.Properties.Resources.iconfinder_General_Office_37_3592853;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(220, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "ÜYE EKLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KUTUPHANE.Properties.Resources.iconfinder_booklet_1055108;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(90, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "KİTAP EKLE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAPORLARToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // rAPORLARToolStripMenuItem
            // 
            this.rAPORLARToolStripMenuItem.Name = "rAPORLARToolStripMenuItem";
            this.rAPORLARToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rAPORLARToolStripMenuItem.Text = "RAPORLAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 339);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KÜTÜPHANE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiRaporuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem üyeListesiRaporuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ödünçKitapListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaçAdetKitapVerildiAlındıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarihlerArasıAlınanKtaplarToolStripMenuItem;
    }
}