namespace BuilderPatternsInDotNet.DesignPatterns.Creational;

public interface INotification
{
    string Send(string recipient, string message);
}

public sealed class EmailNotification : INotification
{
    public string Send(string recipient, string message) => $"Email to {recipient}: {message}";
}

public static class NotificationFactory
{
    public static INotification Create(string channel) => channel.ToLowerInvariant() switch
    {
        "email" => new EmailNotification(),
        _ => throw new ArgumentException($"Unsupported channel: {channel}", nameof(channel))
    };
}
