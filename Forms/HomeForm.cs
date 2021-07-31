using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkritKCFormApplication.Forms;
using System.IO;

namespace AkritKCFormApplication.Forms
{
    public partial class HomeForm : Form
    {
        FileHelp fileHelper;
        List<String> credentials;
        List<String[]> credentialsSplited;
        String username;
        String password;
        public HomeForm()
        {
            InitializeComponent();
            passwordTxtBxHm.PasswordChar = '*';
            
        }

        private void loginBtnHomePg_Click(object sender, EventArgs e)
        {
            Boolean fail = true;
            fileHelper = new FileHelp();
            credentials = fileHelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Credentials.csv");
            
            Console.WriteLine(Environment.CurrentDirectory);
            credentialsSplited = fileHelper.SplitRow(credentials);
            for (int i = 0; i < credentialsSplited.Count; i++)
            {
                
                if (username == credentialsSplited[i][0] && password == credentialsSplited[i][1])
                {
                    fail = false;
                }
            }
            if (fail)
            {
                MessageBox.Show("Credentials are not correct", "Login error");
            }
            else
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.Show();
            }


            
        }

        private void reviewBtnHomePg_Click(object sender, EventArgs e)
        {
            FeedbackForm reviewForm = new FeedbackForm();
            this.Hide();
            reviewForm.Show();
           
        }

        private void userNameTxtBxHome_TextChanged(object sender, EventArgs e)
        {
            username = userNameTxtBxHome.Text;
        }

        private void passwordTxtBxHm_TextChanged(object sender, EventArgs e)
        {
            password = passwordTxtBxHm.Text;
        }
    }
}
