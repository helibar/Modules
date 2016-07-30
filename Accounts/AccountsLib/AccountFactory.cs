using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public static class AccountFactory
    {
        //The CreateAccount should create the id.
        public static Account CreateAccount(int id,double balance)
        {
            var account = new Account(id);
            account.Deposit(balance);
            return account;
        }

    }
}
