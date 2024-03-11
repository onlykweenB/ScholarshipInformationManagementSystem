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
    public partial class ScholarshipType : Form
    {
        public ScholarshipType()
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
            string query = "INSERT INTO tbl_scholarshiptype (CategoryName, ScholarshipType) VALUES ('" + this.CategoryName2.Text + "', '"+this.ScholarshipType2.Text+"')";
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
            string query = "UPDATE tbl_scholarshiptype SET CategoryName = '" + this.CategoryName2.Text + "', ScholarshipType = '"+this.ScholarshipType2.Text+"' WHERE TypeID = '" + this.TypeID.Text + "' ";
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
            string query = "DELETE FROM tbl_scholarshiptype WHERE TypeID = '" + this.TypeID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Deleted Successfully.");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeID.Text = "";
            CategoryName2.Text = "";
            ScholarshipType2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "SELECT * FROM tbl_scholarshiptype";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home category = new Home();
            category.Show();
            this.Hide();
        }

        private void ScholarshipType_Load(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost; user id=root; password=; database=manageadministrator";
                string query = "SELECT CategoryName FROM tbl_scholarshipcategory";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                da.Fill(dt);
                conn.Close();

                CategoryName2.DataSource = dt; 
                CategoryName2.DisplayMember = "CategoryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
