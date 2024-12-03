public class TermDepositAccount : BankAccount
{
    public DayOfWeek? AllowedDayOfWeek { get; }
    public int? AllowedDayOfMonth { get; }

    // Konstruktor pro týdenní fixaci
    public TermDepositAccount(string owner, decimal initialDeposit, DayOfWeek allowedDayOfWeek)
        : base(owner, initialDeposit)
    {
        AllowedDayOfWeek = allowedDayOfWeek;
    }

    // Konstruktor pro měsíční fixaci
    public TermDepositAccount(string owner, decimal initialDeposit, int allowedDayOfMonth)
        : base(owner, initialDeposit)
    {
        AllowedDayOfMonth = allowedDayOfMonth;
    }

    public new void Deposit(decimal amount)
    {
        CheckTransactionDate();
        base.Deposit(amount);
    }

    public new void Withdraw(decimal amount)
    {
        CheckTransactionDate();
        base.Withdraw(amount);
    }

    private void CheckTransactionDate()
    {
        DateTime now = DateTime.Now;

        if (AllowedDayOfWeek.HasValue && now.DayOfWeek != AllowedDayOfWeek.Value)
        {
            throw new InvalidOperationException("Transactions are only allowed on the specified day of the week.");
        }

        if (AllowedDayOfMonth.HasValue && now.Day != AllowedDayOfMonth.Value)
        {
            throw new InvalidOperationException("Transactions are only allowed on the specified day of the month.");
        }
    }
}
