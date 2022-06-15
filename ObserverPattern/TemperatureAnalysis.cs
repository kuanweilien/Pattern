using System;
using System.Collections.Generic;
using ObserverPattern.Interface;
namespace ObserverPattern
{
    public class TemperatureAnalysis : IObserver, IDisplayElement
    {
        private List<float> temps;
        private float avg;
        private float max;
        private float min;
        private ISbuject weatherData;
        public TemperatureAnalysis(ISbuject weatherData)
        {
            temps = new List<float>();
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("AVG/MAX/MIN = "+avg.ToString()+"/"+max.ToString()+"/"+min.ToString());
        }

        public void upadte(float temp, float humidity, float pressure)
        {
            temps.Add(temp);
            avg = 0;
            max = -1;
            min = -1;
            foreach(float t in temps){
                avg += t;
                max =max == -1 ? t:(t>max?t:max);
                min =min == -1 ? t:(t<min?t:min);
            }
            avg = avg / temps.Count;
            display();
        }
    }
}