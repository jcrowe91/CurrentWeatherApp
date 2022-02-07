using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace CurrentWeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var openWeather = "http://api.openweathermap.org/data/2.5/weather?lat=33.5207&lon=-86.8025&units=imperial&appid=e75bacb12de59da54c5f71dd08a02b3a";
            var weatherSite = new HttpClient();
            var siteResponse = weatherSite.GetStringAsync(openWeather).Result;
            var currentWeather = JObject.Parse(siteResponse).GetValue("main");

            Console.WriteLine("The current weather stats for Birmingham Alabama are:");
            foreach (var item in currentWeather)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine();



        }
    }
}
