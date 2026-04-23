namespace RestaurantManagement.UI.Forms
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.lblDateTime);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 60);
            this.panelTop.TabIndex = 0;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(10, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Mirëseerdhe!";

            // lblDateTime
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(850, 25);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(150, 16);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "DateTime";

            // panelMenu
            this.panelMenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.btnTables);
            this.panelMenu.Controls.Add(this.btnStaff);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 640);
            this.panelMenu.TabIndex = 1;

            // btnProducts
            this.btnProducts.BackColor = System.Drawing.Color.LightGray;
            this.btnProducts.Font = new System.Drawing.Font("Arial", 10F);
            this.btnProducts.Location = new System.Drawing.Point(10, 10);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(130, 40);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Produktet";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);

            // btnStaff
            this.btnStaff.BackColor = System.Drawing.Color.LightGray;
            this.btnStaff.Font = new System.Drawing.Font("Arial", 10F);
            this.btnStaff.Location = new System.Drawing.Point(10, 60);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(130, 40);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "Personali";
            this.btnStaff.UseVisualStyleBackColor = false;

            // btnTables
            this.btnTables.BackColor = System.Drawing.Color.LightGray;
            this.btnTables.Font = new System.Drawing.Font("Arial", 10F);
            this.btnTables.Location = new System.Drawing.Point(10, 110);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(130, 40);
            this.btnTables.TabIndex = 2;
            this.btnTables.Text = "Tavolina";
            this.btnTables.UseVisualStyleBackColor = false;

            // btnReports
            this.btnReports.BackColor = System.Drawing.Color.LightGray;
            this.btnReports.Font = new System.Drawing.Font("Arial", 10F);
            this.btnReports.Location = new System.Drawing.Point(10, 160);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(130, 40);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Raportet";
            this.btnReports.UseVisualStyleBackColor = false;

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.Orange;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLogout.Location = new System.Drawing.Point(10, 550);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Dil";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(10, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Mbyll";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // panelMain
            this.panelMain.Controls.Add(this.lblMainTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(150, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(850, 640);
            this.panelMain.TabIndex = 2;

            // lblMainTitle
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.Location = new System.Drawing.Point(50, 100);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(400, 28);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Mirëseerdhe në Admin Panel";

            // timerClock
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // AdminDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Timer timerClock;
    }
}
