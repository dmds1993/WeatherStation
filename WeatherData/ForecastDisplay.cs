using WeatherStation.interfaces;

namespace WeatherStation
{
    public class ForecastDisplay : IDisplayElement, IObserver
    {

        public ForecastDisplay(WeatherData weatherData)
        {
            weatherData.RegisterObject(this);
        }

        public void Display()
        {
            
        }

        public void update(IWeatherData weatherData)
        {
            
        }
    }
}
