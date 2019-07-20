namespace WeatherStation.interfaces
{
    public interface IObserver
    {
        void update(IWeatherData weatherData);
    }
}
