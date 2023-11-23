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
using System.Text.RegularExpressions;

namespace TravelTransportationAndAccommodation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void picBox1E(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void picBox1L(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButton));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlConnection sqlcon = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");
            string queryC = "Select * from customerRegistration Where customerUserName ='" + textBox2.Text.Trim()+ "'";
            SqlDataAdapter sdaC = new SqlDataAdapter(queryC, sqlcon);
            DataTable dtblC = new DataTable();
            sdaC.Fill(dtblC);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) ))
            {
                MessageBox.Show("Please fill all the field");

            }
            else
            {
                if (dtblC.Rows.Count == 1)
                {
                    MessageBox.Show("User have account");
                }
                else
                {
                    Regex r1 = new Regex(@"^[0-9]{11}$");
                    Regex r2 = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                    if (r2.IsMatch(textBox3.Text))
                    {
                        textBox3.BackColor = SystemColors.Window;

                        if (r1.IsMatch(textBox5.Text))
                        {
                            textBox5.BackColor = SystemColors.Window;

                            //insert into database
                            if (radioButton1.Checked)
                            {
                                SqlConnection sqlCusReg = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");

                                string query = "INSERT INTO customerRegistration (customerName, customerUserName, customerEmail, customerCity, customerPhoneNumber, customerPassword,customerGender)VALUES ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "','" + radioButton1.Text.Trim() + "');";
                                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCusReg);
                                DataTable dtbl = new DataTable();
                                sda.Fill(dtbl);
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                radioButton1.Checked = false;

                                MessageBox.Show("Data inserted");
                            }
                            else if (radioButton2.Checked)
                            {
                                SqlConnection sqlCusReg = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");

                                string query = "INSERT INTO customerRegistration (customerName, customerUserName, customerEmail, customerCity, customerPhoneNumber, customerPassword,customerGender)VALUES ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "','" + radioButton2.Text.Trim() + "');";
                                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCusReg);
                                DataTable dtbl = new DataTable();
                                sda.Fill(dtbl);
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                radioButton2.Checked = false;

                                MessageBox.Show("Data inserted");


                            }
                            else if (radioButton3.Checked)
                            {
                                SqlConnection sqlCusReg = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");

                                string query = "INSERT INTO customerRegistration (customerName, customerUserName, customerEmail, customerCity, customerPhoneNumber, customerPassword,customerGender)VALUES ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "','" + radioButton3.Text.Trim() + "');";
                                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCusReg);
                                DataTable dtbl = new DataTable();
                                sda.Fill(dtbl);
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                radioButton3.Checked = false;

                                MessageBox.Show("Data inserted");
                            }

                        }
                        else
                        {
                            textBox5.BackColor = Color.LightPink;
                            MessageBox.Show("Please insert valid Phone number");
                        }


                    }
                    else
                    {
                        textBox3.BackColor = Color.LightPink;
                        MessageBox.Show("Please insert valid email");
                    }

                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox6.UseSystemPasswordChar = false;
            }
            else
            {
                textBox6.UseSystemPasswordChar = true;
            }
        }
    }
}
