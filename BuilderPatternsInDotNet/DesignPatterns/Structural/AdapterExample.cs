namespace BuilderPatternsInDotNet.DesignPatterns.Structural;

public interface IWeatherService
{
    int GetTemperatureCelsius(string city);
}

public sealed class LegacyWeatherClient
{
    public int TemperatureInFahrenheit(string city) => 68;
}

public sealed class WeatherAdapter(LegacyWeatherClient client) : IWeatherService
{
    public int GetTemperatureCelsius(string city)
        => (int)((client.TemperatureInFahrenheit(city) - 32) * 5 / 9.0);
}
