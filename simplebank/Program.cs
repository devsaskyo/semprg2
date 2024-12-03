using System;
using System.Xml;

namespace ThisIsABankApparently
{
    class Program
    {
        static void Main()
        {
            BankAccount account1 = new BankAccount("Jan Novak", 1000m);
            account1.Deposit(500m);
            account1.Withdraw(200m);
            account1.ApplyInterest();
            Console.WriteLine(account1.GetStatement());

            TermDepositAccount termAccount = new TermDepositAccount("Petr Novak", 1000m, DayOfWeek.Monday);
            try
            {
                termAccount.Deposit(300m);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            BankAccount account2 = new BankAccount("David Briet", 500m);
            account1.Transfer(account2, 300m);
            Console.WriteLine(account1.GetStatement());
            Console.WriteLine(account2.GetStatement());
        }
    }
}
