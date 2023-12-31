namespace _10_Iterfaces_WorkingWithDI.Currency
{
    public class Penny : ICurrency
    {
        public string Name => "Penny";

        public decimal Value => .01M;

    }

    public class Dime : ICurrency
    {
        public string Name => "Dime";

        public decimal Value => .10m;
    }

    public class Dollar : ICurrency
    {
        public string Name => "Dollar";

        public decimal Value => 1.00M;

    }

    public class ElectronicPayment : ICurrency
    {
        public string Name => "Electronic Payment";

        public decimal Value {get;}

        public ElectronicPayment(decimal value)
        {
            Value = value;
        }
    }
}