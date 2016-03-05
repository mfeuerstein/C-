using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2___MIchael_Feuerstein
{
    public class Admin:BankAccount
    {
        public Admin() { }

        public Admin(string userID, string password)
        {
            this.userID = userID;
            this.password = password;
        }

        public Admin(Admin account)
        {
            this.userID = account.userID;
            this.password = account.password;
        }

        public override bool canLogin()
        {
            return false;
        }
    }
}
