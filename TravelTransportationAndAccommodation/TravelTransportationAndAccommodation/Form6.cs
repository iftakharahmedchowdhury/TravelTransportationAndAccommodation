using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace TravelTransportationAndAccommodation
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.backButton));
        }


        string a;
        
        private void button1_Click(object sender, EventArgs e)
        {

            /*Form7 f7 = new Form7();
           // f2.Show();
            f7.getData(textBox1.Text);
            MessageBox.Show(textBox1.Text);*/
            



            SqlConnection sqlCuslog = new SqlConnection("Data Source=LAPTOP-JM49R2Q7\\SQL_IFTAKHAR;Initial Catalog=travelTransportationAndAccommodation;Integrated Security=True;");

            string query = "Select * from customerRegistration Where customerEmail = '" + textBox1.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCuslog);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                int code;
                string to, from, pass, messageBody;
                Random random = new Random();
                code = random.Next(321, 23543);
                a = Convert.ToString(code);
                //For email


                MailMessage mm = new MailMessage();
                mm.To.Add(new MailAddress(textBox1.Text, "Request for Verification"));
                mm.From = new MailAddress("mail address");// need to provide information to send code
                mm.Body = a;
                mm.IsBodyHtml = true;
                mm.Subject = "Verification";
                SmtpClient smcl = new SmtpClient();
                smcl.Host = "smtp.live.com";
                smcl.Port = 587;
                smcl.Credentials = new NetworkCredential("mail address", "mail password");// need to provide information to send code
                smcl.EnableSsl = true;
                // smcl.Send(mm);

                try
                {
                    smcl.Send(mm);
                    MessageBox.Show("Message send");
                    label3.Text = "Code : " + code;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("No registered account found.Do register first");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(a==textBox2.Text)
            {
                MessageBox.Show("Verification complete");
                Form7 f7 = new Form7();
                f7.Show();
                f7.getData(textBox1.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong code");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
