using ObserverPattern.Interface;
using System.Collections.Generic;
using System;
namespace ObserverPattern
{
    public class WeatherData : ISbuject
    {
        private List<IObserver> observers;
        private float temperature;  //溫度
        private float humidity;     //
        private float pressure;     

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void nodifyObserver()
        {
            foreach(IObserver o in observers){
                o.upadte(temperature,humidity,pressure);
            }
        }
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Clear();
        }

        public void measurementsChanged()
        {
            nodifyObserver();
        }
        public void setMeasurements(float temperature,float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
        
    }
}