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
    public partial class FormBalance : Form
    {
        User account;

        public FormBalance(User account)
        {
            InitializeComponent();
            this.account = new User(account);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBalance.Text = "";
            labelBalance.Text = "Account Balance";

            if (validateInputs())
                balance();
        }

        private bool validateInputs()
        {
            return Validator.IsPresent(textAccountNum, "Account Number") &&
                   Validator.hasMinChar(textAccountNum, "Account Number", 8) &&
                   Validator.IsInt32(textAccountNum, "Account Number");
        }

        private void balance()
        {
            int accountNum = account.hasAccount(Convert.ToInt32(textAccountNum.Text));

            if (accountNum != -1)
            {
                if (accountNum == 0)
                {
                    labelBalance.Text = "Checking Balance";
                    textBalance.Text = account.CheckingAccount + "";
                }
                else
                {
                    textBalance.Text = account.SavingsAccount + "";
                    labelBalance.Text = "Savings Balance";
                }
            }
            else
                MessageBox.Show("Account not found.");
        }
    }
}
