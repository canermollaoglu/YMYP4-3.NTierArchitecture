namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Category
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
            btnKaydet = new Button();
            label1 = new Label();
            txtAd = new TextBox();
            lstListe = new ListBox();
            label2 = new Label();
            txtAciklama = new TextBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            chkAktifPasif = new CheckBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(509, 221);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(214, 68);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 1;
            label1.Text = "Kategori Adı";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(326, 35);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(397, 43);
            txtAd.TabIndex = 2;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(12, 295);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(711, 189);
            lstListe.TabIndex = 3;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 1;
            label2.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(326, 84);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(397, 121);
            txtAciklama.TabIndex = 2;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(582, 490);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(141, 68);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(435, 490);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(141, 68);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // chkAktifPasif
            // 
            chkAktifPasif.AutoSize = true;
            chkAktifPasif.Checked = true;
            chkAktifPasif.CheckState = CheckState.Checked;
            chkAktifPasif.Location = new Point(326, 221);
            chkAktifPasif.Name = "chkAktifPasif";
            chkAktifPasif.Size = new Size(90, 41);
            chkAktifPasif.TabIndex = 5;
            chkAktifPasif.TabStop = false;
            chkAktifPasif.Text = "Aktif";
            chkAktifPasif.UseVisualStyleBackColor = true;
            chkAktifPasif.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Frm_Category
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 586);
            Controls.Add(chkAktifPasif);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(lstListe);
            Controls.Add(txtAciklama);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Category";
            Text = "Frm_Category";
            Load += Frm_Category_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label1;
        private TextBox txtAd;
        private ListBox lstListe;
        private Label label2;
        private TextBox txtAciklama;
        private Button btnSil;
        private Button btnGuncelle;
        private CheckBox chkAktifPasif;
    }
}