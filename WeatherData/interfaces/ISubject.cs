using System.Collections.Generic;

namespace WeatherStation.interfaces
{
    public interface ISubject
    {
        void RegisterObject(IObserver observer);
        void RemoveObject(IObserver observer);
        void NotifyObservers(List<IObserver> observers);
    }
}
