﻿using System;
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
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            _balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            else if ((_balance - amount) < 0)
            {
                throw new InsufficientFundsException("Action canceled. Overdraft is not allowed.");
            }

            _balance -= amount;
            return true;
        }

        public double balance()
        {
            return _balance;
        }

        public void Transfer(Account account, double amount)
        {
            try
            {
                if (Withdraw(amount))
                {
                    account.Deposit(amount);
                    Console.WriteLine("Money Transfer successfully done!");
                    Console.WriteLine("Balance before transfer was: " + (_balance + amount));
                }
            }
            finally
            {
                Console.WriteLine("Transfer attempt has been made for account:{0}. amount is: {1} \nCurrent balance is: {2}" ,_accId,amount ,_balance);
            }

        }

    }
}
