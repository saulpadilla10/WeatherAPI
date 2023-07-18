using System;
using Newtonsoft.Json.Linq;

namespace WeatherAPI
{
	public class Map
	{
		public static double GetTemp(string weatherToday)
		{
			var client = new HttpClient();

			var response = client.GetStringAsync(weatherToday).Result;

			var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            var name = JObject.Parse(response)["name"].ToString();

			Console.WriteLine(name);
			return temp;
		} 
	}
}

