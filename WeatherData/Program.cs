using System;
using System.Threading;
using System.Threading.Tasks;
using WeatherStationWeatherStation;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WeatherStation");

            WeatherData weatherData = new WeatherData();

            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            CurrentConditions currentConditions = new CurrentConditions(weatherData);

            while (true)
            {
                weatherData.MeasurementsChanged();
                Thread.Sleep(1000);
            }
        }
    }
}
