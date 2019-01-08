namespace CreateAndUseTypes.ConsumeTypes
{
    public class Money
    {
        public Money(decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount { get; set; }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }

        public static explicit operator double(Money money)
        {
            return (double)money.Amount;
        }
    }
}
