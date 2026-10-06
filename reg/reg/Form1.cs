using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace reg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check if password  match
            if (txtPassword.Text != txtConPassword.Text)
            {
                MessageBox.Show("Password do not match.");
                return;
            }

            // Basic empty field check
            if (txtFullName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill up all required fields.");
                return;
            }

            try
            {
                string MyConnection = "datasource=localhost;port=3306;username=root;password=;database=waterrefillingstationmanagementsystem";

                // Check kung existing na yung username
                string CheckQuery = "select * from customers where username='" + txtUsername.Text + "'";
                MySqlConnection CheckConn = new MySqlConnection(MyConnection);
                MySqlCommand CheckCommand = new MySqlCommand(CheckQuery, CheckConn);
                CheckConn.Open();
                MySqlDataReader checkRdr = CheckCommand.ExecuteReader();

                if (checkRdr.HasRows)
                {
                    MessageBox.Show("Username already exists. Please choose another.");
                    CheckConn.Close();
                    return;
                }
                CheckConn.Close();

                // Insert new customer
                string Query = "insert into customers(username,password,name,address,contact_number,alt_contact_name,alt_contact_number) " +
                               "values('" + this.txtUsername.Text + "','" + this.txtPassword.Text + "','" +
                               this.txtFullName.Text + "','" + this.txtAddress.Text + "','" +
                               this.txtContact.Text + "','" + this.txtAltName.Text + "','" +
                               this.txtAltNumber.Text + "');";

                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;

                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                MessageBox.Show("Registration Successful!");
                MyConn.Close();

                // Clear fields after successful register
                txtFullName.Clear();
                txtAddress.Clear();
                txtContact.Clear();
                txtAltName.Clear();
                txtAltNumber.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtConPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO
            MessageBox.Show("Login not yet connected");
        }
    }
}