namespace My_credit
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            pnlBalance = new Panel();
            lblLimitRef = new Label();
            lblBalanceValue = new Label();
            lblBalanceTitle = new Label();
            dghistory = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            order = new DataGridViewTextBoxColumn();
            balance = new DataGridViewTextBoxColumn();
            pnlBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dghistory).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(55, 138, 221);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(818, 70);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(22, 138, 221);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 1;
            label1.Text = "My Credit/Tab";
            label1.Click += label1_Click;
            // 
            // pnlBalance
            // 
            pnlBalance.BackColor = Color.White;
            pnlBalance.Controls.Add(lblLimitRef);
            pnlBalance.Controls.Add(lblBalanceValue);
            pnlBalance.Controls.Add(lblBalanceTitle);
            pnlBalance.Location = new Point(20, 90);
            pnlBalance.Name = "pnlBalance";
            pnlBalance.Size = new Size(760, 126);
            pnlBalance.TabIndex = 1;
            // 
            // lblLimitRef
            // 
            lblLimitRef.AutoSize = true;
            lblLimitRef.ForeColor = Color.Gray;
            lblLimitRef.Location = new Point(319, 88);
            lblLimitRef.Name = "lblLimitRef";
            lblLimitRef.Size = new Size(105, 20);
            lblLimitRef.TabIndex = 2;
            lblLimitRef.Text = "of ₱1,000 limit";
            lblLimitRef.Click += lblLimitRef_Click;
            // 
            // lblBalanceValue
            // 
            lblBalanceValue.AutoSize = true;
            lblBalanceValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalanceValue.ForeColor = Color.FromArgb(12, 68, 124);
            lblBalanceValue.Location = new Point(341, 34);
            lblBalanceValue.Name = "lblBalanceValue";
            lblBalanceValue.Size = new Size(72, 54);
            lblBalanceValue.TabIndex = 1;
            lblBalanceValue.Text = "₱0";
            // 
            // lblBalanceTitle
            // 
            lblBalanceTitle.AutoSize = true;
            lblBalanceTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalanceTitle.ForeColor = Color.Gray;
            lblBalanceTitle.Location = new Point(319, 14);
            lblBalanceTitle.Name = "lblBalanceTitle";
            lblBalanceTitle.Size = new Size(113, 20);
            lblBalanceTitle.TabIndex = 0;
            lblBalanceTitle.Text = "Current Balance";
            lblBalanceTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dghistory
            // 
            dghistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dghistory.BackgroundColor = SystemColors.ButtonHighlight;
            dghistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dghistory.Columns.AddRange(new DataGridViewColumn[] { date, order, balance });
            dghistory.GridColor = SystemColors.ActiveBorder;
            dghistory.Location = new Point(20, 250);
            dghistory.Name = "dghistory";
            dghistory.RowHeadersWidth = 51;
            dghistory.Size = new Size(760, 188);
            dghistory.TabIndex = 2;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // order
            // 
            order.HeaderText = "Order";
            order.MinimumWidth = 6;
            order.Name = "order";
            // 
            // balance
            // 
            balance.HeaderText = "Balance";
            balance.MinimumWidth = 6;
            balance.Name = "balance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dghistory);
            Controls.Add(label1);
            Controls.Add(pnlBalance);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Credit/Tab";
            Load += Form1_Load;
            pnlBalance.ResumeLayout(false);
            pnlBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dghistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel pnlBalance;
        private Label lblBalanceTitle;
        private Label lblLimitRef;
        private Label lblBalanceValue;
        private DataGridView dghistory;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn order;
        private DataGridViewTextBoxColumn balance;
    }
}
