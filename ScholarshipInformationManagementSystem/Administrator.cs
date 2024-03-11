using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ScholarshipInformationManagementSystem
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "INSERT INTO tbl_manageadministrator(FullName, Username, Password) VALUES ('" + this.FullName.Text + "', '" + this.Username.Text + "', '" + this.Password.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved.");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "UPDATE tbl_manageadministrator SET FullName = '" + this.FullName.Text + "', Username = '" + this.Username.Text + "', Password =  '" + this.Password.Text + "' WHERE AdminID = '" + this.AdminID.Text + "' ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Updated Successfully.");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "DELETE FROM tbl_manageadministrator WHERE AdminID = '" + this.AdminID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Deleted Successfully.");
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "SELECT * FROM tbl_manageadministrator";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminID.Text = "";
            FullName.Text = "";
            Username.Text = "";
            Password.Text = "";
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home category = new Home();
            category.Show();
            this.Hide();
        }
    }
}
