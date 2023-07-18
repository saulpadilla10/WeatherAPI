using System;
using Newtonsoft.Json.Linq;
using System.IO;


namespace WeatherAPI
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Enter zipcode:");
            string zip = Console.ReadLine();

            var weatherToday = $"http://api.openweathermap.org/data/2.5/weather?zip={zip}&units=imperial&appid={APIKey}";


            Console.WriteLine($"Current temp: {Map.GetTemp(weatherToday)}F");



        }

    }





}



