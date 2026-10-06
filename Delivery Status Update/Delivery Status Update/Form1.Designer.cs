namespace Delivery_Status_Update
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
            lblHeader = new Label();
            pnlOrderDetails = new Panel();
            lblOrderDetails = new Label();
            lblCustomerName = new Label();
            btnOutForDelivery = new Button();
            btnDelivered = new Button();
            btnDeliveryFailed = new Button();
            txtFailReason = new TextBox();
            lblTimeStamp = new Label();
            btnSubmitUpdate = new Button();
            pnlHeader.SuspendLayout();
            pnlOrderDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(810, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 22);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(259, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Delivery Status Update";
            // 
            // pnlOrderDetails
            // 
            pnlOrderDetails.BackColor = Color.White;
            pnlOrderDetails.Controls.Add(lblOrderDetails);
            pnlOrderDetails.Controls.Add(lblCustomerName);
            pnlOrderDetails.Location = new Point(20, 90);
            pnlOrderDetails.Name = "pnlOrderDetails";
            pnlOrderDetails.Size = new Size(760, 65);
            pnlOrderDetails.TabIndex = 1;
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.ForeColor = Color.Gray;
            lblOrderDetails.Location = new Point(323, 36);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(114, 20);
            lblOrderDetails.TabIndex = 1;
            lblOrderDetails.Text = "Address - Order";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(308, 11);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(148, 25);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name";
            // 
            // btnOutForDelivery
            // 
            btnOutForDelivery.BackColor = Color.FromArgb(55, 138, 221);
            btnOutForDelivery.FlatStyle = FlatStyle.Flat;
            btnOutForDelivery.ForeColor = Color.White;
            btnOutForDelivery.Location = new Point(210, 170);
            btnOutForDelivery.Name = "btnOutForDelivery";
            btnOutForDelivery.Size = new Size(380, 42);
            btnOutForDelivery.TabIndex = 3;
            btnOutForDelivery.Text = "Out For Delivery";
            btnOutForDelivery.UseVisualStyleBackColor = false;
            // 
            // btnDelivered
            // 
            btnDelivered.BackColor = Color.FromArgb(29, 158, 117);
            btnDelivered.FlatStyle = FlatStyle.Flat;
            btnDelivered.ForeColor = Color.White;
            btnDelivered.Location = new Point(210, 220);
            btnDelivered.Name = "btnDelivered";
            btnDelivered.Size = new Size(380, 42);
            btnDelivered.TabIndex = 4;
            btnDelivered.Text = "Delivered";
            btnDelivered.UseVisualStyleBackColor = false;
            // 
            // btnDeliveryFailed
            // 
            btnDeliveryFailed.BackColor = Color.FromArgb(163, 45, 45);
            btnDeliveryFailed.FlatStyle = FlatStyle.Flat;
            btnDeliveryFailed.ForeColor = Color.White;
            btnDeliveryFailed.Location = new Point(210, 270);
            btnDeliveryFailed.Name = "btnDeliveryFailed";
            btnDeliveryFailed.Size = new Size(380, 42);
            btnDeliveryFailed.TabIndex = 5;
            btnDeliveryFailed.Text = "Delivery Failed";
            btnDeliveryFailed.UseVisualStyleBackColor = false;
            // 
            // txtFailReason
            // 
            txtFailReason.Location = new Point(210, 338);
            txtFailReason.Name = "txtFailReason";
            txtFailReason.PlaceholderText = "Reason (if failed)";
            txtFailReason.Size = new Size(380, 27);
            txtFailReason.TabIndex = 6;
            // 
            // lblTimeStamp
            // 
            lblTimeStamp.AutoSize = true;
            lblTimeStamp.ForeColor = Color.Gray;
            lblTimeStamp.Location = new Point(313, 377);
            lblTimeStamp.Name = "lblTimeStamp";
            lblTimeStamp.Size = new Size(186, 20);
            lblTimeStamp.TabIndex = 7;
            lblTimeStamp.Text = "Timestamp auto-recorded:";
            // 
            // btnSubmitUpdate
            // 
            btnSubmitUpdate.BackColor = Color.Black;
            btnSubmitUpdate.FlatStyle = FlatStyle.Flat;
            btnSubmitUpdate.ForeColor = Color.White;
            btnSubmitUpdate.Location = new Point(210, 400);
            btnSubmitUpdate.Name = "btnSubmitUpdate";
            btnSubmitUpdate.Size = new Size(380, 42);
            btnSubmitUpdate.TabIndex = 8;
            btnSubmitUpdate.Text = "Submit Update";
            btnSubmitUpdate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmitUpdate);
            Controls.Add(lblTimeStamp);
            Controls.Add(txtFailReason);
            Controls.Add(btnDeliveryFailed);
            Controls.Add(btnDelivered);
            Controls.Add(btnOutForDelivery);
            Controls.Add(pnlOrderDetails);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Delivery Status Update";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlOrderDetails.ResumeLayout(false);
            pnlOrderDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlOrderDetails;
        private Label lblHeader;
        private Label lblOrderDetails;
        private Label lblCustomerName;
        private Button btnOutForDelivery;
        private Button btnDelivered;
        private Button btnDeliveryFailed;
        private TextBox txtFailReason;
        private Label lblTimeStamp;
        private Button btnSubmitUpdate;
    }
}
