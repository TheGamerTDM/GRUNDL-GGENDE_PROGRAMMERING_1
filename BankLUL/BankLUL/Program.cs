using System;

namespace BankLUL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make your account with name and how much money you want to start with e.g we start with 1000
            var account = new BankAccount("Name", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            
            // Change 1 under this to what you want to withdra
            account.MakeWithdrawal(1, DateTime.Now, "Reason");
            Console.WriteLine(account.Balance);

            // Change 1 under this to what you want to deposit
            account.MakeDeposit(1, DateTime.Now, "Reason");
            Console.WriteLine(account.Balance);


            Console.WriteLine(account.GetAccountHistory());

        }
    }

}
