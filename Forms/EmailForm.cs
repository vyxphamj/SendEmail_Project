using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SendEmail_Project
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {
            txtFromEmail.Text = "thisforpublic2021@gmail.com";
            txtFromPassword.Text = "Ho@ngduong1";
            listViewToEmail.Items.Add(new ListViewItem { Text = "giavy2000@gmail.com" });
            listViewToEmail.Items.Add(new ListViewItem { Text = "vy.phamdonggia@hcmut.edu.vn" });
            txtSubject.Text = "Test";
            txtBody.Text = "vuot nguong tren";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listViewToEmail.Items.Add(new ListViewItem { Text = txtAddEmail.Text });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Create smtp
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(txtFromEmail.Text, txtFromPassword.Text);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            //Create message
            MailMessage message = new MailMessage();
            foreach (ListViewItem listViewItem in listViewToEmail.Items)
            {      
                message.From = new MailAddress(txtFromEmail.Text);
                message.To.Add(new MailAddress(listViewItem.Text));
                message.Subject = txtSubject.Text;
                message.Body = txtBody.Text;
            }

            //Send message
            smtp.Send(message);
        }
    }
}
