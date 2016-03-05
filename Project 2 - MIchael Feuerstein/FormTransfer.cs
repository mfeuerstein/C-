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
    public partial class FormTransfer : Form
    {
        User account;

        public FormTransfer(ref User account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (validateInputs())
                transfer();
        }

        private bool validateInputs()
        {
            return Validator.IsPresent(textAccountFrom, "Account From") &&
                   Validator.hasMinChar(textAccountFrom, "Account From", 8) &&
                   Validator.IsInt32(textAccountFrom, "Account From") &&

                   Validator.IsPresent(textAccountTo, "Account To") &&
                   Validator.hasMinChar(textAccountTo, "Account To", 8) &&
                   Validator.IsInt32(textAccountTo, "Account To") &&

                   Validator.IsPresent(textTransferAmount, "Transfer Amount") &&
                   Validator.IsInt32(textTransferAmount, "Transfer Amount") &&
                   Validator.IsPositive(textTransferAmount, "Transfer Amount");
        }

        private void transfer()
        {
            int accountFrom = account.hasAccount(Convert.ToInt32(textAccountFrom.Text));
            int accountTo = account.hasAccount(Convert.ToInt32(textAccountTo.Text));
            double transferAmount = Convert.ToDouble(textTransferAmount.Text);

            if (accountFrom != -1 && accountTo != -1)
            {
                bool check = account.reduceFunds(accountFrom, transferAmount);
                if (check)
                {
                    account.addFunds(accountTo, transferAmount);
                    this.Close();
                }
                else
                    MessageBox.Show("Account has insufficient funds.");
            }
            else
                MessageBox.Show("Account(s) not found.");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
