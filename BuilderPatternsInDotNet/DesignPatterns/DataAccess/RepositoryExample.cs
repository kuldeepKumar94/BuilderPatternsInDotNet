namespace BuilderPatternsInDotNet.DesignPatterns.DataAccess;

public interface IOrderRepository
{
    Task<string?> GetByIdAsync(string id);
}

public sealed class InMemoryOrderRepository : IOrderRepository
{
    private readonly Dictionary<string, string> orders = new();

    public Task<string?> GetByIdAsync(string id)
        => Task.FromResult(orders.GetValueOrDefault(id));
}
