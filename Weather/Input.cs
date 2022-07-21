using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.models;

namespace Weather
{
    public class Input
    {
        public static WeatherResponse weatherResponse;
        public static FetchData data = new FetchData();

        public static async Task<List<String>> InputString()
        {
            string input = string.Empty;
            List<string> apiResponse = new List<string>();
            Console.WriteLine("Enter city name: ");
            input = Console.ReadLine();
            if (input.Equals(string.Empty))
                return null;

            apiResponse = Output.PrintWeather(await data.GetApiResponse(input)).ToList();
          
            return apiResponse;
        }

    }
}
