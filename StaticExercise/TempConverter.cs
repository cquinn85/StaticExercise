using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        /*static classes can only contain static members

        The class should have at least 2 methods, 
        one called FahrenheitToCelsius that will require a parameter 
        and return a double, 
        the other CelsiusToFahrenheit which will also require 
        a parameter and return a double. 
        Fill out these methods and call them in your Program.cs file. 
        Make sure they’re accurate! */

        public static double FahrenheitToCelsius(double fahrenheight)
        {
            //what is the goal here?
            return (fahrenheight - 32) / 1.8;
            
        }
         public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }

    
}
