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
    public partial class ScholarshipInformation : Form
    {
        public ScholarshipInformation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home category = new Home();
            category.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ScholarCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentNumber.Text = "";
            FullName2.Text = "";
            Program.Text = "";
            YearLevel.Text = "";
            DateofBirth.Text = "";
            Address.Text = "";
            EmailAddress.Text = "";
            ContactNumber.Text = "";
            Age.Text = "";
            Siblings.Text = "";
            SCCombo.Text = "";
            STCombo.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "SELECT * FROM tbl_scholarshipinformation";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ScholarshipInformation_Load(object sender, EventArgs e)
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

                SCCombo.DataSource = dt; //dito rhenzo yong SCCombo tinawag mo dito same lang din sa isang combobox kita mo yong stcombo yes
                SCCombo.DisplayMember = "CategoryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string connection = "server=localhost; user id=root; password=; database=manageadministrator";
                string query = "SELECT ScholarshipType FROM tbl_scholarshiptype";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("ScholarshipType", typeof(string));
                da.Fill(dt);
                conn.Close();

                STCombo.DataSource = dt; 
                STCombo.DisplayMember = "ScholarshipType";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=manageadministrator";
            string query = "INSERT INTO tbl_scholarshipinformation (StudentNumber, FullName, Program, YearLevel, DOB, Address, EmailAddress, ContactNumber, Age, Siblings, ScholarshipCategory, ScholarshipType) VALUES ('" + this.StudentNumber.Text + "', '" + this.FullName2.Text + "', '" + this.Program.Text + "', '" + this.YearLevel.Text + "', '" + this.DateofBirth.Text + "', '" + this.Address.Text + "', '" + this.EmailAddress.Text + "', '" + this.ContactNumber.Text + "', '" + this.Age.Text + "', '" + this.Siblings.Text + "', '" + this.SCCombo.Text + "', '" + this.STCombo.Text + "')";
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
            string query = "UPDATE tbl_scholarshipinformation SET FullName = '" + this.FullName2.Text + "', Program = '" + this.Program.Text + "', YearLevel = '" + this.YearLevel.Text + "', DOB = '" + this.DateofBirth.Text + "', Address = '" + this.Address.Text + "', EmailAddress = '" + this.EmailAddress.Text + "', ContactNumber = '" + this.ContactNumber.Text + "' , Age = '" + this.Age.Text + "' , Siblings= '" + this.Siblings.Text + "', ScholarshipCategory = '" + this.SCCombo.Text + "', ScholarshipType = '" + this.STCombo.Text + "' WHERE StudentNumber = '" + this.StudentNumber.Text + "' ";
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
            string query = "DELETE FROM tbl_scholarshipinformation WHERE StudentNumber = '" + this.StudentNumber.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Deleted Successfully.");
            conn.Close();
        }
    }
}
