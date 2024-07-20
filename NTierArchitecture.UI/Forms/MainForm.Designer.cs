namespace NTierArchitecture.UI.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            tANIMLAMALARToolStripMenuItem = new ToolStripMenuItem();
            tANIMLAMALARToolStripMenuItem1 = new ToolStripMenuItem();
            kategoriTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            tedarikçiTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            ürünTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            iŞLEMLERToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tANIMLAMALARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(985, 45);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tANIMLAMALARToolStripMenuItem
            // 
            tANIMLAMALARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tANIMLAMALARToolStripMenuItem1, iŞLEMLERToolStripMenuItem });
            tANIMLAMALARToolStripMenuItem.Name = "tANIMLAMALARToolStripMenuItem";
            tANIMLAMALARToolStripMenuItem.Size = new Size(129, 41);
            tANIMLAMALARToolStripMenuItem.Text = "MENU #";
            tANIMLAMALARToolStripMenuItem.Click += tANIMLAMALARToolStripMenuItem_Click;
            // 
            // tANIMLAMALARToolStripMenuItem1
            // 
            tANIMLAMALARToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { kategoriTanımlarıToolStripMenuItem, tedarikçiTanımlarıToolStripMenuItem, ürünTanımlarıToolStripMenuItem });
            tANIMLAMALARToolStripMenuItem1.Name = "tANIMLAMALARToolStripMenuItem1";
            tANIMLAMALARToolStripMenuItem1.Size = new Size(293, 42);
            tANIMLAMALARToolStripMenuItem1.Text = "TANIMLAMALAR";
            // 
            // kategoriTanımlarıToolStripMenuItem
            // 
            kategoriTanımlarıToolStripMenuItem.Name = "kategoriTanımlarıToolStripMenuItem";
            kategoriTanımlarıToolStripMenuItem.Size = new Size(311, 42);
            kategoriTanımlarıToolStripMenuItem.Text = "Kategori Tanımları";
            kategoriTanımlarıToolStripMenuItem.Click += kategoriTanımlarıToolStripMenuItem_Click;
            // 
            // tedarikçiTanımlarıToolStripMenuItem
            // 
            tedarikçiTanımlarıToolStripMenuItem.Name = "tedarikçiTanımlarıToolStripMenuItem";
            tedarikçiTanımlarıToolStripMenuItem.Size = new Size(311, 42);
            tedarikçiTanımlarıToolStripMenuItem.Text = "Tedarikçi Tanımları";
            tedarikçiTanımlarıToolStripMenuItem.Click += tedarikçiTanımlarıToolStripMenuItem_Click;
            // 
            // ürünTanımlarıToolStripMenuItem
            // 
            ürünTanımlarıToolStripMenuItem.Name = "ürünTanımlarıToolStripMenuItem";
            ürünTanımlarıToolStripMenuItem.Size = new Size(311, 42);
            ürünTanımlarıToolStripMenuItem.Text = "Ürün Tanımları";
            ürünTanımlarıToolStripMenuItem.Click += ürünTanımlarıToolStripMenuItem_Click;
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem });
            iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            iŞLEMLERToolStripMenuItem.Size = new Size(293, 42);
            iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(265, 42);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 460);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 20F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tANIMLAMALARToolStripMenuItem;
        private ToolStripMenuItem tANIMLAMALARToolStripMenuItem1;
        private ToolStripMenuItem kategoriTanımlarıToolStripMenuItem;
        private ToolStripMenuItem tedarikçiTanımlarıToolStripMenuItem;
        private ToolStripMenuItem ürünTanımlarıToolStripMenuItem;
        private ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
    }
}