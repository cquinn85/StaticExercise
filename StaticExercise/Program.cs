using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var cel = TempConverter.FahrenheitToCelsius(98);
            Console.WriteLine($"{cel}");

            var Fah = TempConverter.CelsiusToFahrenheit(86);
            Console.WriteLine($"{Fah}");
        }
    }
}
