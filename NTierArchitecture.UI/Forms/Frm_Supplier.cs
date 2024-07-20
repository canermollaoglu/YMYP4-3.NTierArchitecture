using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
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
    public partial class Frm_Supplier : Form
    {
        private readonly SupplierService _supplierService;
        public Frm_Supplier()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var supplierRepository = new SupplierRepository(dbContext);
            _supplierService = new SupplierService(supplierRepository);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
