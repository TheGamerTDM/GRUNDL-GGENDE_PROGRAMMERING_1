using System;
using System.Collections.Generic;
using System.Text;

namespace BankLUL
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        // This helps us with making a histort of your transactions so we get date, amount and a note :-)
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
