namespace reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picLogo = new PictureBox();
            lblFullName = new Label();
            lblAddress = new Label();
            lblContact = new Label();
            lblAltName = new Label();
            lblAltNumber = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConPassword = new Label();
            lnkLogin = new LinkLabel();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtAltName = new TextBox();
            txtAltNumber = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConPassword = new TextBox();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(38, 111);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(300, 260);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Location = new Point(400, 40);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Location = new Point(400, 95);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = Color.Transparent;
            lblContact.Location = new Point(400, 150);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(118, 20);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact Number";
            // 
            // lblAltName
            // 
            lblAltName.AutoSize = true;
            lblAltName.BackColor = Color.Transparent;
            lblAltName.Location = new Point(400, 205);
            lblAltName.Name = "lblAltName";
            lblAltName.Size = new Size(130, 20);
            lblAltName.TabIndex = 4;
            lblAltName.Text = "Alt. Contact Name";
            // 
            // lblAltNumber
            // 
            lblAltNumber.AutoSize = true;
            lblAltNumber.BackColor = Color.Transparent;
            lblAltNumber.Location = new Point(600, 205);
            lblAltNumber.Name = "lblAltNumber";
            lblAltNumber.Size = new Size(144, 20);
            lblAltNumber.TabIndex = 5;
            lblAltNumber.Text = "Alt. Contact Number";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Location = new Point(400, 260);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Location = new Point(400, 315);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // lblConPassword
            // 
            lblConPassword.AutoSize = true;
            lblConPassword.BackColor = Color.Transparent;
            lblConPassword.Location = new Point(600, 315);
            lblConPassword.Name = "lblConPassword";
            lblConPassword.Size = new Size(127, 20);
            lblConPassword.TabIndex = 8;
            lblConPassword.Text = "Confirm Password";
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.BackColor = Color.Transparent;
            lnkLogin.LinkArea = new LinkArea(25, 5);
            lnkLogin.Location = new Point(471, 421);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(221, 25);
            lnkLogin.TabIndex = 9;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Already have an account? Login";
            lnkLogin.UseCompatibleTextRendering = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(400, 60);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(380, 27);
            txtFullName.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(400, 115);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(380, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(400, 170);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(380, 27);
            txtContact.TabIndex = 12;
            // 
            // txtAltName
            // 
            txtAltName.Location = new Point(400, 225);
            txtAltName.Name = "txtAltName";
            txtAltName.Size = new Size(180, 27);
            txtAltName.TabIndex = 13;
            // 
            // txtAltNumber
            // 
            txtAltNumber.Location = new Point(600, 225);
            txtAltNumber.Name = "txtAltNumber";
            txtAltNumber.Size = new Size(180, 27);
            txtAltNumber.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(400, 280);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(380, 27);
            txtUsername.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(400, 335);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 27);
            txtPassword.TabIndex = 16;
            // 
            // txtConPassword
            // 
            txtConPassword.Location = new Point(600, 335);
            txtConPassword.Name = "txtConPassword";
            txtConPassword.Size = new Size(180, 27);
            txtConPassword.TabIndex = 17;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(55, 138, 221);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(511, 381);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 35);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtConPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtAltNumber);
            Controls.Add(txtAltName);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(lnkLogin);
            Controls.Add(lblConPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblAltNumber);
            Controls.Add(lblAltName);
            Controls.Add(lblContact);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(picLogo);
            Name = "Form1";
            Text = "b";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblContact;
        private Label lblAltName;
        private Label lblAltNumber;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConPassword;
        private LinkLabel lnkLogin;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtAltName;
        private TextBox txtAltNumber;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConPassword;
        private Button btnRegister;
    }
}
