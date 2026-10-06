using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace My_credit
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=waterrefillingstationmanagementsystem;Uid=root;Pwd=;";

        private const string TableName = "`customers credit history`";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dghistory.AutoGenerateColumns = false;

            
            date.DataPropertyName = "Date";
            order.DataPropertyName = "Order";
            balance.DataPropertyName = "Balance";

            LoadHistory();
            UpdateBalanceLabel();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblLimitRef_Click(object sender, EventArgs e)
        {
        }

        private void LoadHistory()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT `Date`, `Order`, Balance FROM " + TableName +
                                   " ORDER BY `Date` DESC, Id DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dghistory.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBalanceLabel()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT Balance FROM " + TableName + " ORDER BY Id DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        decimal currentBalance = (result == null || result == DBNull.Value)
                            ? 0m
                            : Convert.ToDecimal(result);

                        lblBalanceValue.Text = "₱" + currentBalance.ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load balance: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRecord(DateTime entryDate, string orderName, decimal amount)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO " + TableName +
                                   " (`Date`, `Order`, Balance) VALUES (@date, @order, @balance)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", entryDate);
                        cmd.Parameters.AddWithValue("@order", orderName);
                        cmd.Parameters.AddWithValue("@balance", amount);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadHistory();
                UpdateBalanceLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save record: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}