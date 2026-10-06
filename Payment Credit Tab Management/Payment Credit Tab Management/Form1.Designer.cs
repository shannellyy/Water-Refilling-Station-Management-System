namespace Payment_Credit_Tab_Management
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            dgvCustomers = new DataGridView();
            Customer = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            Save = new DataGridViewButtonColumn();
            pnlRecordPayment = new Panel();
            btnRecordPayment = new Button();
            cmbPaymentType = new ComboBox();
            txtPaymentAmount = new TextBox();
            cmbPaymentCustomer = new ComboBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            pnlRecordPayment.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(805, 54);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(419, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payment and Credit/Tab Management";
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { Customer, Balance, Save });
            dgvCustomers.Location = new Point(20, 60);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(427, 350);
            dgvCustomers.TabIndex = 0;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            Customer.Width = 125;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.Width = 125;
            // 
            // Save
            // 
            Save.HeaderText = "Save";
            Save.MinimumWidth = 6;
            Save.Name = "Save";
            Save.Width = 125;
            // 
            // pnlRecordPayment
            // 
            pnlRecordPayment.BackColor = Color.White;
            pnlRecordPayment.Controls.Add(btnRecordPayment);
            pnlRecordPayment.Controls.Add(cmbPaymentType);
            pnlRecordPayment.Controls.Add(txtPaymentAmount);
            pnlRecordPayment.Controls.Add(cmbPaymentCustomer);
            pnlRecordPayment.Location = new Point(468, 60);
            pnlRecordPayment.Name = "pnlRecordPayment";
            pnlRecordPayment.Size = new Size(308, 220);
            pnlRecordPayment.TabIndex = 1;
            // 
            // btnRecordPayment
            // 
            btnRecordPayment.BackColor = Color.FromArgb(55, 138, 221);
            btnRecordPayment.FlatStyle = FlatStyle.Flat;
            btnRecordPayment.ForeColor = Color.White;
            btnRecordPayment.Location = new Point(107, 179);
            btnRecordPayment.Name = "btnRecordPayment";
            btnRecordPayment.Size = new Size(94, 29);
            btnRecordPayment.TabIndex = 3;
            btnRecordPayment.Text = "Record";
            btnRecordPayment.UseVisualStyleBackColor = false;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Full Payment", "Partial", "Add to credit" });
            cmbPaymentType.Location = new Point(15, 135);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(278, 28);
            cmbPaymentType.TabIndex = 2;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Location = new Point(15, 88);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.PlaceholderText = "Amount";
            txtPaymentAmount.Size = new Size(278, 27);
            txtPaymentAmount.TabIndex = 1;
            // 
            // cmbPaymentCustomer
            // 
            cmbPaymentCustomer.AutoCompleteCustomSource.AddRange(new string[] { "Select Customer" });
            cmbPaymentCustomer.FormattingEnabled = true;
            cmbPaymentCustomer.Items.AddRange(new object[] { "Select Customer" });
            cmbPaymentCustomer.Location = new Point(15, 45);
            cmbPaymentCustomer.Name = "cmbPaymentCustomer";
            cmbPaymentCustomer.Size = new Size(278, 28);
            cmbPaymentCustomer.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRecordPayment);
            Controls.Add(dgvCustomers);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Payment & Credit/Tab Management";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            pnlRecordPayment.ResumeLayout(false);
            pnlRecordPayment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewButtonColumn Save;
        private Panel pnlRecordPayment;
        private ComboBox cmbPaymentCustomer;
        private ComboBox cmbPaymentType;
        private TextBox txtPaymentAmount;
        private Button btnRecordPayment;
    }
}
