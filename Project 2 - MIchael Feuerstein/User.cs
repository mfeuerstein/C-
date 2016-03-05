using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2___MIchael_Feuerstein
{
    public class User:BankAccount
    {
            double checkingAccount;
            double savingsAccount;
            int checkingAccountNumber;
            int savingsAccountNumber;

            public User() { }

            public User(string userID, string password, double checkingAccount,
                               double savingsAccount, int checkingAccountNumber,
                               int savingsAccountNumber)
            {
                this.userID = userID;
                this.password = password;
                this.checkingAccount = checkingAccount;
                this.savingsAccount = savingsAccount;
                this.checkingAccountNumber = checkingAccountNumber;
                this.savingsAccountNumber = savingsAccountNumber;
            }

            public User(User account)
            {
                this.userID = account.userID;
                this.password = account.password;
                this.checkingAccount = account.checkingAccount;
                this.savingsAccount = account.savingsAccount;
                this.checkingAccountNumber = account.checkingAccountNumber;
                this.savingsAccountNumber = account.savingsAccountNumber;
            }

            public double CheckingAccount
            {
                get
                {
                    return checkingAccount;
                }
                set
                {
                    checkingAccount = value;
                }
            }

            public double SavingsAccount
            {
                get
                {
                    return savingsAccount;
                }
                set
                {
                    savingsAccount = value;
                }
            }

            public int CheckingAccountNumber
            {
                get
                {
                    return checkingAccountNumber;
                }
                set
                {
                    checkingAccountNumber = value;
                }
            }

            public int SavingsAccountNumber
            {
                get
                {
                    return savingsAccountNumber;
                }
                set
                {
                    savingsAccountNumber = value;
                }
            }

            public int hasAccount(int accountNumber)
            {
                if (accountNumber == CheckingAccountNumber)
                    return 0;
                else if (accountNumber == SavingsAccountNumber)
                    return 1;
                else
                    return -1;
            }

            public bool addFunds(int account, double amount)
            {
                if (account == 0 || account == 1)
                {
                    if (account == 0)
                        checkingAccount += amount;
                    else
                        savingsAccount += amount;
                    return true;
                }

                return false;
            }

            public bool reduceFunds(int account, double amount)
            {
                if (account == 0 || account == 1)
                {
                    if (account == 0)
                        if (amount <= checkingAccount)
                            checkingAccount -= amount;
                        else
                            return false;
                    else
                        if (amount <= savingsAccount)
                            checkingAccount -= amount;
                        else
                            return false;

                    return true;
                }

                return false;
            }

            public override bool canLogin()
            {
                return true;
            }
    }
}