namespace Admin_Management_Screen
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRemoveDriver = new Button();
            btnEditDriver = new Button();
            btnAddDriver = new Button();
            txtDriverPhone = new TextBox();
            txtDriverName = new TextBox();
            tabPage2 = new TabPage();
            btnDeleteZone = new Button();
            txtSched = new TextBox();
            btnEditZone = new Button();
            btnAddZone = new Button();
            txtCoverageArea = new TextBox();
            txtZoneName = new TextBox();
            tabPage3 = new TabPage();
            btnSavePrice = new Button();
            txtPrice = new TextBox();
            cmbContainerSize = new ComboBox();
            tabPage4 = new TabPage();
            txtCredit = new TextBox();
            txtCustomerName = new TextBox();
            btnSaveCreditLimits = new Button();
            pnlHeader = new Panel();
            btnback = new Button();
            lblHeader = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "Delivery Zones";
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 60);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(640, 306);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientInactiveCaption;
            tabPage1.Controls.Add(btnRemoveDriver);
            tabPage1.Controls.Add(btnEditDriver);
            tabPage1.Controls.Add(btnAddDriver);
            tabPage1.Controls.Add(txtDriverPhone);
            tabPage1.Controls.Add(txtDriverName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(632, 273);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Drivers";
            // 
            // btnRemoveDriver
            // 
            btnRemoveDriver.BackColor = Color.FromArgb(55, 138, 221);
            btnRemoveDriver.FlatStyle = FlatStyle.Flat;
            btnRemoveDriver.ForeColor = Color.White;
            btnRemoveDriver.Location = new Point(414, 188);
            btnRemoveDriver.Margin = new Padding(2);
            btnRemoveDriver.Name = "btnRemoveDriver";
            btnRemoveDriver.Size = new Size(130, 27);
            btnRemoveDriver.TabIndex = 5;
            btnRemoveDriver.Text = "Remove Driver";
            btnRemoveDriver.UseVisualStyleBackColor = false;
            // 
            // btnEditDriver
            // 
            btnEditDriver.BackColor = Color.FromArgb(55, 138, 221);
            btnEditDriver.FlatStyle = FlatStyle.Flat;
            btnEditDriver.ForeColor = Color.White;
            btnEditDriver.Location = new Point(251, 188);
            btnEditDriver.Margin = new Padding(2);
            btnEditDriver.Name = "btnEditDriver";
            btnEditDriver.Size = new Size(90, 27);
            btnEditDriver.TabIndex = 4;
            btnEditDriver.Text = "Edit Driver";
            btnEditDriver.UseVisualStyleBackColor = false;
            // 
            // btnAddDriver
            // 
            btnAddDriver.BackColor = Color.FromArgb(55, 138, 221);
            btnAddDriver.FlatStyle = FlatStyle.Flat;
            btnAddDriver.ForeColor = Color.White;
            btnAddDriver.Location = new Point(85, 188);
            btnAddDriver.Margin = new Padding(2);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(90, 27);
            btnAddDriver.TabIndex = 3;
            btnAddDriver.Text = "Add Driver";
            btnAddDriver.UseVisualStyleBackColor = false;
            // 
            // txtDriverPhone
            // 
            txtDriverPhone.Location = new Point(85, 104);
            txtDriverPhone.Margin = new Padding(2);
            txtDriverPhone.Name = "txtDriverPhone";
            txtDriverPhone.PlaceholderText = "Driver Phone Number";
            txtDriverPhone.Size = new Size(459, 27);
            txtDriverPhone.TabIndex = 2;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(85, 60);
            txtDriverName.Margin = new Padding(2);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.PlaceholderText = "Driver Name";
            txtDriverName.Size = new Size(459, 27);
            txtDriverName.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientInactiveCaption;
            tabPage2.Controls.Add(btnDeleteZone);
            tabPage2.Controls.Add(txtSched);
            tabPage2.Controls.Add(btnEditZone);
            tabPage2.Controls.Add(btnAddZone);
            tabPage2.Controls.Add(txtCoverageArea);
            tabPage2.Controls.Add(txtZoneName);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(632, 273);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delivery Zones";
            // 
            // btnDeleteZone
            // 
            btnDeleteZone.BackColor = Color.FromArgb(55, 138, 221);
            btnDeleteZone.FlatStyle = FlatStyle.Flat;
            btnDeleteZone.ForeColor = Color.White;
            btnDeleteZone.Location = new Point(403, 188);
            btnDeleteZone.Name = "btnDeleteZone";
            btnDeleteZone.Size = new Size(105, 29);
            btnDeleteZone.TabIndex = 6;
            btnDeleteZone.Text = "Delete Zone";
            btnDeleteZone.UseVisualStyleBackColor = false;
            // 
            // txtSched
            // 
            txtSched.Location = new Point(85, 125);
            txtSched.Name = "txtSched";
            txtSched.PlaceholderText = "Schedule";
            txtSched.Size = new Size(467, 27);
            txtSched.TabIndex = 5;
            // 
            // btnEditZone
            // 
            btnEditZone.BackColor = Color.FromArgb(55, 138, 221);
            btnEditZone.FlatStyle = FlatStyle.Flat;
            btnEditZone.ForeColor = Color.White;
            btnEditZone.Location = new Point(271, 188);
            btnEditZone.Margin = new Padding(2);
            btnEditZone.Name = "btnEditZone";
            btnEditZone.Size = new Size(90, 27);
            btnEditZone.TabIndex = 4;
            btnEditZone.Text = "Edit Zone";
            btnEditZone.UseVisualStyleBackColor = false;
            // 
            // btnAddZone
            // 
            btnAddZone.BackColor = Color.FromArgb(55, 138, 221);
            btnAddZone.FlatStyle = FlatStyle.Flat;
            btnAddZone.ForeColor = Color.White;
            btnAddZone.Location = new Point(138, 188);
            btnAddZone.Margin = new Padding(2);
            btnAddZone.Name = "btnAddZone";
            btnAddZone.Size = new Size(90, 27);
            btnAddZone.TabIndex = 3;
            btnAddZone.Text = "Add Zone";
            btnAddZone.UseVisualStyleBackColor = false;
            // 
            // txtCoverageArea
            // 
            txtCoverageArea.Location = new Point(83, 82);
            txtCoverageArea.Margin = new Padding(2);
            txtCoverageArea.Name = "txtCoverageArea";
            txtCoverageArea.PlaceholderText = "Coverage Area";
            txtCoverageArea.Size = new Size(469, 27);
            txtCoverageArea.TabIndex = 2;
            // 
            // txtZoneName
            // 
            txtZoneName.Location = new Point(85, 41);
            txtZoneName.Margin = new Padding(2);
            txtZoneName.Name = "txtZoneName";
            txtZoneName.PlaceholderText = "Zone Name";
            txtZoneName.Size = new Size(469, 27);
            txtZoneName.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.GradientInactiveCaption;
            tabPage3.Controls.Add(btnSavePrice);
            tabPage3.Controls.Add(txtPrice);
            tabPage3.Controls.Add(cmbContainerSize);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(632, 273);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Pricing";
            // 
            // btnSavePrice
            // 
            btnSavePrice.BackColor = Color.FromArgb(55, 138, 221);
            btnSavePrice.FlatStyle = FlatStyle.Flat;
            btnSavePrice.ForeColor = Color.White;
            btnSavePrice.Location = new Point(266, 188);
            btnSavePrice.Margin = new Padding(2);
            btnSavePrice.Name = "btnSavePrice";
            btnSavePrice.Size = new Size(90, 27);
            btnSavePrice.TabIndex = 2;
            btnSavePrice.Text = "Save Price";
            btnSavePrice.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(85, 104);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(469, 27);
            txtPrice.TabIndex = 1;
            // 
            // cmbContainerSize
            // 
            cmbContainerSize.FormattingEnabled = true;
            cmbContainerSize.Items.AddRange(new object[] { "1 Gallon Slim", "1 Gallon Round" });
            cmbContainerSize.Location = new Point(85, 60);
            cmbContainerSize.Margin = new Padding(2);
            cmbContainerSize.Name = "cmbContainerSize";
            cmbContainerSize.Size = new Size(469, 28);
            cmbContainerSize.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.GradientInactiveCaption;
            tabPage4.Controls.Add(txtCredit);
            tabPage4.Controls.Add(txtCustomerName);
            tabPage4.Controls.Add(btnSaveCreditLimits);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(632, 273);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Credit";
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(119, 106);
            txtCredit.Name = "txtCredit";
            txtCredit.PlaceholderText = "Credit";
            txtCredit.Size = new Size(398, 27);
            txtCredit.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(119, 63);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name";
            txtCustomerName.Size = new Size(398, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // btnSaveCreditLimits
            // 
            btnSaveCreditLimits.BackColor = Color.FromArgb(55, 138, 221);
            btnSaveCreditLimits.FlatStyle = FlatStyle.Flat;
            btnSaveCreditLimits.ForeColor = Color.White;
            btnSaveCreditLimits.Location = new Point(222, 159);
            btnSaveCreditLimits.Margin = new Padding(2);
            btnSaveCreditLimits.Name = "btnSaveCreditLimits";
            btnSaveCreditLimits.Size = new Size(179, 27);
            btnSaveCreditLimits.TabIndex = 3;
            btnSaveCreditLimits.Text = "Save Credit";
            btnSaveCreditLimits.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(btnback);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Location = new Point(0, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(640, 54);
            pnlHeader.TabIndex = 1;
            // 
            // btnback
            // 
            btnback.FlatStyle = FlatStyle.Flat;
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(12, 13);
            btnback.Name = "btnback";
            btnback.Size = new Size(71, 29);
            btnback.TabIndex = 1;
            btnback.Text = "<Back";
            btnback.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(89, 11);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(234, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Admin Management";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(640, 360);
            Controls.Add(tabControl1);
            Controls.Add(pnlHeader);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Admin Management";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnRemoveDriver;
        private Button btnEditDriver;
        private Button btnAddDriver;
        private TextBox txtDriverPhone;
        private TextBox txtDriverName;
        private TextBox txtCoverageArea;
        private TextBox txtZoneName;
        private Button btnEditZone;
        private Button btnAddZone;
        private Button btnSavePrice;
        private TextBox txtPrice;
        private ComboBox cmbContainerSize;
        private Button btnSaveCreditLimits;
        private Panel pnlHeader;
        private Label lblHeader;
        private Button btnback;
        private Button btnDeleteZone;
        private TextBox txtSched;
        private TextBox txtCredit;
        private TextBox txtCustomerName;
    }
}
