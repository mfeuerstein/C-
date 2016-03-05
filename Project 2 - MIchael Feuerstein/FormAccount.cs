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
    public partial class FormAccount : Form
    {
        User account;

        public FormAccount(ref User account)
        {
            InitializeComponent();
            this.account = account;
            this.Text = account.UserID + "'s Account";
        }

        private void radioExit_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDeposit.Checked == true)
            {
                FormDeposit deposit = new FormDeposit(ref account);
                deposit.ShowDialog();
                radioDeposit.Checked = false;
            }
        }

        private void radioWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWithdraw.Checked == true)
            {
                FormWithdraw withdraw = new FormWithdraw(ref account);
                withdraw.ShowDialog();
                radioWithdraw.Checked = false;
            }
        }

        private void radioBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBalance.Checked == true)
            {
                FormBalance balance = new FormBalance(account);
                balance.ShowDialog();
                radioBalance.Checked = false;
            }
        }

        private void radioTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTransfer.Checked == true)
            {
                FormTransfer transfer = new FormTransfer(ref account);
                transfer.ShowDialog();
                radioTransfer.Checked = false;
            }
        }
    }
}
