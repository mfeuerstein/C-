using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2___MIchael_Feuerstein
{
    public partial class FormLogin : Form
    {
        List<BankAccount> accounts;
        int loginCount;
        //User account;

        public FormLogin()
        {
            InitializeComponent();
            loginCount = 0;
            accounts = new List<BankAccount>();
            accounts.Add(new Admin("admin", "0000"));
            accounts.Add(new User("a2345678", "1234", 100, 200, 12345678, 87654321));
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (validateInputs())
                login();
        }

        private void login()
        {
            buttonClose.Enabled = false;
            if (loginCount < 3)
                labelMessage.Text = "";

            BankAccount temp = accounts.Find(i => i.UserID.Equals(textUsername.Text));
            if (temp != null)
            {
                if (textPassword.Text.Equals(temp.Password))
                {
                    if (temp.canLogin() && loginCount < 3)
                    {
                        User account = (User)temp;
                        this.Visible = false;
                        FormAccount accountform = new FormAccount(ref account);
                        accountform.ShowDialog();
                        this.Visible = true;
                        this.Focus();
                    }
                    else if (!temp.canLogin())
                    {
                        buttonClose.Enabled = true;
                        loginCount = 0;
                        labelMessage.Text = "Admin access granted";
                    }
                }
            }
            else
            {
                loginCount++;
                if (loginCount == 3)
                {
                    labelMessage.Text = "PLEASE SEE A BANK OFFICER - NO FURTHER LOGIN ATTEMPTS ALLOWED";
                }
            }
        }

        private bool validateInputs()
        {
            return Validator.IsPresent(textUsername, "Username") &&
                   Validator.isAlphanumeric(textUsername, "Username") &&
                   Validator.startsWithLetter(textUsername, "Username") &&
                   (textUsername.Text.Equals("admin") || Validator.hasMinChar(textUsername, "Username", 8) ) &&

                   Validator.IsPresent(textPassword, "Password") &&
                   Validator.IsInt32(textPassword, "Password") &&
                   Validator.hasMinChar(textPassword, "Password", 4);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
