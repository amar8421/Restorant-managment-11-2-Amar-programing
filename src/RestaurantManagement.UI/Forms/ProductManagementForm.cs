using System;
using System.Windows.Forms;
using RestaurantManagement.Core.Models;
using RestaurantManagement.Core.Services;

namespace RestaurantManagement.UI.Forms
{
    public partial class ProductManagementForm : Form
    {
        private ProductService _productService;

        public ProductManagementForm()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                dataGridProducts.DataSource = null;
                var products = _productService.GetAllProducts();
                dataGridProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë ngarkimit të produkteve: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Këtu do të shfaqet forma për shtimin e produktit të ri
            // Për tani, thjeshtë rifreskojmë listën
            LoadProducts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
