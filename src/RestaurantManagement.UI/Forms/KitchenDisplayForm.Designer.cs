namespace RestaurantManagement.UI.Forms
{
    partial class KitchenDisplayForm
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
            this.lblKitchen = new System.Windows.Forms.Label();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.flowLayoutOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnMarkCooking = new System.Windows.Forms.Button();
            this.btnMarkReady = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.Maroon;
            this.panelTop.Controls.Add(this.lblKitchen);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 0;

            // lblKitchen
            this.lblKitchen.AutoSize = true;
            this.lblKitchen.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblKitchen.ForeColor = System.Drawing.Color.White;
            this.lblKitchen.Location = new System.Drawing.Point(10, 15);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Size = new System.Drawing.Size(200, 25);
            this.lblKitchen.TabIndex = 0;
            this.lblKitchen.Text = "KUZHINË - POROSITE";

            // panelOrders
            this.panelOrders.Controls.Add(this.flowLayoutOrders);
            this.panelOrders.Controls.Add(this.lblOrdersTitle);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 60);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(1200, 540);
            this.panelOrders.TabIndex = 1;
            this.panelOrders.AutoScroll = true;

            // lblOrdersTitle
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrdersTitle.Location = new System.Drawing.Point(10, 10);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(200, 19);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "Porosite në Pritje:";

            // flowLayoutOrders
            this.flowLayoutOrders.AutoScroll = true;
            this.flowLayoutOrders.Location = new System.Drawing.Point(10, 35);
            this.flowLayoutOrders.Name = "flowLayoutOrders";
            this.flowLayoutOrders.Size = new System.Drawing.Size(1180, 495);
            this.flowLayoutOrders.TabIndex = 1;

            // panelButtons
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 600);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1200, 60);
            this.panelButtons.TabIndex = 2;
            this.panelButtons.Controls.Add(this.btnLogout);
            this.panelButtons.Controls.Add(this.btnMarkReady);
            this.panelButtons.Controls.Add(this.btnMarkCooking);

            // btnMarkCooking
            this.btnMarkCooking.BackColor = System.Drawing.Color.Orange;
            this.btnMarkCooking.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarkCooking.Location = new System.Drawing.Point(100, 15);
            this.btnMarkCooking.Name = "btnMarkCooking";
            this.btnMarkCooking.Size = new System.Drawing.Size(150, 30);
            this.btnMarkCooking.TabIndex = 0;
            this.btnMarkCooking.Text = "Fillo Gatimin";
            this.btnMarkCooking.UseVisualStyleBackColor = false;
            this.btnMarkCooking.Click += new System.EventHandler(this.btnMarkCooking_Click);

            // btnMarkReady
            this.btnMarkReady.BackColor = System.Drawing.Color.Green;
            this.btnMarkReady.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarkReady.ForeColor = System.Drawing.Color.White;
            this.btnMarkReady.Location = new System.Drawing.Point(300, 15);
            this.btnMarkReady.Name = "btnMarkReady";
            this.btnMarkReady.Size = new System.Drawing.Size(150, 30);
            this.btnMarkReady.TabIndex = 1;
            this.btnMarkReady.Text = "E Gatshme!";
            this.btnMarkReady.UseVisualStyleBackColor = false;
            this.btnMarkReady.Click += new System.EventHandler(this.btnMarkReady_Click);

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1100, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Dil";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // timerRefresh
            this.timerRefresh.Interval = 5000;  // Update çdo 5 sekonda
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);

            // KitchenDisplayForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 660);
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.Name = "KitchenDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemi i Kuzhines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitchenDisplayForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelOrders.ResumeLayout(false);
            this.panelOrders.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblKitchen;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutOrders;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnMarkCooking;
        private System.Windows.Forms.Button btnMarkReady;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timerRefresh;
    }
}
