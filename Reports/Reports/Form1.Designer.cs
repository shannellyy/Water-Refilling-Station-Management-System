namespace Reports
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
            btnWeekly = new Button();
            btnDaily = new Button();
            btnMonthly = new Button();
            pnlOrderVolume = new Panel();
            lblOrderVolume = new Label();
            pnlDeliveredvsFailed = new Panel();
            lblDeliveredvsFailed = new Label();
            lblDelivered = new Label();
            lblFailed = new Label();
            pnlCreditBalance = new Panel();
            lblHeaderCreditBalance = new Label();
            lblCreditValue = new Label();
            pnlHeader.SuspendLayout();
            pnlOrderVolume.SuspendLayout();
            pnlDeliveredvsFailed.SuspendLayout();
            pnlCreditBalance.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(806, 54);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(97, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports";
            // 
            // btnWeekly
            // 
            btnWeekly.BackColor = Color.FromArgb(55, 138, 221);
            btnWeekly.FlatStyle = FlatStyle.Flat;
            btnWeekly.ForeColor = Color.White;
            btnWeekly.Location = new Point(494, 60);
            btnWeekly.Name = "btnWeekly";
            btnWeekly.Size = new Size(94, 29);
            btnWeekly.TabIndex = 1;
            btnWeekly.Text = "Weekly";
            btnWeekly.UseVisualStyleBackColor = false;
            // 
            // btnDaily
            // 
            btnDaily.BackColor = Color.White;
            btnDaily.FlatStyle = FlatStyle.Flat;
            btnDaily.Location = new Point(594, 60);
            btnDaily.Name = "btnDaily";
            btnDaily.Size = new Size(94, 29);
            btnDaily.TabIndex = 2;
            btnDaily.Text = "Daily";
            btnDaily.UseVisualStyleBackColor = false;
            // 
            // btnMonthly
            // 
            btnMonthly.BackColor = Color.White;
            btnMonthly.FlatStyle = FlatStyle.Flat;
            btnMonthly.Location = new Point(694, 60);
            btnMonthly.Name = "btnMonthly";
            btnMonthly.Size = new Size(94, 29);
            btnMonthly.TabIndex = 3;
            btnMonthly.Text = "Monthly";
            btnMonthly.UseVisualStyleBackColor = false;
            // 
            // pnlOrderVolume
            // 
            pnlOrderVolume.BackColor = Color.White;
            pnlOrderVolume.Controls.Add(lblOrderVolume);
            pnlOrderVolume.Location = new Point(12, 95);
            pnlOrderVolume.Name = "pnlOrderVolume";
            pnlOrderVolume.Size = new Size(538, 220);
            pnlOrderVolume.TabIndex = 4;
            // 
            // lblOrderVolume
            // 
            lblOrderVolume.AutoSize = true;
            lblOrderVolume.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderVolume.ForeColor = Color.Gray;
            lblOrderVolume.Location = new Point(8, 9);
            lblOrderVolume.Name = "lblOrderVolume";
            lblOrderVolume.Size = new Size(188, 20);
            lblOrderVolume.TabIndex = 0;
            lblOrderVolume.Text = "Order Volume (this week)";
            // 
            // pnlDeliveredvsFailed
            // 
            pnlDeliveredvsFailed.BackColor = Color.White;
            pnlDeliveredvsFailed.Controls.Add(lblFailed);
            pnlDeliveredvsFailed.Controls.Add(lblDelivered);
            pnlDeliveredvsFailed.Controls.Add(lblDeliveredvsFailed);
            pnlDeliveredvsFailed.Location = new Point(556, 95);
            pnlDeliveredvsFailed.Name = "pnlDeliveredvsFailed";
            pnlDeliveredvsFailed.Size = new Size(232, 220);
            pnlDeliveredvsFailed.TabIndex = 5;
            // 
            // lblDeliveredvsFailed
            // 
            lblDeliveredvsFailed.AutoSize = true;
            lblDeliveredvsFailed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeliveredvsFailed.ForeColor = Color.Gray;
            lblDeliveredvsFailed.Location = new Point(12, 9);
            lblDeliveredvsFailed.Name = "lblDeliveredvsFailed";
            lblDeliveredvsFailed.Size = new Size(139, 20);
            lblDeliveredvsFailed.TabIndex = 0;
            lblDeliveredvsFailed.Text = "Delivered vs Failed";
            // 
            // lblDelivered
            // 
            lblDelivered.AutoSize = true;
            lblDelivered.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelivered.Location = new Point(12, 50);
            lblDelivered.Name = "lblDelivered";
            lblDelivered.Size = new Size(92, 23);
            lblDelivered.TabIndex = 1;
            lblDelivered.Text = "Delivered:";
            // 
            // lblFailed
            // 
            lblFailed.AutoSize = true;
            lblFailed.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFailed.Location = new Point(12, 86);
            lblFailed.Name = "lblFailed";
            lblFailed.Size = new Size(62, 23);
            lblFailed.TabIndex = 2;
            lblFailed.Text = "Failed:";
            // 
            // pnlCreditBalance
            // 
            pnlCreditBalance.BackColor = Color.White;
            pnlCreditBalance.Controls.Add(lblCreditValue);
            pnlCreditBalance.Controls.Add(lblHeaderCreditBalance);
            pnlCreditBalance.Location = new Point(12, 321);
            pnlCreditBalance.Name = "pnlCreditBalance";
            pnlCreditBalance.Size = new Size(776, 125);
            pnlCreditBalance.TabIndex = 6;
            // 
            // lblHeaderCreditBalance
            // 
            lblHeaderCreditBalance.AutoSize = true;
            lblHeaderCreditBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderCreditBalance.ForeColor = Color.Gray;
            lblHeaderCreditBalance.Location = new Point(8, 9);
            lblHeaderCreditBalance.Name = "lblHeaderCreditBalance";
            lblHeaderCreditBalance.Size = new Size(163, 23);
            lblHeaderCreditBalance.TabIndex = 0;
            lblHeaderCreditBalance.Text = "Credit/Tab Balance";
            lblHeaderCreditBalance.Click += lblHeaderCreditBalance_Click;
            // 
            // lblCreditValue
            // 
            lblCreditValue.AutoSize = true;
            lblCreditValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreditValue.ForeColor = Color.DarkBlue;
            lblCreditValue.Location = new Point(8, 49);
            lblCreditValue.Name = "lblCreditValue";
            lblCreditValue.Size = new Size(72, 54);
            lblCreditValue.TabIndex = 1;
            lblCreditValue.Text = "₱0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCreditBalance);
            Controls.Add(pnlDeliveredvsFailed);
            Controls.Add(pnlOrderVolume);
            Controls.Add(btnMonthly);
            Controls.Add(btnDaily);
            Controls.Add(btnWeekly);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Reports";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlOrderVolume.ResumeLayout(false);
            pnlOrderVolume.PerformLayout();
            pnlDeliveredvsFailed.ResumeLayout(false);
            pnlDeliveredvsFailed.PerformLayout();
            pnlCreditBalance.ResumeLayout(false);
            pnlCreditBalance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnWeekly;
        private Button btnDaily;
        private Button btnMonthly;
        private Panel pnlOrderVolume;
        private Label lblOrderVolume;
        private Panel pnlDeliveredvsFailed;
        private Label lblDeliveredvsFailed;
        private Label lblFailed;
        private Label lblDelivered;
        private Panel pnlCreditBalance;
        private Label lblHeaderCreditBalance;
        private Label lblCreditValue;
    }
}
