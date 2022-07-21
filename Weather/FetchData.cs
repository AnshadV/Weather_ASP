using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.models;

namespace Weather
{
    public class FetchData
    {
        private const string URL = "http://api.openweathermap.org/data/2.5/";
        private const string APIKEY = "&appid=199fefc6e88c9173d5f50323d8592652";


        public WeatherResponse weatherResponse = new WeatherResponse();

        public async Task<WeatherResponse> GetApiResponse(string userInput)
        {
            string weatherForCity = $"weather?q=+{userInput}";
            string path = URL + weatherForCity + APIKEY;
            try
            {
                weatherResponse = await ConnectToClient(path);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return weatherResponse;
        }

        private async Task<WeatherResponse> ConnectToClient(string path)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(path))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var response = await content.ReadAsStringAsync();
                            if(response.Contains("404").Equals(true))
                            {
                                throw new Exception("No data found");
                            }
                            else
                            {
                                weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return weatherResponse;
        }
    }
}
