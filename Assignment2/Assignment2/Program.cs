using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("1. All Words\n2. Rhyming words\n3. Scrabble words\n4. Morph words\n5. Quit Program\nYour choice:");
            int input = int.Parse(Console.ReadLine());
            if (input == 1){
                Words word = new Words();
                word.PrintAll();
            }
            if (input == 5) {
                Quit(input);
            }
        }

        public static int Quit(int i) {
            Console.WriteLine("Done");
            return 0;
        }
    }
}
