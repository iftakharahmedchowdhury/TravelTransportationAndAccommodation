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
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
        }
        string email;
       
        public void getData(string a)
        {
            email = a;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        //string email;
        
   /*     public void getData(string a)
        {
            email = $"{a}";
           
            textBox3.Text = a;
            //MessageBox.Show("aaa dfd "+textBox3.Text);
            label3.Text = "Id : " + a;


        }*/
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                label3.Text = email;
                SqlConnection sqlCusReg = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");


                /* string query = "UPDATE  customerRegistration SET  customerPassword ='"+textBox1.Text.Trim()+"' Where customerEmail = '" +textBox3.Text.Trim() + "'";*/
                string query = "UPDATE  customerRegistration SET  customerPassword ='" + textBox1.Text.Trim() + "' Where customerEmail = '" + email + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCusReg);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                MessageBox.Show("Data updated successfully");



            }
            else
            {
                MessageBox.Show("Please enter same password");
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = email;
        }

        private void F7BackE(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void F7BackL(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButton));
        }
    }
}
