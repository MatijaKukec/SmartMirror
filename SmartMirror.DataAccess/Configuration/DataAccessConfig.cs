using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.DataAccess.Configuration
{
    public static class DataAccessConfig
    {
        public static string OpenWeatherMapId
        {
            get
            {
                return "01f1ca0c9c1b59dbfbdaf2e8da4d47de";
            }
        }
        public static string OpenWeatherMapUrl
        {
            get
            {
                return "http://api.openweathermap.org/data/2.5";
            }
        }

        public static string TrafficApiUrl
        {
            get
            {
                return "https://maps.googleapis.com/maps/api/distancematrix/json";
            }
        }

        public static string TrafficApiId
        {
            get
            {
                return "AIzaSyBGoN7HTIWBLk6N9CqEqvJsV_KGFmwt8tw";
            }
        }
    }
}
