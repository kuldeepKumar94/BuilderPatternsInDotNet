namespace BuilderPatternsInDotNet.DesignPatterns;

public sealed record PatternDescription(
    string Category,
    string Name,
    string Description,
    string Example,
    string LearningNote);

public sealed class PatternCatalog
{
    public IReadOnlyList<PatternDescription> Patterns { get; } =
    [
        new("Creational", "Builder", "Construct a complex object step by step.", "new ProductBuilder(name).WithFeatures(items).Build()", "The builder keeps construction readable and lets callers choose only the options they need."),
        new("Creational", "Factory", "Create objects without exposing the concrete type.", "INotification notification = NotificationFactory.Create(type)", "The caller depends on an abstraction while creation rules stay in one place."),
        new("Structural", "Adapter", "Make an incompatible API work with the interface your code expects.", "var service = new LegacyAdapter(legacyClient)", "Adapters are useful at integration boundaries and keep legacy details out of your domain."),
        new("Structural", "Decorator", "Add behavior by wrapping an existing object.", "new LoggingRepository(new SqlRepository())", "Decorators compose cross-cutting behavior such as logging, caching, or authorization."),
        new("Behavioral", "Strategy", "Select an algorithm at runtime through a common interface.", "checkout.SetDiscountStrategy(new StudentDiscount())", "Strategies remove large conditional blocks and make algorithms independently testable."),
        new("Behavioral", "Observer", "Notify multiple subscribers when state changes.", "order.Completed += SendConfirmation", "Events are a .NET-friendly observer implementation, but subscribers should be managed carefully."),
        new("Behavioral", "Command", "Represent an action as an object.", "sender.Send(new CreateOrderCommand(order))", "Commands support queues, retries, logging, and undo workflows."),
        new("Data access", "Repository", "Encapsulate persistence operations behind a domain-focused interface.", "await orders.GetByIdAsync(id)", "Use repositories deliberately; do not hide useful database capabilities behind needless abstractions.")
    ];
}
