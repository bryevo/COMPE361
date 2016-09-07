using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter temperature in Fahrenheit: ");
            double originalFar = double.Parse(Console.ReadLine());  //User Input for Fahrenheit
        
            double endCel = ConvertFar(originalFar);                //variable set for conversion Fahrenheit
            Console.WriteLine("Converting {0:F1} Fahrenheit to Celsius: {1:F1} Celsius.", originalFar, endCel);

            double endFar = ConvertCel(endCel);                     //variable set for conversion Celsius
            Console.WriteLine("Converting {0:F1} Celsius to Fahrenheight: {1:F1} Fahrenheight.", endCel, endFar);
        }

        public static double ConvertFar(double temp) { //Method to convert Fahrenheit to Celsius
            double result = ((temp - 32) / 9) * 5;
            return result;
        }
        public static double ConvertCel(double temp) { //Method to convert Celsius to Fahrenheit
            double result = ((temp * 9) / 5) + 32;
            return result;
        }
    }
}
