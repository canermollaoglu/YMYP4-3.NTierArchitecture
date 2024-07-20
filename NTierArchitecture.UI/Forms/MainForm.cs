using NTierArchitecture.UI.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierArchitecture.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tANIMLAMALARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kategoriTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Category fCat = new Frm_Category();
            FormControl(fCat);
        }

        private void FormControl(Form fCat)
        {
            fCat.MdiParent = this;

            if (FormUtils.IsFormOpen(fCat))
            {
                MessageBox.Show("Form zaten açık.");
            }
            else
            {
                fCat.Show();
            }
        }

        private void tedarikçiTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Supplier fSupplier = new Frm_Supplier();
            FormControl(fSupplier);
        }

        private void ürünTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Product fProduct = new Frm_Product();
            FormControl (fProduct);
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Siparis frm_Siparis = new Frm_Siparis();
            FormControl(frm_Siparis);
        }
    }
}
