namespace WinFormsApp1
{
    partial class Delivery_Queue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            button3 = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 52);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "Delivery Queue";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(25, 75);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 220);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(7, 147);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(474, 63);
            button1.TabIndex = 6;
            button1.Text = "Start Delivery";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(405, 11);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 5;
            label6.Text = "Assigned";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 125);
            label3.Name = "label3";
            label3.Size = new Size(240, 19);
            label3.TabIndex = 4;
            label3.Text = "Alt. contact: Juan Cruz, 09179876543";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 65);
            label5.Name = "label5";
            label5.Size = new Size(163, 60);
            label5.TabIndex = 3;
            label5.Text = "Purok 3, Brgy. San Jose\r\n2 gallons\r\nContact: 0917 123 4567\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 43);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 2;
            label4.Text = "Maria Cruz";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(7, 11);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 0;
            label2.Text = "NEXT DELIVERY\r\n";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(23, 303);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(490, 197);
            panel3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(7, 115);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(474, 63);
            button2.TabIndex = 6;
            button2.Text = "Start Delivery";
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(411, 11);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 5;
            label7.Text = "Pending";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 93);
            label8.Name = "label8";
            label8.Size = new Size(261, 19);
            label8.TabIndex = 4;
            label8.Text = "Alt. contact: Juan Santos, 0954 453 6565";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 33);
            label9.Name = "label9";
            label9.Size = new Size(163, 60);
            label9.TabIndex = 3;
            label9.Text = "Purok 2, Brgy. San Jose\r\n3 gallons\r\nContact: 0966 453 5732\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 11);
            label10.Name = "label10";
            label10.Size = new Size(114, 23);
            label10.TabIndex = 2;
            label10.Text = "Pedro Santos";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.MediumBlue;
            label11.Location = new Point(7, 11);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(25, 508);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(488, 193);
            panel4.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 115);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(474, 63);
            button3.TabIndex = 6;
            button3.Text = "Start Delivery";
            button3.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(411, 11);
            label12.Name = "label12";
            label12.Size = new Size(72, 23);
            label12.TabIndex = 5;
            label12.Text = "Pending";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(9, 93);
            label13.Name = "label13";
            label13.Size = new Size(259, 19);
            label13.TabIndex = 4;
            label13.Text = "Alt. contact: Juan Reyes . 0917 658 6554";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 33);
            label14.Name = "label14";
            label14.Size = new Size(163, 60);
            label14.TabIndex = 3;
            label14.Text = "Purok 1, Brgy. San Jose\r\n1gallons\r\nContact: 0965 356 5475\r\n";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(7, 11);
            label15.Name = "label15";
            label15.Size = new Size(91, 23);
            label15.TabIndex = 2;
            label15.Text = "Ana Reyes";
            label15.Click += label15_Click;
            // 
            // Delivery_Queue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(542, 719);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Delivery_Queue";
            Text = "Delivery Queue";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel4;
        private Button button3;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}