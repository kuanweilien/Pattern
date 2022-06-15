using System;
using System.Collections.Generic;
using ObserverPattern.Interface;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay current = new CurrentConditionDisplay(weatherData);
            TemperatureAnalysis analysis = new TemperatureAnalysis(weatherData);
            weatherData.setMeasurements(80,65,30.4f);
            weatherData.setMeasurements(82,70,29.2f);
            weatherData.setMeasurements(78,90,29.2f);
        }
    }
}
