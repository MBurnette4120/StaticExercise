using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
       public static double FahrenheitToCelsius(double tempF)
        {
            double tempCelsius = (tempF - 32) * 5 / 9;
                return tempCelsius;
            //(32°F − 32) × 5/9 = 0°C


        }

        public static double CelsiusToFahrenheit(double tempC)
        {
            double tempFahrenheit = (tempC *  9/5) + 32;
            return tempFahrenheit;

            //(0°C × 9 / 5) +32 = 32°F

        }
    }

    







}
