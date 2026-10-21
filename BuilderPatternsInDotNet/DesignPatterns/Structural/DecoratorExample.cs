namespace BuilderPatternsInDotNet.DesignPatterns.Structural;

public interface IOrderStore
{
    Task SaveAsync(string orderId);
}

public sealed class LoggingOrderStore(IOrderStore inner) : IOrderStore
{
    public async Task SaveAsync(string orderId)
    {
        Console.WriteLine($"Saving {orderId}");
        await inner.SaveAsync(orderId);
    }
}
