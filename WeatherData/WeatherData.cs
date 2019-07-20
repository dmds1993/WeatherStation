using System.Collections.Generic;
using WeatherStation.interfaces;
using WeatherStation.Model;

namespace WeatherStation
{
    public class WeatherData : ISubject, IWeatherData
    {
        private List<IObserver> observers;
        private decimal Min { get; set; }
        private decimal Max { get; set; }
        private decimal Average { get; set; }

        private decimal Humidity { get; set; }
        private decimal Pressure { get; set; }
        private decimal Temperature { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public decimal GetHumidity()
        {
            return Humidity;
        }

        public decimal GetPressure()
        {
            return Pressure;
        }

        public Temperature GetTemperature()
        {
            return new Temperature
            {
                Min = Min,
                Max = Max,
                Average = Average
            };
        }

        public void MeasurementsChanged()
        {
            Min += 1;
            Max += 2;
            Average += 5;
            Pressure += 31;
            Humidity += 13;
            Temperature += 3;

            NotifyObservers(observers);
        }

        public void NotifyObservers(List<IObserver> observers)
        {
            foreach(var obs in observers)
            {
                obs.update(this);
            }
        }

        public void RegisterObject(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObject(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
