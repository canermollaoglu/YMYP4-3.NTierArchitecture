using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Data;

namespace NTierArchitecture.UI.Forms
{
    public partial class Frm_Siparis : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly ProductService _productService;
        private readonly ProductRepository _productRepository;
        private readonly OrderService _orderService;
        private readonly OrderRepository _orderRepository;
        private readonly OrderDetailService _orderDetailService;
        private readonly OrderDetailRepository _orderDetailRepository;

        public Frm_Siparis()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _productRepository = new ProductRepository(_context);
            _productService = new ProductService(_productRepository);

            _orderRepository = new OrderRepository(_context);
            _orderService = new OrderService(_orderRepository);

            _orderDetailRepository = new OrderDetailRepository(_context);
            _orderDetailService = new OrderDetailService(_orderDetailRepository);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Siparis_Load(object sender, EventArgs e)
        {
            /*
             Burada yeni bir Customer oluşturularak eklenecek.Tüm sipariş işlemi bu müşteri üzerinden yapılacaktır.
             */
            sepet.CardID = 1;
            GetAllProducts();
            GelAllOrders();
            GetAllOrderDetails();
        }

        private void GetAllOrderDetails()
        {
            dgwOrderDetailList.DataSource = _orderDetailService.GetAll();
        }

        private void GelAllOrders()
        {
            dgwOrderList.DataSource = _orderService.GetAll();
        }

        private void GetAllProducts()
        {
            lstProductList.ValueMember = "Id";
            lstProductList.DisplayMember = "ProductName";
            lstProductList.DataSource = _productService.GetAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 3)
            {
                var pList = _productService.GetAll().Where(p => p.ProductName.ToLower().Contains(searchText));

                lstProductList.ValueMember = "Id";
                lstProductList.DisplayMember = "ProductName";
                lstProductList.DataSource = pList.ToList();
            }
            else if (searchText.Length == 0)
            {
                GetAllProducts();
            }
        }

        Product? selectedProduct;
        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductList.SelectedIndex != -1)
            {
                selectedProduct = (Product?)lstProductList.SelectedItem;
                txtPrice.Text = selectedProduct.UnitPrice.ToString();
            }
        }

        Card sepet = new Card();
        private void btnBasket_Click(object sender, EventArgs e)
        {
            CartItem item = new CartItem()
            {
                CardItemID = Guid.NewGuid(),
                ProductID = selectedProduct.Id,
                Quantity = Convert.ToInt32(nmrQuantity.Value),
                UnitPrice = Convert.ToDouble(txtPrice.Text),
                ProductName = selectedProduct.ProductName
            };

            sepet.AddItem(item);
            GetAllCardItems();
            CardandCardItemTotal();
        }

        private void CardandCardItemTotal()
        {
            double bTotal = 0;

            foreach (CartItem item in sepet.CardItems)
            {
                bTotal += item.Quantity * item.UnitPrice;
            }

            lblBasketTotal.Text = bTotal.ToString();
            lblBasketCount.Text = sepet.CardItems.Count.ToString();
        }

        private void GetAllCardItems()
        {
            lstBasket.Items.Clear();
            sepet.CardItems.ForEach(item => lstBasket.Items.Add(item));
        }

        CartItem? selectedItem;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBasket.SelectedIndex != -1)
            {
                selectedItem = (CartItem?)lstBasket.SelectedItem;

                if (selectedItem != null)
                {
                    sepet.DeleteItem(selectedItem.CardItemID);
                    GetAllCardItems();
                    CardandCardItemTotal();
                }
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Order o = new Order()
                    {
                        IsActive = true,
                        CreatedDate = DateTime.Now,
                        OrderDate = DateOnly.FromDateTime(DateTime.Now),
                        CustomerID = Guid.Parse("464738A1-19C8-408B-8115-61AA7D3198C4"),
                        EmployeeID = Guid.Parse("A6615D55-A180-45E1-813B-D43F6AA95D30")
                    };

                    _orderService.Create(o);
                    throw new Exception("Hata");
                    #region yontem1
                    //foreach (var item in sepet.CardItems)
                    //{
                    //    OrderDetail od = new OrderDetail()
                    //    {
                    //        IsActive = true,
                    //        CreatedDate = DateTime.Now,
                    //        OrderID = o.Id,
                    //        ProductID = item.ProductID,
                    //        UnitPrice = item.UnitPrice,
                    //        Quantity = item.Quantity
                    //    };
                    //}
                    #endregion

                    #region guncelyontem
                    sepet.CardItems.ForEach(x => _orderDetailService.Create(new OrderDetail()
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        OrderID = o.Id,
                        ProductID = x.ProductID,
                        Quantity = x.Quantity,
                        UnitPrice = x.UnitPrice
                    }));
                    #endregion

                    transaction.Commit();
                    MessageBox.Show("Sipariş başarı ile oluşturuldu.");

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
