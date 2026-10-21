namespace BuilderPatternsInDotNet.DesignPatterns.Creational;

public sealed record Product(string Name, IReadOnlyList<string> Features)
{
    public override string ToString() => $"{Name}\n- {string.Join("\n- ", Features)}";
}

public sealed class ProductBuilder
{
    private readonly string name;
    private readonly List<string> features = [];

    public ProductBuilder(string name) => this.name = name;

    public ProductBuilder WithFeatures(IEnumerable<string> values)
    {
        features.AddRange(values);
        return this;
    }

    public Product Build() => new(name, features.AsReadOnly());
}
