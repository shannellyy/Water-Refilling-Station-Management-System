namespace IncomeExpense_Tracking
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
            lblTitle = new Label();
            pnlIncome = new Panel();
            lblIncomeValue = new Label();
            lblIncomeTitle = new Label();
            pnlExpenses = new Panel();
            lblExpensesValue = new Label();
            lblExpensesTitle = new Label();
            pnlNetIncome = new Panel();
            lblNetIncomeValue = new Label();
            lblNetIncomeTitle = new Label();
            pnlAddExpense = new Panel();
            btnAddExpense = new Button();
            txtExpenseNotes = new TextBox();
            dtpExpenseDate = new DateTimePicker();
            txtExpenseAmount = new TextBox();
            cmbExpenseCategory = new ComboBox();
            lblAddExpenseTitle = new Label();
            pnlCategoryBreakdown = new Panel();
            dgcategory = new DataGridView();
            expense = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            lblBreakdownTitle = new Label();
            pnlHeader = new Panel();
            pnlAddIncome = new Panel();
            btnAddIncome = new Button();
            txtIncomeNote = new TextBox();
            dtpIncome = new DateTimePicker();
            txtIncome = new TextBox();
            cmbIncome = new ComboBox();
            lblAddIncomeTitle = new Label();
            pnlIncomeBreakdown = new Panel();
            dataGridView1 = new DataGridView();
            income = new DataGridViewTextBoxColumn();
            IncomeDate = new DataGridViewTextBoxColumn();
            IncomeAmount = new DataGridViewTextBoxColumn();
            lblIncomeBreakdown = new Label();
            pnlIncome.SuspendLayout();
            pnlExpenses.SuspendLayout();
            pnlNetIncome.SuspendLayout();
            pnlAddExpense.SuspendLayout();
            pnlCategoryBreakdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgcategory).BeginInit();
            pnlHeader.SuspendLayout();
            pnlAddIncome.SuspendLayout();
            pnlIncomeBreakdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(329, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Income and Expense Tracking";
            // 
            // pnlIncome
            // 
            pnlIncome.BackColor = Color.White;
            pnlIncome.Controls.Add(lblIncomeValue);
            pnlIncome.Controls.Add(lblIncomeTitle);
            pnlIncome.Location = new Point(20, 60);
            pnlIncome.Name = "pnlIncome";
            pnlIncome.Size = new Size(270, 80);
            pnlIncome.TabIndex = 1;
            // 
            // lblIncomeValue
            // 
            lblIncomeValue.AutoSize = true;
            lblIncomeValue.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncomeValue.ForeColor = Color.FromArgb(8, 80, 65);
            lblIncomeValue.Location = new Point(15, 38);
            lblIncomeValue.Name = "lblIncomeValue";
            lblIncomeValue.Size = new Size(51, 38);
            lblIncomeValue.TabIndex = 1;
            lblIncomeValue.Text = "₱0";
            // 
            // lblIncomeTitle
            // 
            lblIncomeTitle.AutoSize = true;
            lblIncomeTitle.ForeColor = Color.Gray;
            lblIncomeTitle.Location = new Point(15, 12);
            lblIncomeTitle.Name = "lblIncomeTitle";
            lblIncomeTitle.Size = new Size(58, 20);
            lblIncomeTitle.TabIndex = 0;
            lblIncomeTitle.Text = "Income";
            // 
            // pnlExpenses
            // 
            pnlExpenses.BackColor = Color.White;
            pnlExpenses.Controls.Add(lblExpensesValue);
            pnlExpenses.Controls.Add(lblExpensesTitle);
            pnlExpenses.Location = new Point(305, 60);
            pnlExpenses.Name = "pnlExpenses";
            pnlExpenses.Size = new Size(270, 80);
            pnlExpenses.TabIndex = 2;
            // 
            // lblExpensesValue
            // 
            lblExpensesValue.AutoSize = true;
            lblExpensesValue.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpensesValue.ForeColor = Color.FromArgb(121, 31, 31);
            lblExpensesValue.Location = new Point(15, 38);
            lblExpensesValue.Name = "lblExpensesValue";
            lblExpensesValue.Size = new Size(51, 38);
            lblExpensesValue.TabIndex = 1;
            lblExpensesValue.Text = "₱0";
            // 
            // lblExpensesTitle
            // 
            lblExpensesTitle.AutoSize = true;
            lblExpensesTitle.ForeColor = Color.Gray;
            lblExpensesTitle.Location = new Point(15, 12);
            lblExpensesTitle.Name = "lblExpensesTitle";
            lblExpensesTitle.Size = new Size(63, 20);
            lblExpensesTitle.TabIndex = 0;
            lblExpensesTitle.Text = "Expense";
            // 
            // pnlNetIncome
            // 
            pnlNetIncome.BackColor = Color.White;
            pnlNetIncome.Controls.Add(lblNetIncomeValue);
            pnlNetIncome.Controls.Add(lblNetIncomeTitle);
            pnlNetIncome.Location = new Point(590, 60);
            pnlNetIncome.Name = "pnlNetIncome";
            pnlNetIncome.Size = new Size(270, 80);
            pnlNetIncome.TabIndex = 3;
            // 
            // lblNetIncomeValue
            // 
            lblNetIncomeValue.AutoSize = true;
            lblNetIncomeValue.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetIncomeValue.ForeColor = Color.FromArgb(12, 68, 124);
            lblNetIncomeValue.Location = new Point(15, 38);
            lblNetIncomeValue.Name = "lblNetIncomeValue";
            lblNetIncomeValue.Size = new Size(51, 38);
            lblNetIncomeValue.TabIndex = 1;
            lblNetIncomeValue.Text = "₱0";
            // 
            // lblNetIncomeTitle
            // 
            lblNetIncomeTitle.AutoSize = true;
            lblNetIncomeTitle.ForeColor = Color.Gray;
            lblNetIncomeTitle.Location = new Point(15, 12);
            lblNetIncomeTitle.Name = "lblNetIncomeTitle";
            lblNetIncomeTitle.Size = new Size(86, 20);
            lblNetIncomeTitle.TabIndex = 0;
            lblNetIncomeTitle.Text = "Net Income";
            // 
            // pnlAddExpense
            // 
            pnlAddExpense.BackColor = Color.White;
            pnlAddExpense.Controls.Add(btnAddExpense);
            pnlAddExpense.Controls.Add(txtExpenseNotes);
            pnlAddExpense.Controls.Add(dtpExpenseDate);
            pnlAddExpense.Controls.Add(txtExpenseAmount);
            pnlAddExpense.Controls.Add(cmbExpenseCategory);
            pnlAddExpense.Controls.Add(lblAddExpenseTitle);
            pnlAddExpense.Location = new Point(20, 155);
            pnlAddExpense.Name = "pnlAddExpense";
            pnlAddExpense.Size = new Size(420, 280);
            pnlAddExpense.TabIndex = 4;
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.FromArgb(55, 138, 221);
            btnAddExpense.FlatStyle = FlatStyle.Flat;
            btnAddExpense.ForeColor = Color.White;
            btnAddExpense.Location = new Point(159, 231);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(94, 29);
            btnAddExpense.TabIndex = 5;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = false;
            // 
            // txtExpenseNotes
            // 
            txtExpenseNotes.Location = new Point(15, 180);
            txtExpenseNotes.Name = "txtExpenseNotes";
            txtExpenseNotes.PlaceholderText = "Note";
            txtExpenseNotes.Size = new Size(390, 27);
            txtExpenseNotes.TabIndex = 4;
            // 
            // dtpExpenseDate
            // 
            dtpExpenseDate.Format = DateTimePickerFormat.Short;
            dtpExpenseDate.Location = new Point(15, 135);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(390, 27);
            dtpExpenseDate.TabIndex = 3;
            // 
            // txtExpenseAmount
            // 
            txtExpenseAmount.Location = new Point(15, 90);
            txtExpenseAmount.Name = "txtExpenseAmount";
            txtExpenseAmount.PlaceholderText = "Amount";
            txtExpenseAmount.Size = new Size(390, 27);
            txtExpenseAmount.TabIndex = 2;
            // 
            // cmbExpenseCategory
            // 
            cmbExpenseCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExpenseCategory.FormattingEnabled = true;
            cmbExpenseCategory.Items.AddRange(new object[] { "Fuel", "Driver salaries", "Driver allowance/meal", "Small repairs/maintenance", "Vehicle maintenance", "Electricity bill", "Water testing/check up", "RO membrane replacement", "Filters replacement", "Business fees", "Bottles/Gallon purachase", "Caps purchase", "Seal purchase", "Staff checkups" });
            cmbExpenseCategory.Location = new Point(15, 45);
            cmbExpenseCategory.Name = "cmbExpenseCategory";
            cmbExpenseCategory.Size = new Size(390, 28);
            cmbExpenseCategory.TabIndex = 1;
            // 
            // lblAddExpenseTitle
            // 
            lblAddExpenseTitle.AutoSize = true;
            lblAddExpenseTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddExpenseTitle.Location = new Point(15, 12);
            lblAddExpenseTitle.Name = "lblAddExpenseTitle";
            lblAddExpenseTitle.Size = new Size(122, 25);
            lblAddExpenseTitle.TabIndex = 0;
            lblAddExpenseTitle.Text = "Add Expense";
            // 
            // pnlCategoryBreakdown
            // 
            pnlCategoryBreakdown.BackColor = Color.White;
            pnlCategoryBreakdown.Controls.Add(dgcategory);
            pnlCategoryBreakdown.Controls.Add(lblBreakdownTitle);
            pnlCategoryBreakdown.Location = new Point(460, 155);
            pnlCategoryBreakdown.Name = "pnlCategoryBreakdown";
            pnlCategoryBreakdown.Size = new Size(400, 280);
            pnlCategoryBreakdown.TabIndex = 5;
            // 
            // dgcategory
            // 
            dgcategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgcategory.BackgroundColor = Color.WhiteSmoke;
            dgcategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgcategory.Columns.AddRange(new DataGridViewColumn[] { expense, date, amount });
            dgcategory.Location = new Point(15, 56);
            dgcategory.Name = "dgcategory";
            dgcategory.RowHeadersWidth = 51;
            dgcategory.Size = new Size(367, 204);
            dgcategory.TabIndex = 1;
            // 
            // expense
            // 
            expense.HeaderText = "Expense";
            expense.MinimumWidth = 6;
            expense.Name = "expense";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            // 
            // lblBreakdownTitle
            // 
            lblBreakdownTitle.AutoSize = true;
            lblBreakdownTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreakdownTitle.Location = new Point(15, 12);
            lblBreakdownTitle.Name = "lblBreakdownTitle";
            lblBreakdownTitle.Size = new Size(183, 25);
            lblBreakdownTitle.TabIndex = 0;
            lblBreakdownTitle.Text = "Expense Breakdown";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(55, 138, 221);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(-1, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(885, 54);
            pnlHeader.TabIndex = 6;
            // 
            // pnlAddIncome
            // 
            pnlAddIncome.BackColor = Color.White;
            pnlAddIncome.Controls.Add(btnAddIncome);
            pnlAddIncome.Controls.Add(txtIncomeNote);
            pnlAddIncome.Controls.Add(dtpIncome);
            pnlAddIncome.Controls.Add(txtIncome);
            pnlAddIncome.Controls.Add(cmbIncome);
            pnlAddIncome.Controls.Add(lblAddIncomeTitle);
            pnlAddIncome.Location = new Point(20, 454);
            pnlAddIncome.Name = "pnlAddIncome";
            pnlAddIncome.Size = new Size(420, 280);
            pnlAddIncome.TabIndex = 7;
            // 
            // btnAddIncome
            // 
            btnAddIncome.BackColor = Color.FromArgb(55, 138, 221);
            btnAddIncome.FlatStyle = FlatStyle.Flat;
            btnAddIncome.ForeColor = Color.White;
            btnAddIncome.Location = new Point(159, 229);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(94, 29);
            btnAddIncome.TabIndex = 5;
            btnAddIncome.Text = "Add Income";
            btnAddIncome.UseVisualStyleBackColor = false;
            // 
            // txtIncomeNote
            // 
            txtIncomeNote.Location = new Point(20, 180);
            txtIncomeNote.Name = "txtIncomeNote";
            txtIncomeNote.PlaceholderText = "Note";
            txtIncomeNote.Size = new Size(378, 27);
            txtIncomeNote.TabIndex = 4;
            // 
            // dtpIncome
            // 
            dtpIncome.Format = DateTimePickerFormat.Short;
            dtpIncome.Location = new Point(20, 135);
            dtpIncome.Name = "dtpIncome";
            dtpIncome.Size = new Size(378, 27);
            dtpIncome.TabIndex = 3;
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(19, 90);
            txtIncome.Name = "txtIncome";
            txtIncome.PlaceholderText = "Amount";
            txtIncome.Size = new Size(379, 27);
            txtIncome.TabIndex = 2;
            // 
            // cmbIncome
            // 
            cmbIncome.FormattingEnabled = true;
            cmbIncome.Items.AddRange(new object[] { "Gallon Slim", "Gallon Round" });
            cmbIncome.Location = new Point(19, 47);
            cmbIncome.Name = "cmbIncome";
            cmbIncome.Size = new Size(379, 28);
            cmbIncome.TabIndex = 1;
            // 
            // lblAddIncomeTitle
            // 
            lblAddIncomeTitle.AutoSize = true;
            lblAddIncomeTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddIncomeTitle.Location = new Point(15, 12);
            lblAddIncomeTitle.Name = "lblAddIncomeTitle";
            lblAddIncomeTitle.Size = new Size(107, 23);
            lblAddIncomeTitle.TabIndex = 0;
            lblAddIncomeTitle.Text = "Add Income";
            // 
            // pnlIncomeBreakdown
            // 
            pnlIncomeBreakdown.BackColor = Color.White;
            pnlIncomeBreakdown.Controls.Add(dataGridView1);
            pnlIncomeBreakdown.Controls.Add(lblIncomeBreakdown);
            pnlIncomeBreakdown.Location = new Point(460, 454);
            pnlIncomeBreakdown.Name = "pnlIncomeBreakdown";
            pnlIncomeBreakdown.Size = new Size(400, 280);
            pnlIncomeBreakdown.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { income, IncomeDate, IncomeAmount });
            dataGridView1.Location = new Point(15, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(367, 202);
            dataGridView1.TabIndex = 1;
            // 
            // income
            // 
            income.HeaderText = "Income";
            income.MinimumWidth = 6;
            income.Name = "income";
            // 
            // IncomeDate
            // 
            IncomeDate.HeaderText = "Date";
            IncomeDate.MinimumWidth = 6;
            IncomeDate.Name = "IncomeDate";
            // 
            // IncomeAmount
            // 
            IncomeAmount.HeaderText = "Amount";
            IncomeAmount.MinimumWidth = 6;
            IncomeAmount.Name = "IncomeAmount";
            // 
            // lblIncomeBreakdown
            // 
            lblIncomeBreakdown.AutoSize = true;
            lblIncomeBreakdown.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncomeBreakdown.Location = new Point(15, 12);
            lblIncomeBreakdown.Name = "lblIncomeBreakdown";
            lblIncomeBreakdown.Size = new Size(164, 23);
            lblIncomeBreakdown.TabIndex = 0;
            lblIncomeBreakdown.Text = "Income Breakdown";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(882, 756);
            Controls.Add(pnlIncomeBreakdown);
            Controls.Add(pnlAddIncome);
            Controls.Add(pnlHeader);
            Controls.Add(pnlCategoryBreakdown);
            Controls.Add(pnlAddExpense);
            Controls.Add(pnlNetIncome);
            Controls.Add(pnlExpenses);
            Controls.Add(pnlIncome);
            Name = "Form1";
            Text = "Income and Expense Tracking";
            Load += Form1_Load;
            pnlIncome.ResumeLayout(false);
            pnlIncome.PerformLayout();
            pnlExpenses.ResumeLayout(false);
            pnlExpenses.PerformLayout();
            pnlNetIncome.ResumeLayout(false);
            pnlNetIncome.PerformLayout();
            pnlAddExpense.ResumeLayout(false);
            pnlAddExpense.PerformLayout();
            pnlCategoryBreakdown.ResumeLayout(false);
            pnlCategoryBreakdown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgcategory).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAddIncome.ResumeLayout(false);
            pnlAddIncome.PerformLayout();
            pnlIncomeBreakdown.ResumeLayout(false);
            pnlIncomeBreakdown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlIncome;
        private Label lblIncomeValue;
        private Label lblIncomeTitle;
        private Panel pnlExpenses;
        private Label lblExpensesValue;
        private Label lblExpensesTitle;
        private Panel pnlNetIncome;
        private Label lblNetIncomeValue;
        private Label lblNetIncomeTitle;
        private Panel pnlAddExpense;
        private Label lblAddExpenseTitle;
        private ComboBox cmbExpenseCategory;
        private Button btnAddExpense;
        private TextBox txtExpenseNotes;
        private DateTimePicker dtpExpenseDate;
        private TextBox txtExpenseAmount;
        private Panel pnlCategoryBreakdown;
        private Label lblBreakdownTitle;
        private Panel pnlHeader;
        private DataGridView dgcategory;
        private Panel pnlAddIncome;
        private Label lblAddIncomeTitle;
        private DateTimePicker dtpIncome;
        private TextBox txtIncome;
        private ComboBox cmbIncome;
        private DataGridViewTextBoxColumn expense;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn amount;
        private Button btnAddIncome;
        private TextBox txtIncomeNote;
        private Panel pnlIncomeBreakdown;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn income;
        private DataGridViewTextBoxColumn IncomeDate;
        private DataGridViewTextBoxColumn IncomeAmount;
        private Label lblIncomeBreakdown;
    }
}
