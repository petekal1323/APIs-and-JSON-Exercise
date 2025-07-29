using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal static class OpenWeatherMapAPI
    {
        public static void GetuserTemp()
        {
            //open our appsettings file, and grab all the json text
            var appSettingsText = File.ReadAllText("appsettings.json");
            
            //parse the json text into object and get api key
            var apiKey = JObject.Parse(appSettingsText)["key"].ToString();
            
            Console.WriteLine("Enter ZIP:");
            var zip = Console.ReadLine();

            var url = $"http://api.openweathermap.org/data/2.5/weather?zip={zip}&appid={apiKey}&units=imperial";
            
            var client = new HttpClient();
            
            var response = client.GetStringAsync(url).Result;
            
            var weatherObject = JObject.Parse(response);
            
            Console.WriteLine($"Current Temp: {weatherObject["main"]["temp"]}\nFeels Like {weatherObject["main"]["feels_like"]}");
            
        }
    }
}
