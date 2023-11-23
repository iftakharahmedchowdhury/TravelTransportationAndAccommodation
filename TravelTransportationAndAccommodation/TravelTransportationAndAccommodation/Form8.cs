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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void F8BackE(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void F8BackL(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButton));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }
    }
}
