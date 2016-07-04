using AccountsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //create new account
                Console.WriteLine("Creating user1 account...");
                Console.WriteLine("Enter id:");
                int id1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter ibalance:");
                double b1 = Convert.ToDouble(Console.ReadLine());

                var account1 = new Account(id1);
                account1 = AccountFactory.CreateAccount(id1, b1);

                //deposit withdraw or check balance
                Console.WriteLine("What would you like to do, choose one option:");
                Console.WriteLine("a. Deposit");
                Console.WriteLine("b. Withdraw");
                Console.WriteLine("c. Check balance");
          
                string userSelect = Console.ReadLine();
                switch (userSelect)
                {
                    case "a":
                        Console.WriteLine("Enter amount for deposit:");
                        account1.Deposit(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case "b":
                        Console.WriteLine("Enter amount for withdraw:");
                        account1.Withdraw(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case "c":
                        Console.WriteLine("Your current balance is: {0}", account1.balance());
                        break;

                    default:
                        Console.WriteLine("No such option.");
                        break;
                }



                //create another account
                Console.WriteLine("Creating user2 account...");
                Console.WriteLine("Enter id:");
                int id2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter ibalance:");
                double b2 = Convert.ToDouble(Console.ReadLine());

                var account2 = new Account(id2);
                account2 = AccountFactory.CreateAccount(id2, b2);

                Console.WriteLine("User2, how much mony would you like to transfer to user1?");
                double trns = Convert.ToDouble(Console.ReadLine());

                //transfer 50 from user2 to user1
                if (account2.Transfer(account1, trns))
                {
                    Console.WriteLine("Mony transfer has done.");
                    Console.WriteLine("User1 balance: {0} \nUser2 balance: {1}", account1.balance(), account2.balance());
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}
