using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.models
{
    public class Response
    {
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Wind wind { get; set; }
        public int visibility { get; set; }
        public int dt { get; set; }
    }
}
