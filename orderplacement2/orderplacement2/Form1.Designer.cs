namespace orderplacement2
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
            pnlDeliveryTo = new Panel();
            txtDeliveryTo = new TextBox();
            lblDeliveryTitle = new Label();
            pnlContainer = new Panel();
            cmbContainer = new ComboBox();
            lblContainer = new Label();
            pnlQuantity = new Panel();
            lblQuantityValue = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            lblQuantity = new Label();
            pnlTotal = new Panel();
            lblTotalValue = new Label();
            lblTotal = new Label();
            btnSubmit = new Button();
            pnlHeader.SuspendLayout();
            pnlDeliveryTo.SuspendLayout();
            pnlContainer.SuspendLayout();
            pnlQuantity.SuspendLayout();
            pnlTotal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(204, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Place an order";
            // 
            // pnlDeliveryTo
            // 
            pnlDeliveryTo.BackColor = Color.White;
            pnlDeliveryTo.Controls.Add(txtDeliveryTo);
            pnlDeliveryTo.Controls.Add(lblDeliveryTitle);
            pnlDeliveryTo.Location = new Point(20, 90);
            pnlDeliveryTo.Name = "pnlDeliveryTo";
            pnlDeliveryTo.Size = new Size(760, 60);
            pnlDeliveryTo.TabIndex = 1;
            // 
            // txtDeliveryTo
            // 
            txtDeliveryTo.Location = new Point(15, 28);
            txtDeliveryTo.Name = "txtDeliveryTo";
            txtDeliveryTo.Size = new Size(730, 27);
            txtDeliveryTo.TabIndex = 1;
            // 
            // lblDeliveryTitle
            // 
            lblDeliveryTitle.AutoSize = true;
            lblDeliveryTitle.ForeColor = Color.Gray;
            lblDeliveryTitle.Location = new Point(15, 8);
            lblDeliveryTitle.Name = "lblDeliveryTitle";
            lblDeliveryTitle.Size = new Size(81, 20);
            lblDeliveryTitle.TabIndex = 0;
            lblDeliveryTitle.Text = "Delivery to";
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(cmbContainer);
            pnlContainer.Controls.Add(lblContainer);
            pnlContainer.Location = new Point(20, 165);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(760, 60);
            pnlContainer.TabIndex = 2;
            // 
            // cmbContainer
            // 
            cmbContainer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContainer.FormattingEnabled = true;
            cmbContainer.Items.AddRange(new object[] { "Gallon Slim", "Gallon Round" });
            cmbContainer.Location = new Point(15, 28);
            cmbContainer.Name = "cmbContainer";
            cmbContainer.Size = new Size(730, 28);
            cmbContainer.TabIndex = 1;
            // 
            // lblContainer
            // 
            lblContainer.AutoSize = true;
            lblContainer.ForeColor = Color.Gray;
            lblContainer.Location = new Point(15, 8);
            lblContainer.Name = "lblContainer";
            lblContainer.Size = new Size(73, 20);
            lblContainer.TabIndex = 0;
            lblContainer.Text = "Container";
            // 
            // pnlQuantity
            // 
            pnlQuantity.BackColor = Color.White;
            pnlQuantity.Controls.Add(lblQuantityValue);
            pnlQuantity.Controls.Add(btnPlus);
            pnlQuantity.Controls.Add(btnMinus);
            pnlQuantity.Controls.Add(lblQuantity);
            pnlQuantity.Location = new Point(20, 240);
            pnlQuantity.Name = "pnlQuantity";
            pnlQuantity.Size = new Size(760, 60);
            pnlQuantity.TabIndex = 3;
            // 
            // lblQuantityValue
            // 
            lblQuantityValue.AutoSize = true;
            lblQuantityValue.Location = new Point(640, 19);
            lblQuantityValue.Name = "lblQuantityValue";
            lblQuantityValue.Size = new Size(17, 20);
            lblQuantityValue.TabIndex = 3;
            lblQuantityValue.Text = "0";
            // 
            // btnPlus
            // 
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Location = new Point(677, 12);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(35, 35);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Location = new Point(585, 12);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(35, 35);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 20);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Quantity";
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(220, 235, 251);
            pnlTotal.Controls.Add(lblTotalValue);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Location = new Point(20, 315);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(760, 50);
            pnlTotal.TabIndex = 4;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(585, 15);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(18, 20);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "₱";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(15, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(55, 138, 221);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(251, 393);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(286, 45);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit Order";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(pnlTotal);
            Controls.Add(pnlQuantity);
            Controls.Add(pnlContainer);
            Controls.Add(pnlDeliveryTo);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Order Placement";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlDeliveryTo.ResumeLayout(false);
            pnlDeliveryTo.PerformLayout();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlQuantity.ResumeLayout(false);
            pnlQuantity.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlDeliveryTo;
        private TextBox txtDeliveryTo;
        private Label lblDeliveryTitle;
        private Panel pnlContainer;
        private ComboBox cmbContainer;
        private Label lblContainer;
        private Panel pnlQuantity;
        private Label lblQuantity;
        private Label lblQuantityValue;
        private Button btnPlus;
        private Button btnMinus;
        private Panel pnlTotal;
        private Label lblTotalValue;
        private Label lblTotal;
        private Button btnSubmit;
    }
}
