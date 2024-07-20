namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Product
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
            grpProductInfo = new GroupBox();
            btnSave = new Button();
            label7 = new Label();
            label6 = new Label();
            chkDisc = new CheckBox();
            chkActive = new CheckBox();
            txtStock = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtPName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmdCategories = new ComboBox();
            cmdSuppliers = new ComboBox();
            lstList = new ListBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            grpProductInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grpProductInfo
            // 
            grpProductInfo.Controls.Add(btnSave);
            grpProductInfo.Controls.Add(label7);
            grpProductInfo.Controls.Add(label6);
            grpProductInfo.Controls.Add(chkDisc);
            grpProductInfo.Controls.Add(chkActive);
            grpProductInfo.Controls.Add(txtStock);
            grpProductInfo.Controls.Add(label5);
            grpProductInfo.Controls.Add(txtPrice);
            grpProductInfo.Controls.Add(label4);
            grpProductInfo.Controls.Add(txtPName);
            grpProductInfo.Controls.Add(label3);
            grpProductInfo.Controls.Add(label2);
            grpProductInfo.Controls.Add(label1);
            grpProductInfo.Controls.Add(cmdCategories);
            grpProductInfo.Controls.Add(cmdSuppliers);
            grpProductInfo.Location = new Point(25, 31);
            grpProductInfo.Name = "grpProductInfo";
            grpProductInfo.Size = new Size(851, 404);
            grpProductInfo.TabIndex = 0;
            grpProductInfo.TabStop = false;
            grpProductInfo.Text = "Ürün Bilgileri";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(656, 297);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 101);
            btnSave.TabIndex = 1;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 344);
            label7.Name = "label7";
            label7.Size = new Size(141, 37);
            label7.TabIndex = 6;
            label7.Text = "Devamlılık";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 297);
            label6.Name = "label6";
            label6.Size = new Size(98, 37);
            label6.TabIndex = 5;
            label6.Text = "Durum";
            // 
            // chkDisc
            // 
            chkDisc.AutoSize = true;
            chkDisc.Location = new Point(310, 344);
            chkDisc.Name = "chkDisc";
            chkDisc.Size = new Size(86, 41);
            chkDisc.TabIndex = 4;
            chkDisc.Text = "Evet";
            chkDisc.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(310, 297);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(90, 41);
            chkActive.TabIndex = 3;
            chkActive.Text = "Aktif";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(310, 248);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(535, 43);
            txtStock.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 248);
            label5.Name = "label5";
            label5.Size = new Size(145, 37);
            label5.TabIndex = 1;
            label5.Text = "Stok Adedi";
            label5.Click += label2_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(310, 199);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(535, 43);
            txtPrice.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 199);
            label4.Name = "label4";
            label4.Size = new Size(148, 37);
            label4.TabIndex = 1;
            label4.Text = "Birim Fiyatı";
            label4.Click += label2_Click;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(310, 150);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(535, 43);
            txtPName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 150);
            label3.Name = "label3";
            label3.Size = new Size(122, 37);
            label3.TabIndex = 1;
            label3.Text = "Ürün Adı";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 99);
            label2.Name = "label2";
            label2.Size = new Size(212, 37);
            label2.TabIndex = 1;
            label2.Text = "Kategori Seçiniz:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 48);
            label1.Name = "label1";
            label1.Size = new Size(214, 37);
            label1.TabIndex = 1;
            label1.Text = "Tedarikçi Seçiniz:";
            // 
            // cmdCategories
            // 
            cmdCategories.FormattingEnabled = true;
            cmdCategories.Location = new Point(310, 99);
            cmdCategories.Name = "cmdCategories";
            cmdCategories.Size = new Size(535, 45);
            cmdCategories.TabIndex = 0;
            // 
            // cmdSuppliers
            // 
            cmdSuppliers.FormattingEnabled = true;
            cmdSuppliers.Location = new Point(310, 48);
            cmdSuppliers.Name = "cmdSuppliers";
            cmdSuppliers.Size = new Size(535, 45);
            cmdSuppliers.TabIndex = 0;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 37;
            lstList.Location = new Point(25, 441);
            lstList.Name = "lstList";
            lstList.Size = new Size(851, 189);
            lstList.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(687, 634);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 60);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(492, 636);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 60);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Frm_Product
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 709);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lstList);
            Controls.Add(grpProductInfo);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Product";
            Text = "Frm_Product";
            Load += Frm_Product_Load;
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProductInfo;
        private TextBox txtPName;
        private Label label2;
        private Label label1;
        private ComboBox cmdCategories;
        private ComboBox cmdSuppliers;
        private Label label3;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtPrice;
        private Label label4;
        private Button btnSave;
        private Label label7;
        private Label label6;
        private CheckBox chkDisc;
        private CheckBox chkActive;
        private ListBox lstList;
        private Button btnDelete;
        private Button btnUpdate;
    }
}