namespace WinFormsApp1
{
    partial class Form1
    {
        private const bool V = true;

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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Messenger_creation_264DD650_E650_461C_998D_36F3C6BE7FB1__1__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Location = new Point(14, 60);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 264);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(315, 117);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click_3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(319, 207);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 141);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 231);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(589, 283);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(55, 138, 221);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(461, 347);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(88, 39);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkArea = new LinkArea(10, 18);
            linkLabel2.Location = new Point(437, 402);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(137, 25);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "New here? Register";
            linkLabel2.UseCompatibleTextRendering = true;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(314, 12);
            label3.Name = "label3";
            label3.Size = new Size(374, 72);
            label3.TabIndex = 8;
            label3.Text = "Water Refilling Station\r\n Management System";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.log_in_bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(763, 444);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Log-In";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private Button button1;
        private LinkLabel linkLabel2;
        private Label label3;
    }
}
