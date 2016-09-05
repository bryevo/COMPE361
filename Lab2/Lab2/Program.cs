using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 69;  //intialized variable set to integer
            Console.WriteLine("Age: {0} years old", age); //print variable age

            const int MAX_SCORE = 100;
            int score = 69;
            float percentage = (float) score/MAX_SCORE; //type casting using (float) before using operator
            Console.WriteLine("Percentage: {0} %", percentage);
            Console.ReadKey();
        }
    }
}
