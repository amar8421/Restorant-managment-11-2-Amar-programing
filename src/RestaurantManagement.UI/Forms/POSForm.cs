using System;
using System.Windows.Forms;
using RestaurantManagement.Core.Models;
using RestaurantManagement.Utilities;

namespace RestaurantManagement.UI.Forms
{
    /// <summary>
    /// Forma e shitjes dhe porosise (POS - Point of Sale)
    /// </summary>
    public partial class POSForm : Form
    {
        private User _currentUser;

        public POSForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void POSForm_Load(object sender, EventArgs e)
        {
            this.Text = $"POS - Kamarieri: {_currentUser.FullName}";
            lblWaiter.Text = $"Kamarieri: {_currentUser.FullName}";
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            
            timerClock.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Rifresko tabelën e tavolina
        }
    }
}
