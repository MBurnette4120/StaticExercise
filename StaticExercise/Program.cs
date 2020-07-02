using System;

namespace StaticExercise
{
    public class Program     

    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Fahrenheit temperature:");
            double newTempC = double.Parse(Console.ReadLine());
            double theTemp = TempConverter.FahrenheitToCelsius(newTempC);            
            Console.WriteLine($"{theTemp} degrees Celsius");


            Console.WriteLine("Enter the Celsius temperature:");
            double newTempF = double.Parse(Console.ReadLine());
            double newTemp = TempConverter.CelsiusToFahrenheit(newTempF);
            Console.WriteLine($"{newTemp} degrees Fahrenheit");


        }
    }

    


}

