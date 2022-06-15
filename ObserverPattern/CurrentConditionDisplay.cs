using System;
using ObserverPattern.Interface;
namespace ObserverPattern
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISbuject weatherData;
        public CurrentConditionDisplay(ISbuject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current conditions : "+temperature+
            "F degrees and "+humidity+"% humidity");
        }

        public void upadte(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity =humidity;
            display();            
        }
    }
}