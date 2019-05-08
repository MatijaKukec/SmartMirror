using SmartMirror.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror
{
    public class Main
    {
        private UserInformation _userInformation;
        private WeatherInformation _weatherInformation;
        private TrafficInformation _trafficInformation;
        public void Run()
        {
            _userInformation = GetInformation();
            _weatherInformation = GetOfflineWeatherData();
            _trafficInformation = GetOfflineTrafficData();


           GenerateOutput();
           Console.ReadKey();

        }

        private UserInformation GetInformation()
        {
            Console.WriteLine("Upišite svoje ime:");
            var name = Console.ReadLine();

            Console.WriteLine("Upišite svoju adresu:");
            var address = Console.ReadLine();

            Console.WriteLine("Upišite poštanski broj svojeg grada:");
            var zipcode = Console.ReadLine();

            Console.WriteLine("Upišite svoj grad:");
            var town = Console.ReadLine();

            Console.WriteLine("Upišite svoju adresa radnog mjesta:");
            var workAddress = Console.ReadLine();

            Console.ReadLine();

            var result = new UserInformation
            {
                Name = name,
                Address = address,
                Zipcode = zipcode,
                Town = town,
                WorkAddress = workAddress
            };
            return result;
        }

        private WeatherInformation GetOfflineWeatherData()
        {
            return new WeatherInformation
            {

                Location = "London",
                Sunrise = "6:04",
                Sunset = "18:36",
                Temperature = 17,
                WeatherType = "sunčano",
                TemperatureUOM = "Celsius",

            };
        }

        private TrafficInformation GetOfflineTrafficData()
        {
            return new TrafficInformation
            {
                Minutes = 35,
                Distance = 27,
                DistanceUOM = "Kilometers",
                Destination = "2 St Margaret St, London"
            };
        }

        private void GenerateOutput()
        {
            Console.WriteLine($"Dob{GetTimeOfDay()} {_userInformation.Name}");
            Console.WriteLine($"Trenutno vrijeme je {DateTime.Now.ToShortTimeString()} vani je {_weatherInformation.WeatherType}.");
            Console.WriteLine($"Trenutna temperatura je {_weatherInformation.Temperature} stupnjeva {_weatherInformation.TemperatureUOM}.");
            Console.WriteLine($"Sunce je izašlo u {_weatherInformation.Sunrise} i zalazi otprilike u {_weatherInformation.Sunset}.");
            Console.WriteLine($"Vaše putovanje do mjesta posla će trajati {_trafficInformation.Minutes} minuta. " +
                $"Ako krenete sad, trebali bi stići otprilike u {_trafficInformation.TimeOfArrival.ToShortTimeString()}.");
            Console.WriteLine("\nŽelim Vam siguran i produktivan dan!");
        }



        private string GetTimeOfDay()
        {
            var currentTime = DateTime.Now.TimeOfDay.Hours;


            if (currentTime >= 0 && currentTime <= 11)
                return "ro jutro";
            else if (currentTime <= 13)
                return "ar dan";
            else if (currentTime <= 18)
                return "ar dan";
            else if (currentTime <= 22)
                return "ra večer";
            else
                return "ra večer";
        }

    }
}
