using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectGUI
{
    public partial class EmailForm : Form
    {
        //interfaceClassesClient cc = new interfaceClassesClient();
        public List<int> fileIds = new List<int>();
        private string email = "paul.curea.andrei@outlook.com";
        private string emailPassword = System.IO.File.ReadAllText("D:\\dotnet\\advanced\\Proiect1\\GUI\\ProjectGUI\\ProjectGUI\\emailPassword.txt").Trim();
        public EmailForm()
        {
            InitializeComponent();
        }

        private void sendEmail(object sender, EventArgs e)
        {
            interfaceClassesClient cc = new interfaceClassesClient();
            // trimite parametrii catre API pentru a trimite email
            string receverEmail = ReceverEmailInput.Text;
            string from = ReceverNameInput.Text;
            string subject = SubjectInput.Text;
            string body = EmailBody.Text;
            if(receverEmail != "" && from != "" && subject != "")
            {
                cc.SendEmail(receverEmail, from, subject, body, fileIds.ToArray(), email, emailPassword);

        
                Dispose();
            }
            else
            {
                MessageBox.Show("Complete the email, name and subject");
            }
            cc.Close();
            
        }

      
    }
}
