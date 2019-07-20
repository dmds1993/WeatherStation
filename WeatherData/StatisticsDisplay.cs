using System;
using WeatherStation.interfaces;

namespace WeatherStation
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private decimal Min { get; set; }
        private decimal Average { get; set; }
        private decimal Max { get; set; }

        public StatisticsDisplay(WeatherData weatherData)
        {
            weatherData.RegisterObject(this);
        }

        public void Display()
        {
            Console.WriteLine($"StatisticsDisplay ===== Initial");
            Console.WriteLine($"Min: {Min}");

            Console.WriteLine($"Max: {Max}");

            Console.WriteLine($"Average: {Average}");

            Console.WriteLine($"StatisticsDisplay ===== Final");
        }

        public void update(IWeatherData weather)
        {
            var temperature = weather.GetTemperature();
            Min = temperature.Min;
            Max = temperature.Max;
            Average = temperature.Average;
            Display();
        }
    }
}
