namespace myorders
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
            lblHeaderTitle = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblStatus1 = new Label();
            lblOrder1 = new Label();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(20, 22);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(125, 31);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "My Orders";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblStatus1);
            panel1.Controls.Add(lblOrder1);
            panel1.Location = new Point(50, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 65);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 2;
            label1.Text = "Jul 22, 9:15 AM - 3 gallons - 75.00";
            // 
            // lblStatus1
            // 
            lblStatus1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus1.AutoSize = true;
            lblStatus1.BackColor = Color.FromArgb(225, 245, 238);
            lblStatus1.ForeColor = Color.FromArgb(8, 80, 65);
            lblStatus1.Location = new Point(600, 15);
            lblStatus1.Name = "lblStatus1";
            lblStatus1.Size = new Size(73, 20);
            lblStatus1.TabIndex = 1;
            lblStatus1.Text = "Delivered";
            lblStatus1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrder1
            // 
            lblOrder1.AutoSize = true;
            lblOrder1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrder1.Location = new Point(15, 12);
            lblOrder1.Name = "lblOrder1";
            lblOrder1.Size = new Size(112, 23);
            lblOrder1.TabIndex = 0;
            lblOrder1.Text = "Order #1042";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Orders";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Panel panel1;
        private Label lblStatus1;
        private Label lblOrder1;
        private Label label1;
    }
}
