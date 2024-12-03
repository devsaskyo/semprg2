using System;
using System.Collections.Generic;
using System.Transactions;

public class BankAccount
{
    private static int accountCounter = 1;

    public string Owner { get; }
    public int AccountNumber { get; }
    public decimal Balance { get; private set; }
    public List<Transaction> Transactions { get; }

    public decimal InterestRate { get; set; }
    public DateTime? NextAllowedTransactionDate { get; set; }

    public BankAccount(string owner, decimal initialDeposit)
    {
        Owner = owner;
        AccountNumber = accountCounter++;
        Balance = initialDeposit;
        Transactions = new List<Transaction>
        {
            new Transaction("Initial deposit", initialDeposit)
        };
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        Balance += amount;
        Transactions.Add(new Transaction("Deposit", amount));
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }

        if (Balance < amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance -= amount;
        Transactions.Add(new Transaction("Withdrawal", -amount));
    }

    public void Transfer(BankAccount targetAccount, decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Transfer amount must be positive.");
        }

        if (Balance < amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        this.Withdraw(amount);
        targetAccount.Deposit(amount);
        Transactions.Add(new Transaction($"Transfer to Account {targetAccount.AccountNumber}", -amount));
        targetAccount.Transactions.Add(new Transaction($"Transfer from Account {this.AccountNumber}", amount));
    }

    public string GetStatement()
    {
        string statement = $"Account Statement for {Owner} (Account Number: {AccountNumber})\n";
        foreach (var transaction in Transactions)
        {
            statement += transaction.ToString() + "\n";
        }
        return statement;
    }

    public void ApplyInterest()
    {
        if (InterestRate > 0)
        {
            decimal interest = Balance * InterestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Interest applied: {interest:C}");
        }
    }
}
