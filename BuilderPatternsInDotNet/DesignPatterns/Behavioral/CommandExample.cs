namespace BuilderPatternsInDotNet.DesignPatterns.Behavioral;

public interface ICommand
{
    Task ExecuteAsync();
}

public sealed class CreateOrderCommand(string orderId) : ICommand
{
    public Task ExecuteAsync()
    {
        Console.WriteLine($"Created order {orderId}");
        return Task.CompletedTask;
    }
}
