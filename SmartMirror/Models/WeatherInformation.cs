using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.Models
{
    public class WeatherInformation
    {
        public string Location{ get; set; }

        public int Temperature { get; set; }

        public string TemperatureUOM { get; set; }

        public string WeatherType { get; set; }

        public string Sunrise { get; set; }

        public string Sunset { get; set; }
    }
}
