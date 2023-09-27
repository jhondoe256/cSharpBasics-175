namespace _10_Iterfaces_WorkingWithDI.Currency
{
    public class Transaction
    {
        //* Globally Scoped, this variable can be used thoughout this class
        private readonly ICurrency _currency;

        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        public DateTimeOffset DateOfTransaction { get; set; }

        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }

        public string GetTransactionType() => _currency.Name;
    }
}