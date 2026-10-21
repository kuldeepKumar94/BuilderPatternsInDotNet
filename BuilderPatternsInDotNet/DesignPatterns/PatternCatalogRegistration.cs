using BuilderPatternsInDotNet.DesignPatterns;

namespace Microsoft.Extensions.DependencyInjection;

public static class PatternCatalogRegistration
{
    public static IServiceCollection AddPatternLearning(this IServiceCollection services)
        => services.AddSingleton<PatternCatalog>();
}
