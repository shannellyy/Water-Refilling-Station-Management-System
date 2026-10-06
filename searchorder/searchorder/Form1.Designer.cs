namespace searchorder
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
            txtSearch = new TextBox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(818, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(55, 138, 221);
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Search Orders";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 90);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(759, 27);
            txtSearch.TabIndex = 2;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(20, 135);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(285, 135);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All status", "Pending", "Out for Delivery", "Delivered", "Failed" });
            cmbStatus.Location = new Point(550, 135);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(229, 28);
            cmbStatus.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStatus);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(txtSearch);
            Controls.Add(lblTitle);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Search Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private TextBox txtSearch;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private ComboBox cmbStatus;
    }
}
