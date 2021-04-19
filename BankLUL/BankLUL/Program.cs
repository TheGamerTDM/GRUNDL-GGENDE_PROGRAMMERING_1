using System;

namespace BankLUL
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wellcome to de bank");
            Console.WriteLine("Type your name:");
            string name = Console.ReadLine();

            // Make your account with name and how much money you want to start with e.g we start with 1000
            var account = new BankAccount(name, 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} Dkk. With initial balance.");
            Console.WriteLine();
            Console.WriteLine($"Wellcome {name} to your bank");
            Console.WriteLine();
            Console.WriteLine($"You have {account.Balance} Dkk. on your account");
            Console.WriteLine();

            while (true)
            {
                

                Console.WriteLine("Type 1 to Withdraw, type 2 to Deposit or type 3 to check balance");
                string login = Console.ReadLine();

                if (login == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Type how much you want to withdraw");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Type a reason why you withdraw");
                    string reason = Console.ReadLine();
                     

                    int intvalue = Convert.ToInt32(amount);

                    // Change 1 under this to what you want to withdra
                    account.MakeWithdrawal(intvalue, DateTime.Now, reason);
                    Console.WriteLine(account.Balance);
                }
                else if (login == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Type how much you want to deposit");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Type a reason why you deposit");
                    string reason = Console.ReadLine();



                    int intvalue = Convert.ToInt32(amount);
                    // Change 1 under this to what you want to deposit
                    account.MakeDeposit(intvalue, DateTime.Now, reason);
                    Console.WriteLine(account.Balance);
                }


                Console.WriteLine(account.GetAccountHistory());

            }
        }
    }

}
