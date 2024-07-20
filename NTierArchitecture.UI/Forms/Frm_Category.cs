using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
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
    public partial class Frm_Category : Form
    {
        private readonly CategoryService _categoryService;
        public Frm_Category()
        {
            InitializeComponent();

            //Dependency Injection ile CategoryService oluşturuldu.
            var dbContext = new ApplicationDbContext();
            var catRepo = new CategoryRepository(dbContext);
            _categoryService = new CategoryService(catRepo);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //formdan verileri al
                string categoryName = txtAd.Text;
                string categoryDescription = txtAciklama.Text;

                //category oluştur
                Category newCat = new Category()
                {
                    CategoryName = categoryName,
                    Description = categoryDescription,
                    IsActive = chkAktifPasif.Checked
                };

                //kaydet
                if (_categoryService.IfEntityExists(newCat.CategoryName))
                {
                    throw new Exception("Bu kategori zaten kayıtlı.");
                }

                _categoryService.Create(newCat);
                MessageBox.Show("Kayıt Başarılı");
                GetAllCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllCategories()
        {
            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "CategoryName";
            lstListe.DataSource = _categoryService.GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                secilen.CategoryName = txtAd.Text;
                secilen.Description = txtAciklama.Text;
                secilen.IsActive = chkAktifPasif.Checked;

                _categoryService.Update(secilen);
                MessageBox.Show("Güncelleme Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstListe.SelectedIndex != -1)
                {
                    Guid id = (Guid)lstListe.SelectedValue;
                    _categoryService.Delete(id);
                    GetAllCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAktifPasif.Checked)
            {
                chkAktifPasif.Text = "Aktif";
            }
            else
            {
                chkAktifPasif.Text = "Pasif";
            }
        }
        Category secilen;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilen = (Category)lstListe.SelectedItem;
                txtAciklama.Text = secilen.Description;
                txtAd.Text = secilen.CategoryName;
                chkAktifPasif.Checked = secilen.IsActive;
            }
        }
    }
}
