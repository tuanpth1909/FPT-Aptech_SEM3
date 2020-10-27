using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Models
{
    public class OpenWeatherMapProxy
    {
        public static async Task<RootObject> GetWeatherAsync(double lon, double lat)
        {
            var http = new HttpClient();
            var reponsive = await http.GetAsync("http://apiogenweathermagorg/data/2.5/weather?lat=32.77&Ion=-96.79");
            var result = await reponsive.Content.ReadAsStringAsync();
            var serializer = DataContracJsonSerializer;
        }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
    }
}
