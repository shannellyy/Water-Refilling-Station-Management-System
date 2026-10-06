namespace Search_Filter_All_Orders
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
            lblTitle = new Label();
            txtSearch = new TextBox();
            cmbDriverFilter = new ComboBox();
            cmbStatusFilter = new ComboBox();
            dtpFrom = new DateTimePicker();
            dptTo = new DateTimePicker();
            cmbAreaFilter = new ComboBox();
            btnSearch = new Button();
            pnlHeader = new Panel();
            dgvResults = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Driver = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(13, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search/Filter All Orders";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbDriverFilter
            // 
            cmbDriverFilter.FormattingEnabled = true;
            cmbDriverFilter.Location = new Point(295, 61);
            cmbDriverFilter.Name = "cmbDriverFilter";
            cmbDriverFilter.Size = new Size(180, 28);
            cmbDriverFilter.TabIndex = 2;
            cmbDriverFilter.SelectedIndexChanged += cmbDriverFilter_SelectedIndexChanged;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Location = new Point(490, 60);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(180, 28);
            cmbStatusFilter.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(20, 95);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 27);
            dtpFrom.TabIndex = 4;
            // 
            // dptTo
            // 
            dptTo.Format = DateTimePickerFormat.Short;
            dptTo.Location = new Point(235, 95);
            dptTo.Name = "dptTo";
            dptTo.Size = new Size(200, 27);
            dptTo.TabIndex = 5;
            // 
            // cmbAreaFilter
            // 
            cmbAreaFilter.FormattingEnabled = true;
            cmbAreaFilter.Items.AddRange(new object[] { "All areas", "Purok 1", "Purok 2", "Purok 3" });
            cmbAreaFilter.Location = new Point(450, 95);
            cmbAreaFilter.Name = "cmbAreaFilter";
            cmbAreaFilter.Size = new Size(220, 28);
            cmbAreaFilter.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(55, 138, 221);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(690, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(-1, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(809, 54);
            pnlHeader.TabIndex = 9;
            // 
            // dgvResults
            // 
            dgvResults.BackgroundColor = Color.White;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { OrderID, Customer, Driver, Date, Status });
            dgvResults.Location = new Point(59, 149);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(677, 342);
            dgvResults.TabIndex = 0;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "Order ID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.Width = 125;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            Customer.Width = 125;
            // 
            // Driver
            // 
            Driver.HeaderText = "Driver";
            Driver.MinimumWidth = 6;
            Driver.Name = "Driver";
            Driver.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(804, 503);
            Controls.Add(dgvResults);
            Controls.Add(pnlHeader);
            Controls.Add(btnSearch);
            Controls.Add(cmbAreaFilter);
            Controls.Add(dptTo);
            Controls.Add(dtpFrom);
            Controls.Add(cmbStatusFilter);
            Controls.Add(cmbDriverFilter);
            Controls.Add(txtSearch);
            Name = "Form1";
            Text = "Search/Filter All Orders";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtSearch;
        private ComboBox cmbDriverFilter;
        private ComboBox cmbStatusFilter;
        private DateTimePicker dtpFrom;
        private DateTimePicker dptTo;
        private ComboBox cmbAreaFilter;
        private Button btnSearch;
        private Panel pnlHeader;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Driver;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
    }
}
