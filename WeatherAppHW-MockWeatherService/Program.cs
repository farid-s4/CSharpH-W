using System.Net;
using System.Text.Json;
using WeatherAppHW;


Console.WriteLine("Write city name: ");
string? cityName = Console.ReadLine();

try
{
    string json = File.ReadAllText("C:\\Users\\palm1\\RiderProjects\\CSharpH-W\\WeatherAppHW-MockWeatherService\\app.mocket.data.json");
    var weatherList = JsonSerializer.Deserialize<List<MyWeatherApp>>(json);
    bool flag = false;
    foreach (var item in weatherList)
    {
        if (item.City == cityName)
        {
            item.PrintWeather();
            flag = true;
        }
    }

    if (!flag)
    {
        Console.WriteLine("Not found");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}







