using System;
using WeatherStation;
using WeatherStation.interfaces;

namespace WeatherStationWeatherStation
{
    public class CurrentConditions : IDisplayElement, IObserver
    {
        private decimal Humidity { get; set; }
        public CurrentConditions(WeatherData weatherData)
        {
            weatherData.RegisterObject(this);
        }

        public void Display()
        {
            Console.WriteLine($"CurrentConditions ===== Initial");

            Console.WriteLine($"Humidity: {Humidity}");

            Console.WriteLine($"CurrentConditions ===== Final");
        }

        public void update(IWeatherData weatherData)
        {
            Humidity = weatherData.GetHumidity();
            Display();

        }
    }
}
