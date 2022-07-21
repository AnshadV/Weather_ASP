using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.models
{
    public class WeatherResponse
    {
        public string cod { get; set; }
        public string name { get; set; }
        public List<Response> response { get; set; }
        public List<Weather> weather { get; set; }
        public Wind wind { get; set; }
        public Main main { get; set; }
        public Coord coord { get; set; }
    }
}
