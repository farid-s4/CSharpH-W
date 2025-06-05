namespace WeatherAppHW;

public class MyWeatherApp : IMyWeatherApp
{
    public string City { get; set; }
    public string WeatherInfo { get; set; }
    
    public double Temperature { get; set; }
    
    public void PrintWeather()
    {
        Console.WriteLine($"CITY: {City}, WeatherInfo: {WeatherInfo}, Temperature: {Temperature - 273.15} Celsius");
    }
    
}