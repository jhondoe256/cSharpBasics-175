using _10_Iterfaces_WorkingWithDI.Currency;
namespace _10_wDITests;

public class TransactionTests
{
    private decimal _debt;

    public TransactionTests()
    {
        _debt = 9000.01m;
    }

    //* Helper method to pay our debt
    private void PayDebt(ICurrency payment)
    {
        _debt -= payment.Value;
        System.Console.WriteLine($"You have paid {payment.Value:c} towards your debt.");
    }

    [Fact]
    public void PayDebtTest()
    {
        //* Arrange
        PayDebt(new Dollar());
        PayDebt(new ElectronicPayment(315.52m));

        //* Action
        decimal expectedAmt = 9000.01m - 316.52m; 
        
        System.Console.WriteLine($"expected amt: {expectedAmt:c}"); 
        System.Console.WriteLine($"expected _debt: {_debt:c}"); 

        //* Assertion
        Assert.Equal(expectedAmt,_debt);
    }

    [Fact]
    public void Injecting_Into_Constructors()
    {
        var dollar = new Dollar();
        var electronicPayment = new ElectronicPayment(243.71M);

        //* Making a Transaction obj now, 
        Transaction firstTransaction = new Transaction(dollar);
        Transaction secondTransaction = new Transaction(electronicPayment);

        //* The Transaction object DOESN'T CARE what type is passed in 
        //* All that it cares about is the ICurrency interface!!!!

        System.Console.WriteLine(firstTransaction.GetTransactionType());
        System.Console.WriteLine(secondTransaction.GetTransactionType());

        //* Assert 
        Assert.Equal("Dollar", firstTransaction.GetTransactionType());
        Assert.Equal("Electronic Payment", secondTransaction.GetTransactionType());
    }

    [Fact]
    public void MoreExamples()
    {
        //* Lets have multiple Transactions

        var list = new List<Transaction>
        {
            new Transaction(new Dollar()),
            new Transaction(new ElectronicPayment(231.95m)),
            new Transaction(new Dime()),
            new Transaction(new Dollar()),
            new Transaction(new Penny()),
        };

        foreach(Transaction transaction in list)
        {
            var type = transaction.GetTransactionType();
            var amt = transaction.GetTransactionAmount();

            System.Console.WriteLine($"{type} {amt:c} {transaction.DateOfTransaction}");
        }
    }
}