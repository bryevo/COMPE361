using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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

        public void RhymeWord(string rhyme)
        {
            foreach (string line in lines)
            {
                if (line.EndsWith(rhyme))
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void ScrabbleWord(string scrabble)
        {
            Console.WriteLine("Scrabbling Word...");
            char[] letters = scrabble.ToCharArray();
            for (int k = 0; k < lines.Length; k++)
            {
                string line = lines[k];
                if (scrabble.Length >= line.Length)
                {
                    List<char> scrab = new List<char>();
                    for (int i = 0; i < line.Length; i++)
                    {
                        for (int j = 0; j < scrabble.Length; j++)
                        {
                            if (scrabble[j].Equals(lines[k][i]))
                            {
                                scrab.Add(lines[k][i]);
//                                Console.WriteLine(lines[k][i]);
                                break;
                            }
                        }
                    }
                        DisplaySet(scrab);
                }
            }
        }

        public void DisplaySet(List<char> set)
        {
            if (set.Count >= 3 && set.Count <= 7)
            {
                Console.Write("{");
                    foreach (char i in set)
                    {
//                        for (int j = 0; j < lines.Length; j++)
//                        {
//                            string line = lines[j];   
//                            if (line.Equals(i.ToString()))
                        i.ToString();
                            Console.Write("{0}", i);
//                    }
                }
                Console.WriteLine("}");
            }
        }

        private void Refractor(List<char> set)
        {
            if (set.Count >= 3 && set.Count <= 7)
            {
                string result = set.ToString();
                foreach (string line in lines)
                {
                    for (int i = 0; i < set.Count; i++)
                    {
                        if (line.Equals(result))
                        {
                            Console.WriteLine(line);
                        }

                    }
                }
            }
        }
    }
}