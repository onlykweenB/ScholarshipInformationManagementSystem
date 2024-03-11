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
    public partial class ScholarshipCategory : Form
    {
        public ScholarshipCategory()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "INSERT INTO tbl_scholarshipcategory(CategoryName) VALUES ('" + this.CategoryName.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved.");
            conn.Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "UPDATE tbl_scholarshipcategory SET CategoryName = '" + this.CategoryName.Text + "' WHERE CategoryID = '" + this.CategoryID.Text + "' ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Updated Successfully.");
            conn.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "DELETE FROM tbl_scholarshipcategory WHERE CategoryID = '" + this.CategoryID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Deleted Successfully.");
            conn.Close();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            CategoryID.Text = "";
            CategoryName.Text = "";
        }

        public void button6_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "SELECT * FROM tbl_scholarshipcategory";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void Home_Click(object sender, EventArgs e)
        {
            Home category = new Home();
            category.Show();
            this.Hide();
        }

        private void CategoryID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
