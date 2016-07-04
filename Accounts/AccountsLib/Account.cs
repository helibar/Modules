using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public class Account
    {
        int _accId;
        double _balance;

        public Account(int accId)
        {
            _accId = accId;
        }

        public int id()
        {
            return _accId;
        }

        public bool Deposit(double amount)
        {
            _balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if ((_balance-amount) < 0)
            {
                Console.WriteLine("Withdraw is not allowed,your account cannot be in overdraft");
                return false;
            }

            _balance -= amount;
            return true;
        }

        public double balance()
        {
            return _balance;
        }

        public bool Transfer(Account account, double amount)
        {
            if (Withdraw(amount)) //withdrawing mony succeeded?
            {
                account.Deposit(amount);
                return true;
            }
            else
            {
                return false;
            }
           
        }

    }
}
