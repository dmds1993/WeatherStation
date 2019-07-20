using WeatherStation.Model;

namespace WeatherStation.interfaces
{
    public interface IWeatherData
    {
        Temperature GetTemperature();
        decimal GetHumidity();
        decimal GetPressure();
        void MeasurementsChanged();
    }
}
