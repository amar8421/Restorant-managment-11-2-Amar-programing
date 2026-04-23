namespace RestaurantManagement.UI.Forms
{
    partial class POSForm
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
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panelTables = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.lblTime);
            this.panelTop.Controls.Add(this.lblWaiter);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 0;

            // lblWaiter
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblWaiter.ForeColor = System.Drawing.Color.White;
            this.lblWaiter.Location = new System.Drawing.Point(10, 20);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(100, 19);
            this.lblWaiter.TabIndex = 0;
            this.lblWaiter.Text = "Kamarieri:";

            // lblTime
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1050, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(130, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Koha";

            // panelTables
            this.panelTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTables.Controls.Add(this.btnRefresh);
            this.panelTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTables.Location = new System.Drawing.Point(0, 60);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(300, 500);
            this.panelTables.TabIndex = 1;

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(10, 450);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(280, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Rifresko Tavolina";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // panelOrder
            this.panelOrder.Controls.Add(this.dataGridOrder);
            this.panelOrder.Controls.Add(this.lblOrderTitle);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(300, 60);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(900, 440);
            this.panelOrder.TabIndex = 2;

            // lblOrderTitle
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitle.Location = new System.Drawing.Point(10, 10);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(80, 19);
            this.lblOrderTitle.TabIndex = 0;
            this.lblOrderTitle.Text = "Porosia:";

            // dataGridOrder
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(10, 35);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(880, 395);
            this.dataGridOrder.TabIndex = 1;

            // panelButtons
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 500);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1200, 60);
            this.panelButtons.TabIndex = 3;
            this.panelButtons.Controls.Add(this.btnLogout);
            this.panelButtons.Controls.Add(this.btnPrint);

            // btnPrint
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 10F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1000, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Shtyp Faturën";
            this.btnPrint.UseVisualStyleBackColor = false;

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1110, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Dil";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // timerClock
            this.timerClock.Interval = 60000;  // Update çdo minutë
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // POSForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 560);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelTables);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Sistemi i Porosive";
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timerClock;
    }
}
