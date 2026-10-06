using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Management_Screen
{
    public partial class Form1 : Form
    {
        private const string ConnStr =
            "Server=localhost;Port=3306;Database=waterrefillingstationmanagementsystem;Uid=root;Pwd=;";

        private int selectedDriverId = 0;
        private int selectedZoneId = 0;

        private DataGridView dgvDrivers;
        private DataGridView dgvZones;
        private DataGridView dgvPricing;
        private DataGridView dgvCredit;

        public Form1()
        {
            InitializeComponent();
            BuildGrids();

            btnback.Click += (s, e) => Close();

            btnAddDriver.Click += btnAddDriver_Click;
            btnEditDriver.Click += btnEditDriver_Click;
            btnRemoveDriver.Click += btnRemoveDriver_Click;
            dgvDrivers.CellClick += dgvDrivers_CellClick;

            btnAddZone.Click += btnAddZone_Click;
            btnEditZone.Click += btnEditZone_Click;
            btnDeleteZone.Click += btnDeleteZone_Click;
            dgvZones.CellClick += dgvZones_CellClick;

            cmbContainerSize.SelectedIndexChanged += cmbContainerSize_SelectedIndexChanged;
            btnSavePrice.Click += btnSavePrice_Click;
            dgvPricing.CellClick += dgvPricing_CellClick;

            btnSaveCreditLimits.Click += btnSaveCreditLimit_Click;
            dgvCredit.CellClick += dgvCredit_CellClick;
        }

        // ---------- BUILD GRIDS IN CODE ----------

        private void BuildGrids()
        {
            ClientSize = new Size(640, 580);
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            tabControl1.Location = new Point(0, 60);
            tabControl1.Size = new Size(640, 520);

            dgvDrivers = CreateGrid(new Point(85, 235), new Size(459, 230));
            tabPage1.Controls.Add(dgvDrivers);

            dgvZones = CreateGrid(new Point(85, 235), new Size(469, 230));
            tabPage2.Controls.Add(dgvZones);

            dgvPricing = CreateGrid(new Point(85, 235), new Size(469, 110));
            tabPage3.Controls.Add(dgvPricing);

            dgvCredit = CreateGrid(new Point(119, 205), new Size(398, 260));
            tabPage4.Controls.Add(dgvCredit);
        }

        private DataGridView CreateGrid(Point location, Size size)
        {
            var grid = new DataGridView();
            grid.Location = location;
            grid.Size = size;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;
            return grid;
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

        // ---------- FORM LOAD ----------

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cmbContainerSize.DropDownStyle = ComboBoxStyle.DropDownList;
                if (cmbContainerSize.Items.Count == 0)
                {
                    cmbContainerSize.Items.Add("1 Gallon Slim");
                    cmbContainerSize.Items.Add("1 Gallon Round");
                }

                LoadDrivers();
                LoadZones();
                LoadPricing();
                LoadCredit();

                if (cmbContainerSize.Items.Count > 0)
                    cmbContainerSize.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to the database: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- DRIVERS ----------

        private void LoadDrivers()
        {
            dgvDrivers.DataSource = Query(
                "SELECT driver_id, driver_name AS 'Driver Name', driver_phone AS 'Phone Number' FROM drivers");
            if (dgvDrivers.Columns["driver_id"] != null)
                dgvDrivers.Columns["driver_id"].Visible = false;
            ClearDriverFields();
        }

        private void ClearDriverFields()
        {
            txtDriverName.Clear();
            txtDriverPhone.Clear();
            selectedDriverId = 0;
            dgvDrivers.ClearSelection();
        }

        private void dgvDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvDrivers.Rows[e.RowIndex];
            selectedDriverId = Convert.ToInt32(row.Cells["driver_id"].Value);
            txtDriverName.Text = row.Cells["Driver Name"].Value.ToString();
            txtDriverPhone.Text = row.Cells["Phone Number"].Value.ToString();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDriverName.Text) ||
                string.IsNullOrWhiteSpace(txtDriverPhone.Text))
            {
                MessageBox.Show("Please enter the driver name and phone number.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Execute("INSERT INTO drivers (driver_name, driver_phone) VALUES (@name, @phone)",
                    new MySqlParameter("@name", txtDriverName.Text.Trim()),
                    new MySqlParameter("@phone", txtDriverPhone.Text.Trim()));
                MessageBox.Show("Driver added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDrivers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditDriver_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == 0)
            {
                MessageBox.Show("Please select a driver from the list first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDriverName.Text) ||
                string.IsNullOrWhiteSpace(txtDriverPhone.Text))
            {
                MessageBox.Show("Please enter the driver name and phone number.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Execute("UPDATE drivers SET driver_name=@name, driver_phone=@phone WHERE driver_id=@id",
                    new MySqlParameter("@name", txtDriverName.Text.Trim()),
                    new MySqlParameter("@phone", txtDriverPhone.Text.Trim()),
                    new MySqlParameter("@id", selectedDriverId));
                MessageBox.Show("Driver updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDrivers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveDriver_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == 0)
            {
                MessageBox.Show("Please select a driver from the list first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to remove this driver?",
                "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Execute("DELETE FROM drivers WHERE driver_id=@id",
                    new MySqlParameter("@id", selectedDriverId));
                MessageBox.Show("Driver removed successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDrivers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- DELIVERY ZONES ----------

        private void LoadZones()
        {
            dgvZones.DataSource = Query(
                "SELECT zone_id, zone_name AS 'Zone Name', coverage_area AS 'Coverage Area', schedule AS 'Schedule' FROM delivery_zones");
            if (dgvZones.Columns["zone_id"] != null)
                dgvZones.Columns["zone_id"].Visible = false;
            ClearZoneFields();
        }

        private void ClearZoneFields()
        {
            txtZoneName.Clear();
            txtCoverageArea.Clear();
            txtSched.Clear();
            selectedZoneId = 0;
            dgvZones.ClearSelection();
        }

        private bool ZoneFieldsValid()
        {
            if (string.IsNullOrWhiteSpace(txtZoneName.Text) ||
                string.IsNullOrWhiteSpace(txtCoverageArea.Text) ||
                string.IsNullOrWhiteSpace(txtSched.Text))
            {
                MessageBox.Show("Please fill in the zone name, coverage area, and schedule.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvZones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvZones.Rows[e.RowIndex];
            selectedZoneId = Convert.ToInt32(row.Cells["zone_id"].Value);
            txtZoneName.Text = row.Cells["Zone Name"].Value.ToString();
            txtCoverageArea.Text = row.Cells["Coverage Area"].Value.ToString();
            txtSched.Text = row.Cells["Schedule"].Value.ToString();
        }

        private void btnAddZone_Click(object sender, EventArgs e)
        {
            if (!ZoneFieldsValid()) return;

            try
            {
                Execute("INSERT INTO delivery_zones (zone_name, coverage_area, schedule) VALUES (@zone, @area, @sched)",
                    new MySqlParameter("@zone", txtZoneName.Text.Trim()),
                    new MySqlParameter("@area", txtCoverageArea.Text.Trim()),
                    new MySqlParameter("@sched", txtSched.Text.Trim()));
                MessageBox.Show("Delivery zone added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadZones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditZone_Click(object sender, EventArgs e)
        {
            if (selectedZoneId == 0)
            {
                MessageBox.Show("Please select a zone from the list first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ZoneFieldsValid()) return;

            try
            {
                Execute("UPDATE delivery_zones SET zone_name=@zone, coverage_area=@area, schedule=@sched WHERE zone_id=@id",
                    new MySqlParameter("@zone", txtZoneName.Text.Trim()),
                    new MySqlParameter("@area", txtCoverageArea.Text.Trim()),
                    new MySqlParameter("@sched", txtSched.Text.Trim()),
                    new MySqlParameter("@id", selectedZoneId));
                MessageBox.Show("Delivery zone updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadZones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteZone_Click(object sender, EventArgs e)
        {
            if (selectedZoneId == 0)
            {
                MessageBox.Show("Please select a zone from the list first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this zone?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Execute("DELETE FROM delivery_zones WHERE zone_id=@id",
                    new MySqlParameter("@id", selectedZoneId));
                MessageBox.Show("Delivery zone deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadZones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- PRICING ----------

        private void LoadPricing()
        {
            dgvPricing.DataSource = Query(
                "SELECT container_size AS 'Container Size', price AS 'Price' FROM pricing ORDER BY price_id");
            if (dgvPricing.Columns["Price"] != null)
                dgvPricing.Columns["Price"].DefaultCellStyle.Format = "0.00";
            dgvPricing.ClearSelection();
        }

        private void dgvPricing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string size = dgvPricing.Rows[e.RowIndex].Cells["Container Size"].Value.ToString();
            int index = cmbContainerSize.Items.IndexOf(size);
            if (index >= 0)
                cmbContainerSize.SelectedIndex = index;
        }

        private void cmbContainerSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContainerSize.SelectedItem == null) return;

            try
            {
                var table = Query("SELECT price FROM pricing WHERE container_size=@size",
                    new MySqlParameter("@size", cmbContainerSize.SelectedItem.ToString()));
                txtPrice.Text = table.Rows.Count > 0
                    ? Convert.ToDecimal(table.Rows[0]["price"]).ToString("0.00")
                    : "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            if (cmbContainerSize.SelectedItem == null)
            {
                MessageBox.Show("Please select a container size.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Execute(@"INSERT INTO pricing (container_size, price) VALUES (@size, @price)
                          ON DUPLICATE KEY UPDATE price=@price",
                    new MySqlParameter("@size", cmbContainerSize.SelectedItem.ToString()),
                    new MySqlParameter("@price", price));
                MessageBox.Show("Price saved successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPricing();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- CREDIT ----------

        private void LoadCredit()
        {
            dgvCredit.DataSource = Query(
                "SELECT customer_id, customer_name AS 'Customer Name', credit AS 'Credit' FROM customers_credit ORDER BY customer_name");
            if (dgvCredit.Columns["customer_id"] != null)
                dgvCredit.Columns["customer_id"].Visible = false;
            if (dgvCredit.Columns["Credit"] != null)
                dgvCredit.Columns["Credit"].DefaultCellStyle.Format = "0.00";
            dgvCredit.ClearSelection();
        }

        private void dgvCredit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvCredit.Rows[e.RowIndex];
            txtCustomerName.Text = row.Cells["Customer Name"].Value.ToString();
            txtCredit.Text = Convert.ToDecimal(row.Cells["Credit"].Value).ToString("0.00");
        }

        private void btnSaveCreditLimit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter the customer name.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtCredit.Text, out decimal credit) || credit < 0)
            {
                MessageBox.Show("Please enter a valid credit amount.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Execute(@"INSERT INTO customers_credit (customer_name, credit) VALUES (@name, @credit)
                          ON DUPLICATE KEY UPDATE credit=@credit",
                    new MySqlParameter("@name", txtCustomerName.Text.Trim()),
                    new MySqlParameter("@credit", credit));
                MessageBox.Show("Credit saved successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Clear();
                txtCredit.Clear();
                LoadCredit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}