using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelTransportationAndAccommodation
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void F19BackE(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void F19BackL(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButton));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True");
            conn1.Open();


            SqlCommand cmd2 = new SqlCommand("Update sajekInformation set availableTicket = @availableTicket,availableHotel = @availableHotel, busName=@busName,hotelName=@hotelName  where customerUserName  =@customerUserName", conn1);
            cmd2.Parameters.AddWithValue("@customerUserName", "manager1");
            cmd2.Parameters.AddWithValue("@availableTicket", textBox2.Text);
            cmd2.Parameters.AddWithValue("@availableHotel", textBox4.Text);
            cmd2.Parameters.AddWithValue("@busName", textBox1.Text);
            cmd2.Parameters.AddWithValue("@hotelName", textBox3.Text);
            cmd2.ExecuteNonQuery();


            conn1.Close();

            MessageBox.Show("Data updated");
        }
    }
}
