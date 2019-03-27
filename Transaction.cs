using System;

namespace classes
{
    public class Transaction
    {
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }

        public string Notes { get; }
        public DateTime Date { get; }
        public decimal Amount { get; }
    }
}