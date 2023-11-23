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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        string customerUserNameF13;
        public void getCustomerUserName(string u13)
        {
            customerUserNameF13 = u13;
            label7.Text = customerUserNameF13;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void BackE(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void BackL(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButton));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Regex r1 = new Regex(@"^[0-9]{11}$");
            Regex r2 = new Regex(@"^[0-9]{2}$");
            Regex r3 = new Regex(@"^[0-9]{2}$");


            if (r1.IsMatch(textBox7.Text))
            {
                textBox7.BackColor = SystemColors.Window;

                if (r2.IsMatch(textBox1.Text))
                {
                    textBox1.BackColor = SystemColors.Window;
                    if (r3.IsMatch(textBox3.Text))
                    {
                        textBox3.BackColor = SystemColors.Window;

                        //SQL part
                        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into CoxBazarInformation values (@placeName,@customerUserName,@CustomerName,@CustomerPhoneNumber,@busName,@availableTicket,@hotelName,@availableHotel,@customerTicket,@customerAccommodation)", conn);
                        int seat = int.Parse(label4.Text);
                        seat = seat - int.Parse(textBox1.Text);

                        int room = int.Parse(label10.Text);
                        room = room - int.Parse(textBox3.Text);

                        string availableTickets = seat.ToString();
                        string availableRoom = room.ToString();

                        cmd.Parameters.AddWithValue("@placeName", (label6.Text));
                        cmd.Parameters.AddWithValue("@customerUserName", (customerUserNameF13.ToString()));
                        cmd.Parameters.AddWithValue("@CustomerName", (textBox5.Text));
                        cmd.Parameters.AddWithValue("@CustomerPhoneNumber", (textBox7.Text));
                        cmd.Parameters.AddWithValue("@busName", (label3.Text));
                        cmd.Parameters.AddWithValue("@availableTicket", (availableTickets));
                        cmd.Parameters.AddWithValue("@hotelName", (label11.Text));
                        cmd.Parameters.AddWithValue("@availableHotel", (availableRoom));
                        cmd.Parameters.AddWithValue("@customerTicket", (textBox1.Text));
                        cmd.Parameters.AddWithValue("@customerAccommodation", (textBox3.Text));



                        cmd.ExecuteNonQuery();
                        conn.Close();


                        ///////////////////////////////////
                        

                        SqlConnection conn1 = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");
                        conn1.Open();


                        SqlCommand cmd2 = new SqlCommand("Update CoxBazarInformation set availableTicket = @availableTicket,availableHotel = @availableHotel where customerUserName  =@customerUserName", conn1);
                        cmd2.Parameters.AddWithValue("@customerUserName", "manager1");
                        cmd2.Parameters.AddWithValue("@availableTicket", availableTickets);
                        cmd2.Parameters.AddWithValue("@availableHotel", availableRoom);
                        cmd2.ExecuteNonQuery();


                        conn1.Close();



                        ///////
                      

                        SqlConnection conn2 = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");
                        conn2.Open();


                        SqlCommand cmd3 = new SqlCommand("Select availableTicket,availableHotel from CoxBazarInformation where customerUserName  =@customerUserName", conn2);
                        cmd3.Parameters.AddWithValue("@customerUserName", "manager1");

                        //cmd3.ExecuteNonQuery();
                        SqlDataReader da = cmd3.ExecuteReader();
                        while (da.Read())
                        {
                            label4.Text = da.GetValue(0).ToString();
                            label10.Text = da.GetValue(1).ToString();
                        }


                        conn2.Close();

                        MessageBox.Show("Confirm registration Payment successful");


                    }

                    else
                    {
                        textBox3.BackColor = Color.LightPink;
                        MessageBox.Show("Please insert valid Phone number");
                    }

                }
                else
                {
                    textBox1.BackColor = Color.LightPink;
                    MessageBox.Show("Please insert valid Phone number");
                }


            }
            else
            {
                textBox7.BackColor = Color.LightPink;
                MessageBox.Show("Please insert valid phone number");
            }

              

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = customerUserNameF13;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");
            conn2.Open();


            SqlCommand cmd3 = new SqlCommand("Select availableTicket,availableHotel,busName,hotelName from CoxBazarInformation where customerUserName  =@customerUserName", conn2);
            cmd3.Parameters.AddWithValue("@customerUserName", "manager1");

            //cmd3.ExecuteNonQuery();
            SqlDataReader da = cmd3.ExecuteReader();
            while (da.Read())
            {
                label4.Text = da.GetValue(0).ToString();
                label10.Text = da.GetValue(1).ToString();
                label3.Text = da.GetValue(2).ToString();
                label11.Text = da.GetValue(3).ToString();
            }


            conn2.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
