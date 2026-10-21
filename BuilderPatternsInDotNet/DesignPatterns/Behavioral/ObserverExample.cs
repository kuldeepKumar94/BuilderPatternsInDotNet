namespace BuilderPatternsInDotNet.DesignPatterns.Behavioral;

public sealed class Order
{
    public event EventHandler? Completed;

    public void Complete() => Completed?.Invoke(this, EventArgs.Empty);
}
