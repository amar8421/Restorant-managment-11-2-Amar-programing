using System;
using System.Windows.Forms;
using RestaurantManagement.Core.Services;
using RestaurantManagement.Utilities;

namespace RestaurantManagement.UI.Forms
{
    /// <summary>
    /// Forma e login-it
    /// </summary>
    public partial class LoginForm : Form
    {
        private AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Text = ConfigHelper.AppName;
            this.CenterToScreen();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                PerformLogin();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidateInput()
        {
            if (ValidationHelper.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Ju lutemi futni emrin e përdoruesit", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (ValidationHelper.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ju lutemi futni fjalëkalimin", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void PerformLogin()
        {
            try
            {
                var user = _authService.Login(txtUsername.Text, txtPassword.Text);

                if (user != null)
                {
                    // Login i suksesshëm
                    MessageBox.Show($"Mirëseerdhe {user.FullName}!", "Login i Suksesshëm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Hapni formën e duhur bazuar në rolin
                    if (user.Role == 1)  // Admin
                    {
                        AdminDashboard adminForm = new AdminDashboard(user);
                        adminForm.Show();
                    }
                    else if (user.Role == 2)  // Waiter
                    {
                        POSForm posForm = new POSForm(user);
                        posForm.Show();
                    }
                    else if (user.Role == 3)  // Kitchen
                    {
                        KitchenDisplayForm kitchenForm = new KitchenDisplayForm(user);
                        kitchenForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Emri i përdoruesit ose fjalëkalimi është i gabuar", "Gabim Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë login-it: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
