using System;
using System.IO;

namespace Assignment2
{
    public class Words
    {
        private string[] lines = File.ReadAllLines(@"..\..\WordList.txt");

        public void PrintAll()
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public void RhymeWord()
        {
            Console.WriteLine("Let's see your freestyle! Pick a rhyme scheme: ");
            string rhyme = Console.ReadLine();
            foreach (string line in lines)
            {
                if (line.EndsWith(rhyme))
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void ScrabbleWord()
        {
            Console.WriteLine("You don't know how to rap? Don't worry, I'll search a word that your looking for: ");
            string scrabble = Console.ReadLine();
            char[] destination = scrabble.ToCharArray(3,scrabble.Length-3);
//            for (int i = 0; i < destination.Length; i++)
//            {
//                // Get character from array.
//                char letter = destination[i];
//                // Display each letter.
//                Console.WriteLine(letter);
//            }
             Console.WriteLine(destination);
            foreach (string line in lines)
            {

//                Console.WriteLine(line);
            }
        }
    }
}