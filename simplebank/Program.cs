using System;
using System.Collections.Generic;

public class Transaction
{
    public DateTime Date { get; }
    public string Description { get; }
    public decimal Amount { get; }

    public Transaction(string description, decimal amount)
    {
        Date = DateTime.Now;
        Description = description;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Description}: {Amount:C}";
    }
}

public class BankAccount
{
    private static int accountNumberSeed = 1000;
    public string Owner { get; }
    public string AccountNumber { get; }
    private decimal balance;
    public List<Transaction> Transactions { get; }

    public BankAccount(string owner, decimal initialDeposit)
    {
        Owner = owner;
        balance = initialDeposit;
        AccountNumber = accountNumberSeed.ToString();
        accountNumberSeed++;
        Transactions = new List<Transaction>();
        Transactions.Add(new Transaction("Initial Deposit", initialDeposit));
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit must be a positive amount.");
            return;
        }

        balance += amount;
        Transactions.Add(new Transaction("Deposit", amount));
        Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal must be a positive amount.");
            return;
        }

        if (balance < amount)
        {
            Console.WriteLine("Insufficient funds for this withdrawal.");
            return;
        }

        balance -= amount;
        Transactions.Add(new Transaction("Withdrawal", -amount));
        Console.WriteLine($"Withdrew {amount:C}. New balance: {balance:C}");
    }

    public string GetStatement()
    {
        var statement = $"Account Number: {AccountNumber}\nOwner: {Owner}\nBalance: {balance:C}\n\nTransactions:\n";
        foreach (var transaction in Transactions)
        {
            statement += transaction.ToString() + "\n";
        }
        return statement;
    }
}

public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount("Petr Novak", 1000m);
        account.Deposit(500m);
        account.Withdraw(200m);
        account.Withdraw(1000m);
        Console.WriteLine(account.GetStatement());
    }
}
