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
    public partial class FormDeposit : Form
    {
        User account;

        public FormDeposit(ref User account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textDepositAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (validateInputs())
                deposit();
        }

        private bool validateInputs()
        {
            return Validator.IsPresent(textAccountNum, "Account Number") &&
                   Validator.hasMinChar(textAccountNum, "Account Number", 8) &&
                   Validator.IsInt32(textAccountNum, "Account Number") &&

                   Validator.IsPresent(textDepositAmount, "Deposit Amount") &&
                   Validator.IsInt32(textDepositAmount, "Deposit Amount") &&
                   Validator.IsPositive(textDepositAmount, "Deposit Amount");
        }

        private void deposit()
        {
            int accountNum = account.hasAccount(Convert.ToInt32(textAccountNum.Text));
            double depositAmount = Convert.ToDouble(textDepositAmount.Text);

            if (accountNum != -1)
            {
                account.addFunds(accountNum, depositAmount);
                this.Close();
            }
            else
                MessageBox.Show("Account not found.");
        }
    }
}
