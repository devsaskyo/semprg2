using System;

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
