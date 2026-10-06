namespace CustomerDashboard
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
            lblHeaderName = new Label();
            lblHeader = new Label();
            pnlActiveOrder = new Panel();
            lblActiveOrderTitle = new Label();
            pnlCreditTab = new Panel();
            lblCreditTitle = new Label();
            pnlScheduleInfo = new Panel();
            lblScheduleInfo = new Label();
            btnPlaceOrder = new Button();
            btnMyOrders = new Button();
            btnCreditTab = new Button();
            btnSearchOrders = new Button();
            pnlHeader.SuspendLayout();
            pnlActiveOrder.SuspendLayout();
            pnlCreditTab.SuspendLayout();
            pnlScheduleInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(btnCreditTab);
            pnlHeader.Controls.Add(btnSearchOrders);
            pnlHeader.Controls.Add(lblHeaderName);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(btnMyOrders);
            pnlHeader.Controls.Add(btnPlaceOrder);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(266, 371);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderName
            // 
            lblHeaderName.AutoSize = true;
            lblHeaderName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderName.ForeColor = Color.White;
            lblHeaderName.Location = new Point(20, 32);
            lblHeaderName.Name = "lblHeaderName";
            lblHeaderName.Size = new Size(117, 31);
            lblHeaderName.TabIndex = 1;
            lblHeaderName.Text = "Customer";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(109, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Welcome Back,";
            // 
            // pnlActiveOrder
            // 
            pnlActiveOrder.BackColor = Color.White;
            pnlActiveOrder.Controls.Add(lblActiveOrderTitle);
            pnlActiveOrder.Location = new Point(305, 118);
            pnlActiveOrder.Name = "pnlActiveOrder";
            pnlActiveOrder.Size = new Size(297, 80);
            pnlActiveOrder.TabIndex = 1;
            // 
            // lblActiveOrderTitle
            // 
            lblActiveOrderTitle.AutoSize = true;
            lblActiveOrderTitle.ForeColor = Color.Gray;
            lblActiveOrderTitle.Location = new Point(15, 10);
            lblActiveOrderTitle.Name = "lblActiveOrderTitle";
            lblActiveOrderTitle.Size = new Size(92, 20);
            lblActiveOrderTitle.TabIndex = 0;
            lblActiveOrderTitle.Text = "Active Order";
            // 
            // pnlCreditTab
            // 
            pnlCreditTab.BackColor = Color.White;
            pnlCreditTab.Controls.Add(lblCreditTitle);
            pnlCreditTab.Location = new Point(621, 118);
            pnlCreditTab.Name = "pnlCreditTab";
            pnlCreditTab.Size = new Size(297, 80);
            pnlCreditTab.TabIndex = 2;
            // 
            // lblCreditTitle
            // 
            lblCreditTitle.AutoSize = true;
            lblCreditTitle.ForeColor = Color.Gray;
            lblCreditTitle.Location = new Point(15, 12);
            lblCreditTitle.Name = "lblCreditTitle";
            lblCreditTitle.Size = new Size(78, 20);
            lblCreditTitle.TabIndex = 0;
            lblCreditTitle.Text = "Credit/Tab";
            // 
            // pnlScheduleInfo
            // 
            pnlScheduleInfo.BackColor = Color.FromArgb(230, 241, 251);
            pnlScheduleInfo.Controls.Add(lblScheduleInfo);
            pnlScheduleInfo.Location = new Point(305, 234);
            pnlScheduleInfo.Name = "pnlScheduleInfo";
            pnlScheduleInfo.Size = new Size(613, 45);
            pnlScheduleInfo.TabIndex = 3;
            // 
            // lblScheduleInfo
            // 
            lblScheduleInfo.AutoSize = true;
            lblScheduleInfo.ForeColor = Color.FromArgb(12, 68, 124);
            lblScheduleInfo.Location = new Point(254, 13);
            lblScheduleInfo.Name = "lblScheduleInfo";
            lblScheduleInfo.Size = new Size(111, 20);
            lblScheduleInfo.TabIndex = 0;
            lblScheduleInfo.Text = "Area Schedule: ";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(55, 138, 221);
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(20, 101);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(221, 40);
            btnPlaceOrder.TabIndex = 4;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // btnMyOrders
            // 
            btnMyOrders.BackColor = Color.FromArgb(55, 138, 221);
            btnMyOrders.FlatStyle = FlatStyle.Flat;
            btnMyOrders.ForeColor = Color.White;
            btnMyOrders.Location = new Point(20, 158);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Size = new Size(221, 40);
            btnMyOrders.TabIndex = 5;
            btnMyOrders.Text = "My Orders";
            btnMyOrders.UseVisualStyleBackColor = false;
            // 
            // btnCreditTab
            // 
            btnCreditTab.BackColor = Color.FromArgb(55, 138, 221);
            btnCreditTab.FlatStyle = FlatStyle.Flat;
            btnCreditTab.ForeColor = Color.White;
            btnCreditTab.Location = new Point(20, 268);
            btnCreditTab.Name = "btnCreditTab";
            btnCreditTab.Size = new Size(221, 40);
            btnCreditTab.TabIndex = 6;
            btnCreditTab.Text = "Credit/Tab";
            btnCreditTab.UseVisualStyleBackColor = false;
            // 
            // btnSearchOrders
            // 
            btnSearchOrders.BackColor = Color.FromArgb(55, 138, 221);
            btnSearchOrders.FlatStyle = FlatStyle.Flat;
            btnSearchOrders.ForeColor = Color.White;
            btnSearchOrders.Location = new Point(20, 213);
            btnSearchOrders.Name = "btnSearchOrders";
            btnSearchOrders.Size = new Size(221, 40);
            btnSearchOrders.TabIndex = 7;
            btnSearchOrders.Text = "Search Orders";
            btnSearchOrders.UseVisualStyleBackColor = false;
            btnSearchOrders.Click += btnSearchOrders_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(930, 370);
            Controls.Add(pnlScheduleInfo);
            Controls.Add(pnlCreditTab);
            Controls.Add(pnlActiveOrder);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Customer Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlActiveOrder.ResumeLayout(false);
            pnlActiveOrder.PerformLayout();
            pnlCreditTab.ResumeLayout(false);
            pnlCreditTab.PerformLayout();
            pnlScheduleInfo.ResumeLayout(false);
            pnlScheduleInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderName;
        private Label lblHeader;
        private Panel pnlActiveOrder;
        private Label lblActiveOrderTitle;
        private Panel pnlCreditTab;
        private Label lblCreditTitle;
        private Panel pnlScheduleInfo;
        private Label lblScheduleInfo;
        private Button btnPlaceOrder;
        private Button btnMyOrders;
        private Button btnCreditTab;
        private Button btnSearchOrders;
    }
}
