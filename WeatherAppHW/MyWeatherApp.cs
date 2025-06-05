namespace WeatherAppHW;

public class MyWeatherApp : IMyWeatherApp
{
    public MyWeatherApp(string cityName, string weatherInfo, double temp)
    {
        City = cityName;
        WeatherInfo = weatherInfo;
        Temperature = temp;
    }
    public string City { get; set; }
    public string WeatherInfo { get; set; }
    
    public double Temperature { get; set; }
    
    public void PrintWeather()
    {
        Console.WriteLine($"CITY: {City}, WeatherInfo: {WeatherInfo}, Temperature: {Temperature - 273.15} Celsius");
    }
    
}