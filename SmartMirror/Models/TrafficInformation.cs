using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.Models
{
    public class TrafficInformation
    {
        public DateTime Now { get; set; }

        public string Destination { get; set; }

        public double Distance { get; set; }

        public string DistanceUOM { get; set; }

        public int Minutes { get; set; }

        public DateTime TimeOfArrival { get; set; }
    }
}
