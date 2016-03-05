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
    public partial class FormWithdraw : Form
    {
        User account;

        public FormWithdraw(ref User account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            if (validateInputs())
                withdraw();
        }

        private bool validateInputs()
        {
            return Validator.IsPresent(textAccountNum, "Account Number") &&
                   Validator.hasMinChar(textAccountNum, "Account Number", 8) &&
                   Validator.IsInt32(textAccountNum, "Account Number") &&

                   Validator.IsPresent(textWithdrawAmount, "Withdrawal Amount") &&
                   Validator.IsInt32(textWithdrawAmount, "Withdrawal Amount") &&
                   Validator.IsPositive(textWithdrawAmount, "Withdrawal Amount");
        }

        private void withdraw()
        {
            int accountNum = account.hasAccount(Convert.ToInt32(textAccountNum.Text));
            double withdrawAmount = Convert.ToDouble(textWithdrawAmount.Text);

            if (accountNum != -1)
            {
                if(!account.reduceFunds(accountNum, withdrawAmount))
                    MessageBox.Show("Account has insufficient funds.");
                else
                    this.Close();
            }
            else
                MessageBox.Show("Account not found.");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
