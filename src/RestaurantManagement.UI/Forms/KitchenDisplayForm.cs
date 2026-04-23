using System;
using System.Windows.Forms;
using RestaurantManagement.Core.Models;
using RestaurantManagement.Utilities;

namespace RestaurantManagement.UI.Forms
{
    /// <summary>
    /// Forma e shfaqjes së porosive në kuzhinë (Kitchen Display System - KDS)
    /// </summary>
    public partial class KitchenDisplayForm : Form
    {
        private User _currentUser;

        public KitchenDisplayForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void KitchenDisplayForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Sistemi i Kuzhines - {_currentUser.FullName}";
            lblKitchen.Text = $"Kuzhinë - Koha: {DateTime.Now:HH:mm}";
            
            timerRefresh.Start();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            lblKitchen.Text = $"Kuzhinë - Koha: {DateTime.Now:HH:mm}";
            RefreshOrders();
        }

        private void RefreshOrders()
        {
            // Këtu do të bëhet fetch i porosive të reja nga database
            // dhe shfaqja në grid-in primar
        }

        private void btnMarkCooking_Click(object sender, EventArgs e)
        {
            // Marko si "Duke u përpunuar"
        }

        private void btnMarkReady_Click(object sender, EventArgs e)
        {
            // Marko si "E gatshme"
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeni i sigurt që doni të dalë?", "Konfirmo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
