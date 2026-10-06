using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace IncomeExpense_Tracking
{
    public partial class Form1 : Form
    {
        private const string ConnStr =
            "Server=localhost;Port=3306;Database=waterrefillingstationmanagementsystem;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();

            btnAddExpense.Click += btnAddExpense_Click;
            btnAddIncome.Click += btnAddIncome_Click;
        }

        // ---------- HELPERS ----------

        private DataTable Query(string sql, params MySqlParameter[] parameters)
        {
            using (var conn = new MySqlConnection(ConnStr))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameters);
                var table = new DataTable();
                new MySqlDataAdapter(cmd).Fill(table);
                return table;
            }
        }

        private int Execute(string sql, params MySqlParameter[] parameters)
        {
            using (var conn = new MySqlConnection(ConnStr))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        private void SetupGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;
        }

        // ---------- FORM LOAD ----------

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetupGrid(dgcategory);
                SetupGrid(dataGridView1);

                cmbExpenseCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                if (cmbExpenseCategory.Items.Count == 0)
                {
                    cmbExpenseCategory.Items.AddRange(new object[]
                    {
                        "Water Supply", "Electricity", "Rent", "Salary",
                        "Supplies", "Transportation", "Maintenance", "Other"
                    });
                }

                cmbIncome.DropDownStyle = ComboBoxStyle.DropDownList;
                if (cmbIncome.Items.Count == 0)
                {
                    cmbIncome.Items.AddRange(new object[]
                    {
                        "Sales", "Salary", "Allowance", "Business", "Other"
                    });
                }

                dtpExpenseDate.Format = DateTimePickerFormat.Short;
                dtpIncome.Format = DateTimePickerFormat.Short;

                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to the database: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshAll()
        {
            LoadExpenses();
            LoadIncome();
            UpdateTotals();
        }

        // ---------- EXPENSES ----------

        private void LoadExpenses()
        {
            dgcategory.DataSource = null;
            dgcategory.Columns.Clear();
            dgcategory.AutoGenerateColumns = true;
            dgcategory.DataSource = Query(
                @"SELECT category AS 'Expense', expense_date AS 'Date', amount AS 'Amount'
                  FROM expenses ORDER BY expense_date DESC, expense_id DESC");
            dgcategory.Columns["Date"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgcategory.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dgcategory.ClearSelection();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (cmbExpenseCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select an expense category.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtExpenseAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than zero.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Execute(@"INSERT INTO expenses (category, amount, expense_date, note)
                          VALUES (@cat, @amt, @date, @note)",
                    new MySqlParameter("@cat", cmbExpenseCategory.SelectedItem.ToString()),
                    new MySqlParameter("@amt", amount),
                    new MySqlParameter("@date", dtpExpenseDate.Value.Date),
                    new MySqlParameter("@note", txtExpenseNotes.Text.Trim()));

                MessageBox.Show("Expense added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbExpenseCategory.SelectedIndex = -1;
                txtExpenseAmount.Clear();
                txtExpenseNotes.Clear();
                dtpExpenseDate.Value = DateTime.Today;
                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- INCOME ----------

        private void LoadIncome()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Query(
                @"SELECT source AS 'Income', income_date AS 'Date', amount AS 'Amount'
                  FROM income ORDER BY income_date DESC, income_id DESC");
            dataGridView1.Columns["Date"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dataGridView1.ClearSelection();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            if (cmbIncome.SelectedItem == null)
            {
                MessageBox.Show("Please select an income source.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtIncome.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than zero.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Execute(@"INSERT INTO income (source, amount, income_date, note)
                          VALUES (@src, @amt, @date, @note)",
                    new MySqlParameter("@src", cmbIncome.SelectedItem.ToString()),
                    new MySqlParameter("@amt", amount),
                    new MySqlParameter("@date", dtpIncome.Value.Date),
                    new MySqlParameter("@note", txtIncomeNote.Text.Trim()));

                MessageBox.Show("Income added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbIncome.SelectedIndex = -1;
                txtIncome.Clear();
                txtIncomeNote.Clear();
                dtpIncome.Value = DateTime.Today;
                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- TOTALS ----------

        private void UpdateTotals()
        {
            decimal totalIncome = Convert.ToDecimal(
                Query("SELECT IFNULL(SUM(amount), 0) AS total FROM income").Rows[0]["total"]);
            decimal totalExpense = Convert.ToDecimal(
                Query("SELECT IFNULL(SUM(amount), 0) AS total FROM expenses").Rows[0]["total"]);
            decimal net = totalIncome - totalExpense;

            lblIncomeValue.Text = "₱" + totalIncome.ToString("N2");
            lblExpensesValue.Text = "₱" + totalExpense.ToString("N2");
            lblNetIncomeValue.Text = "₱" + net.ToString("N2");
        }
    }
}