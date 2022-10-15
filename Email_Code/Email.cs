using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Code
{
    public partial class Email : Form
    {
        public int num = 0;
        public int generated_code = 0;

        public Email()
        {
            InitializeComponent();
        }

        private void btn_checkcode_Click(object sender, EventArgs e)
        {
            try
            {
                num = int.Parse(txt_usr.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            if(num == generated_code && num > 100000)
            {
                lbl_result.Text = "Correct Number";
            }
            else
            {
                lbl_result.Text = "Wrong Number !";
            }
        }

        private void btn_sendCode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            generated_code = rnd.Next(100000,1000000);

            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "__Your_Email__",
                    Password = "__Your_Password__"
                }
            };
            MailAddress FromEmail = new MailAddress("From-email@gmail.com", "Subject);
            MailAddress ToEmail = new MailAddress("To-email@gmail.com", "Someone");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "New User Request Code",
                Body = "New User has requested to Create an account.\nSend him/her this code him/her to proceed.\nCode : " + generated_code.ToString(),
            };
            Message.To.Add(ToEmail);

            Client.SendCompleted += Client_SendCompleted;
            Client.SendMailAsync(Message);
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Error : " + e.Error.Message);
                return;
            }
            else
            {
                MessageBox.Show("Contact Admin to get the code.","Sent Successfully !");
            }
        }
    }
}
