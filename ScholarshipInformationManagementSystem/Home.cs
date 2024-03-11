using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarshipInformationManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Administrator user = new Administrator();
            user.Show();
            this.Hide();
        }

        private void ScholarshipCategory_Click(object sender, EventArgs e)
        {
            ScholarshipCategory category = new ScholarshipCategory();
            category.Show();
            this.Hide();
        }

        private void ScholarshipType_Click(object sender, EventArgs e)
        {
            ScholarshipType category = new ScholarshipType();
            category.Show();
            this.Hide();
        }

        private void ScholarshipForm1_Click(object sender, EventArgs e)
        {
            ScholarshipInformation category = new ScholarshipInformation();
            category.Show();
            this.Hide();
        }
    }
}
