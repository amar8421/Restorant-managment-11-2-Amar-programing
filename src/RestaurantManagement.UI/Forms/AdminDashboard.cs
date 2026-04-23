using System;
using System.Windows.Forms;
using RestaurantManagement.Core.Models;
using RestaurantManagement.Utilities;

namespace RestaurantManagement.UI.Forms
{
    /// <summary>
    /// Paneli i administrimit
    /// </summary>
    public partial class AdminDashboard : Form
    {
        private User _currentUser;

        public AdminDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.Text = $"{ConfigHelper.AppName} - Admin Panel [{_currentUser.FullName}]";
            lblWelcome.Text = $"Mirëseerdhe, {_currentUser.FullName}!";
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Timer për updatej të orës
            timerClock.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductManagementForm productForm = new ProductManagementForm();
            productForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeni i sigurt që doni të dalë?", "Konfirmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeni i sigurt që doni të mbyllni aplikacionin?", "Konfirmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
