namespace BuilderPatternsInDotNet.DesignPatterns.Behavioral;

public interface IDiscountStrategy
{
    decimal Apply(decimal total);
}

public sealed class StudentDiscount : IDiscountStrategy
{
    public decimal Apply(decimal total) => total * 0.90m;
}

public sealed class Checkout(IDiscountStrategy discount)
{
    public decimal TotalAfterDiscount(decimal total) => discount.Apply(total);
}
