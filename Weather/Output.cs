using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.models;

namespace Weather
{
    public class Output
    {
        public static string[] PrintWeather(WeatherResponse weatherResponse)
        {
            string[] data;
            if (!weatherResponse.Equals(null))
            {
                data = new string[] {"********************************","* City: " + weatherResponse.name, "* Temperature: "+weatherResponse.main.temp, "* Highest temperature: " +weatherResponse.main.temp_max,"* Lowest temperatur: "+ weatherResponse.main.temp_min,
                "* Feels like: " + weatherResponse.main.feels_like,"* Humidity: "+ weatherResponse.main.humidity,"* Pressure: "+ weatherResponse.main.pressure,"* Windspeed: "+weatherResponse.wind.speed,"* Deg: "+ weatherResponse.wind.deg,
                "* Condition: "+ weatherResponse.weather[0].main,"* Description: " +weatherResponse.weather[0].description,"********************************"};

            }
            else
            {
                throw new Exception("PrintWeatherCondition cant be empty");
            }
            return data;
        }
    }
}
