using System;
using System.IO;

namespace Assignment2
{
    public class Words
    {
        public void PrintAll() {
            try {
                string[] lines = File.ReadAllLines(@"C:/Users/Brye/Desktop/COMPE361/Assignment2/Assignment2/WordList.txt");
                foreach (string line in lines) {
                    string dict = line + ",";
                }
            }
            catch (Exception e) {
                Console.WriteLine("The file could not be read.");
                Console.WriteLine(e.Message);
            }
        }
    }
}