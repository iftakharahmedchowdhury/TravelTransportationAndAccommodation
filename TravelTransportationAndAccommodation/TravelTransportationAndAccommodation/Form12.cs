using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelTransportationAndAccommodation
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        string customerUserName;
        public void getCustomerUserName(string u)
        {
            customerUserName = u;
            labelUser.Text = u;



        }
       
        private void BackE(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void BackL(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButton));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            
            f13.Show();
            f13.getCustomerUserName(customerUserName);
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            f16.getCustomerUserName(customerUserName);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            f17.getCustomerUserName(customerUserName);
            this.Hide();
        }
    }
}
