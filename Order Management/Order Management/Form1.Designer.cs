namespace Order_Management
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
            cmbStatusFilter = new ComboBox();
            pnlOrdersTable = new Panel();
            pnlHeaderDivider = new Panel();
            lblColDriver = new Label();
            lblColStatus = new Label();
            lblColQuantity = new Label();
            lblColAddress = new Label();
            lblColCustomer = new Label();
            lblColOrderId = new Label();
            pnlHeader = new Panel();
            pnlOrdersTable.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(13, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Order Management";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All status", "Pending", "Assigned", "Delivered", "Failed" });
            cmbStatusFilter.Location = new Point(708, 60);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(151, 28);
            cmbStatusFilter.TabIndex = 1;
            // 
            // pnlOrdersTable
            // 
            pnlOrdersTable.BackColor = Color.White;
            pnlOrdersTable.Controls.Add(pnlHeaderDivider);
            pnlOrdersTable.Controls.Add(lblColDriver);
            pnlOrdersTable.Controls.Add(lblColStatus);
            pnlOrdersTable.Controls.Add(lblColQuantity);
            pnlOrdersTable.Controls.Add(lblColAddress);
            pnlOrdersTable.Controls.Add(lblColCustomer);
            pnlOrdersTable.Controls.Add(lblColOrderId);
            pnlOrdersTable.Location = new Point(20, 94);
            pnlOrdersTable.Name = "pnlOrdersTable";
            pnlOrdersTable.Size = new Size(839, 485);
            pnlOrdersTable.TabIndex = 2;
            // 
            // pnlHeaderDivider
            // 
            pnlHeaderDivider.BackColor = Color.Gray;
            pnlHeaderDivider.Location = new Point(15, 40);
            pnlHeaderDivider.Name = "pnlHeaderDivider";
            pnlHeaderDivider.Size = new Size(810, 1);
            pnlHeaderDivider.TabIndex = 6;
            // 
            // lblColDriver
            // 
            lblColDriver.AutoSize = true;
            lblColDriver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColDriver.ForeColor = Color.Gray;
            lblColDriver.Location = new Point(708, 15);
            lblColDriver.Name = "lblColDriver";
            lblColDriver.Size = new Size(52, 20);
            lblColDriver.TabIndex = 5;
            lblColDriver.Text = "Driver";
            // 
            // lblColStatus
            // 
            lblColStatus.AutoSize = true;
            lblColStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColStatus.ForeColor = Color.Gray;
            lblColStatus.Location = new Point(550, 15);
            lblColStatus.Name = "lblColStatus";
            lblColStatus.Size = new Size(53, 20);
            lblColStatus.TabIndex = 4;
            lblColStatus.Text = "Status";
            // 
            // lblColQuantity
            // 
            lblColQuantity.AutoSize = true;
            lblColQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColQuantity.ForeColor = Color.Gray;
            lblColQuantity.Location = new Point(390, 15);
            lblColQuantity.Name = "lblColQuantity";
            lblColQuantity.Size = new Size(70, 20);
            lblColQuantity.TabIndex = 3;
            lblColQuantity.Text = "Quantity";
            // 
            // lblColAddress
            // 
            lblColAddress.AutoSize = true;
            lblColAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColAddress.ForeColor = Color.Gray;
            lblColAddress.Location = new Point(245, 15);
            lblColAddress.Name = "lblColAddress";
            lblColAddress.Size = new Size(66, 20);
            lblColAddress.TabIndex = 2;
            lblColAddress.Text = "Address";
            // 
            // lblColCustomer
            // 
            lblColCustomer.AutoSize = true;
            lblColCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColCustomer.ForeColor = Color.Gray;
            lblColCustomer.Location = new Point(100, 15);
            lblColCustomer.Name = "lblColCustomer";
            lblColCustomer.Size = new Size(77, 20);
            lblColCustomer.TabIndex = 1;
            lblColCustomer.Text = "Customer";
            // 
            // lblColOrderId
            // 
            lblColOrderId.AutoSize = true;
            lblColOrderId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColOrderId.ForeColor = Color.Gray;
            lblColOrderId.Location = new Point(15, 15);
            lblColOrderId.Name = "lblColOrderId";
            lblColOrderId.Size = new Size(69, 20);
            lblColOrderId.TabIndex = 0;
            lblColOrderId.Text = "Order ID";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(-1, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(885, 54);
            pnlHeader.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(882, 603);
            Controls.Add(pnlHeader);
            Controls.Add(pnlOrdersTable);
            Controls.Add(cmbStatusFilter);
            Name = "Form1";
            Text = "Order Management";
            pnlOrdersTable.ResumeLayout(false);
            pnlOrdersTable.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbStatusFilter;
        private Panel pnlOrdersTable;
        private Label lblColOrderId;
        private Label lblColStatus;
        private Label lblColQuantity;
        private Label lblColAddress;
        private Label lblColCustomer;
        private Panel pnlHeaderDivider;
        private Label lblColDriver;
        private Panel pnlHeader;
    }
}
