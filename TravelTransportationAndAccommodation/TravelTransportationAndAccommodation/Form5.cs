using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelTransportationAndAccommodation
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql1 = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");
            string query = "Select * from adminLoginData Where adminUserName = '" + textBox1.Text.Trim() + "' and adminPassword = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql1);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("admin log in");
                Form8 f8 = new Form8(); 
                f8.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void F5BackE(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void F5BackL(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButton));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       

    }
}
