using System.Net;
using System.Text.Json;
using WeatherAppHW;

static string? LoadApiKey(string filePath)
{
    if (!File.Exists(filePath))
    {
        return null;
    }
    
    try
    {
        string json = File.ReadAllText(filePath);
        using JsonDocument doc = JsonDocument.Parse(json);
        JsonElement root = doc.RootElement;

        return root.GetProperty("apikey").GetString();
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}

Console.WriteLine("Write city name: ");
string? cityName = Console.ReadLine();

string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={LoadApiKey("C:\\Users\\palm1\\RiderProjects\\CSharpH-W\\WeatherAppHW\\appsetting.development.json")}"; // microsoft configure json

HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

try
{
    string response;
    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
    {
        response = streamReader.ReadToEnd();
    }

    using JsonDocument doc = JsonDocument.Parse(response);
    JsonElement root = doc.RootElement;

    string? city = root.GetProperty("name").GetString();
    string? weather = root.GetProperty("weather")[0].GetProperty("description").GetString();
    double temp = root.GetProperty("main").GetProperty("temp").GetDouble();
    
    MyWeatherApp myWeather = new MyWeatherApp(city, weather, temp);
    
    myWeather.PrintWeather();
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}







