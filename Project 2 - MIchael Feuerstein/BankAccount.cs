using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2___MIchael_Feuerstein
{
    abstract public class BankAccount
    {
        protected string userID;
        protected string password;

        public BankAccount() { }

        /*public BankAccount(string userID, string password)
        {
            this.userID = userID;
            this.password = password;
        }

        public BankAccount(BankAccount account)
        {
            this.userID = account.userID;
            this.password = account.password;
        }*/

        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public abstract bool canLogin();
    }
}
