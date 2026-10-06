namespace dashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDashTitle = new Label();
            pnlPending = new Panel();
            lblPendingValue = new Label();
            lblPendingTitle = new Label();
            pnlAssigned = new Panel();
            lblAssignedValue = new Label();
            lblAssignedTitle = new Label();
            pnlDelivered = new Panel();
            lblDeliveredValue = new Label();
            lblDeliveredTitle = new Label();
            pnlIncome = new Panel();
            lblIncomeValue = new Label();
            lblIncomeTitle = new Label();
            pnlHeader = new Panel();
            btnOrderManagement = new Button();
            btnSearchFilterOrders = new Button();
            btnPaymentCreditTabManagement = new Button();
            btnReports = new Button();
            btnIncomeExpense = new Button();
            btnAdminManagement = new Button();
            dgvstatus = new DataGridView();
            status = new DataGridViewTextBoxColumn();
            Driver = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            order = new DataGridViewTextBoxColumn();
            pnlPending.SuspendLayout();
            pnlAssigned.SuspendLayout();
            pnlDelivered.SuspendLayout();
            pnlIncome.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvstatus).BeginInit();
            SuspendLayout();
            // 
            // lblDashTitle
            // 
            lblDashTitle.AutoSize = true;
            lblDashTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashTitle.ForeColor = Color.White;
            lblDashTitle.Location = new Point(13, 22);
            lblDashTitle.Name = "lblDashTitle";
            lblDashTitle.Size = new Size(214, 31);
            lblDashTitle.TabIndex = 0;
            lblDashTitle.Text = "Dashboard - Today";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.White;
            pnlPending.Controls.Add(lblPendingValue);
            pnlPending.Controls.Add(lblPendingTitle);
            pnlPending.Location = new Point(333, 12);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(131, 90);
            pnlPending.TabIndex = 1;
            // 
            // lblPendingValue
            // 
            lblPendingValue.AutoSize = true;
            lblPendingValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingValue.ForeColor = Color.FromArgb(99, 56, 6);
            lblPendingValue.Location = new Point(12, 39);
            lblPendingValue.Name = "lblPendingValue";
            lblPendingValue.Size = new Size(40, 46);
            lblPendingValue.TabIndex = 2;
            lblPendingValue.Text = "0";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.ForeColor = Color.Gray;
            lblPendingTitle.Location = new Point(12, 9);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(62, 20);
            lblPendingTitle.TabIndex = 2;
            lblPendingTitle.Text = "Pending";
            // 
            // pnlAssigned
            // 
            pnlAssigned.BackColor = Color.White;
            pnlAssigned.Controls.Add(lblAssignedValue);
            pnlAssigned.Controls.Add(lblAssignedTitle);
            pnlAssigned.Location = new Point(470, 12);
            pnlAssigned.Name = "pnlAssigned";
            pnlAssigned.Size = new Size(131, 90);
            pnlAssigned.TabIndex = 2;
            // 
            // lblAssignedValue
            // 
            lblAssignedValue.AutoSize = true;
            lblAssignedValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssignedValue.ForeColor = Color.FromArgb(99, 56, 6);
            lblAssignedValue.Location = new Point(14, 39);
            lblAssignedValue.Name = "lblAssignedValue";
            lblAssignedValue.Size = new Size(40, 46);
            lblAssignedValue.TabIndex = 4;
            lblAssignedValue.Text = "0";
            // 
            // lblAssignedTitle
            // 
            lblAssignedTitle.AutoSize = true;
            lblAssignedTitle.ForeColor = Color.Gray;
            lblAssignedTitle.Location = new Point(14, 9);
            lblAssignedTitle.Name = "lblAssignedTitle";
            lblAssignedTitle.Size = new Size(69, 20);
            lblAssignedTitle.TabIndex = 3;
            lblAssignedTitle.Text = "Assigned";
            // 
            // pnlDelivered
            // 
            pnlDelivered.BackColor = Color.White;
            pnlDelivered.Controls.Add(lblDeliveredValue);
            pnlDelivered.Controls.Add(lblDeliveredTitle);
            pnlDelivered.Location = new Point(607, 12);
            pnlDelivered.Name = "pnlDelivered";
            pnlDelivered.Size = new Size(131, 90);
            pnlDelivered.TabIndex = 3;
            // 
            // lblDeliveredValue
            // 
            lblDeliveredValue.AutoSize = true;
            lblDeliveredValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeliveredValue.ForeColor = Color.FromArgb(8, 80, 65);
            lblDeliveredValue.Location = new Point(13, 39);
            lblDeliveredValue.Name = "lblDeliveredValue";
            lblDeliveredValue.Size = new Size(40, 46);
            lblDeliveredValue.TabIndex = 1;
            lblDeliveredValue.Text = "0";
            // 
            // lblDeliveredTitle
            // 
            lblDeliveredTitle.AutoSize = true;
            lblDeliveredTitle.ForeColor = Color.Gray;
            lblDeliveredTitle.Location = new Point(13, 9);
            lblDeliveredTitle.Name = "lblDeliveredTitle";
            lblDeliveredTitle.Size = new Size(73, 20);
            lblDeliveredTitle.TabIndex = 0;
            lblDeliveredTitle.Text = "Delivered";
            // 
            // pnlIncome
            // 
            pnlIncome.BackColor = Color.White;
            pnlIncome.Controls.Add(lblIncomeValue);
            pnlIncome.Controls.Add(lblIncomeTitle);
            pnlIncome.Location = new Point(744, 12);
            pnlIncome.Name = "pnlIncome";
            pnlIncome.Size = new Size(200, 90);
            pnlIncome.TabIndex = 4;
            // 
            // lblIncomeValue
            // 
            lblIncomeValue.AutoSize = true;
            lblIncomeValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncomeValue.Location = new Point(15, 39);
            lblIncomeValue.Name = "lblIncomeValue";
            lblIncomeValue.Size = new Size(62, 46);
            lblIncomeValue.TabIndex = 1;
            lblIncomeValue.Text = "₱0";
            // 
            // lblIncomeTitle
            // 
            lblIncomeTitle.AutoSize = true;
            lblIncomeTitle.ForeColor = Color.Gray;
            lblIncomeTitle.Location = new Point(15, 9);
            lblIncomeTitle.Name = "lblIncomeTitle";
            lblIncomeTitle.Size = new Size(111, 20);
            lblIncomeTitle.TabIndex = 0;
            lblIncomeTitle.Text = "Today's Income";
            lblIncomeTitle.Click += lblIncomeTitle_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblDashTitle);
            pnlHeader.Controls.Add(btnIncomeExpense);
            pnlHeader.Controls.Add(btnAdminManagement);
            pnlHeader.Controls.Add(btnPaymentCreditTabManagement);
            pnlHeader.Controls.Add(btnOrderManagement);
            pnlHeader.Controls.Add(btnReports);
            pnlHeader.Controls.Add(btnSearchFilterOrders);
            pnlHeader.Location = new Point(-1, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(311, 427);
            pnlHeader.TabIndex = 6;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.BackColor = Color.FromArgb(55, 138, 221);
            btnOrderManagement.FlatStyle = FlatStyle.Flat;
            btnOrderManagement.ForeColor = Color.White;
            btnOrderManagement.Location = new Point(47, 113);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(211, 29);
            btnOrderManagement.TabIndex = 7;
            btnOrderManagement.Text = "Order Management";
            btnOrderManagement.UseVisualStyleBackColor = false;
            // 
            // btnSearchFilterOrders
            // 
            btnSearchFilterOrders.BackColor = Color.FromArgb(55, 138, 221);
            btnSearchFilterOrders.FlatStyle = FlatStyle.Flat;
            btnSearchFilterOrders.ForeColor = Color.White;
            btnSearchFilterOrders.Location = new Point(47, 202);
            btnSearchFilterOrders.Name = "btnSearchFilterOrders";
            btnSearchFilterOrders.Size = new Size(211, 29);
            btnSearchFilterOrders.TabIndex = 8;
            btnSearchFilterOrders.Text = "Search/Filter All Orders";
            btnSearchFilterOrders.UseVisualStyleBackColor = false;
            // 
            // btnPaymentCreditTabManagement
            // 
            btnPaymentCreditTabManagement.BackColor = Color.FromArgb(55, 138, 221);
            btnPaymentCreditTabManagement.FlatStyle = FlatStyle.Flat;
            btnPaymentCreditTabManagement.ForeColor = Color.White;
            btnPaymentCreditTabManagement.Location = new Point(47, 292);
            btnPaymentCreditTabManagement.Name = "btnPaymentCreditTabManagement";
            btnPaymentCreditTabManagement.Size = new Size(211, 29);
            btnPaymentCreditTabManagement.TabIndex = 9;
            btnPaymentCreditTabManagement.Text = "Payment and Credit/Tab Management";
            btnPaymentCreditTabManagement.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(55, 138, 221);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(47, 158);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(211, 29);
            btnReports.TabIndex = 10;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnIncomeExpense
            // 
            btnIncomeExpense.BackColor = Color.FromArgb(55, 138, 221);
            btnIncomeExpense.FlatStyle = FlatStyle.Flat;
            btnIncomeExpense.ForeColor = Color.White;
            btnIncomeExpense.Location = new Point(47, 247);
            btnIncomeExpense.Name = "btnIncomeExpense";
            btnIncomeExpense.Size = new Size(211, 29);
            btnIncomeExpense.TabIndex = 11;
            btnIncomeExpense.Text = "Income and Expense";
            btnIncomeExpense.UseVisualStyleBackColor = false;
            // 
            // btnAdminManagement
            // 
            btnAdminManagement.BackColor = Color.FromArgb(55, 138, 221);
            btnAdminManagement.FlatStyle = FlatStyle.Flat;
            btnAdminManagement.ForeColor = Color.White;
            btnAdminManagement.Location = new Point(47, 338);
            btnAdminManagement.Name = "btnAdminManagement";
            btnAdminManagement.Size = new Size(211, 29);
            btnAdminManagement.TabIndex = 12;
            btnAdminManagement.Text = "Admin Management";
            btnAdminManagement.UseVisualStyleBackColor = false;
            // 
            // dgvstatus
            // 
            dgvstatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvstatus.BackgroundColor = Color.White;
            dgvstatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvstatus.Columns.AddRange(new DataGridViewColumn[] { order, customer, Driver, status });
            dgvstatus.Location = new Point(360, 113);
            dgvstatus.Name = "dgvstatus";
            dgvstatus.RowHeadersWidth = 51;
            dgvstatus.Size = new Size(551, 298);
            dgvstatus.TabIndex = 0;
            dgvstatus.CellContentClick += dgvstatus_CellContentClick;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // Driver
            // 
            Driver.HeaderText = "Driver";
            Driver.MinimumWidth = 6;
            Driver.Name = "Driver";
            // 
            // customer
            // 
            customer.HeaderText = "Customer";
            customer.MinimumWidth = 6;
            customer.Name = "customer";
            // 
            // order
            // 
            order.HeaderText = "Order";
            order.MinimumWidth = 6;
            order.Name = "order";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(961, 421);
            Controls.Add(dgvstatus);
            Controls.Add(pnlHeader);
            Controls.Add(pnlIncome);
            Controls.Add(pnlDelivered);
            Controls.Add(pnlAssigned);
            Controls.Add(pnlPending);
            Name = "Form1";
            Text = "Dashboard";
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlAssigned.ResumeLayout(false);
            pnlAssigned.PerformLayout();
            pnlDelivered.ResumeLayout(false);
            pnlDelivered.PerformLayout();
            pnlIncome.ResumeLayout(false);
            pnlIncome.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvstatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDashTitle;
        private Panel pnlPending;
        private Label lblPendingTitle;
        private Label lblPendingValue;
        private Panel pnlAssigned;
        private Label lblAssignedValue;
        private Label lblAssignedTitle;
        private Panel pnlDelivered;
        private Label lblDeliveredValue;
        private Label lblDeliveredTitle;
        private Panel pnlIncome;
        private Label lblIncomeTitle;
        private Label lblIncomeValue;
        private Panel pnlHeader;
        private Button btnOrderManagement;
        private Button btnSearchFilterOrders;
        private Button btnPaymentCreditTabManagement;
        private Button btnReports;
        private Button btnIncomeExpense;
        private Button btnAdminManagement;
        private DataGridView dgvstatus;
        private DataGridViewTextBoxColumn order;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn Driver;
        private DataGridViewTextBoxColumn status;
    }
}
