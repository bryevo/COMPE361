using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment2
{
    public class Words
    {
        public static string[] lines = File.ReadAllLines(@"..\..\WordList.txt");

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
            List<string> finalList = new List<string>();
            for (int k = 0; k < lines.Length; k++)
            {
                List<char> word = new List<char>();
                string line = lines[k];
                if (scrabble.Length >= line.Length)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        for (int j = 0; j < scrabble.Length; j++)
                        {
                            if (scrabble[j].Equals(lines[k][i]))
                            {
                                word.Add(lines[k][i]);
                                break;
                            }
                        }
                    }
                }
                finalList.Add(AddWord(word));
            }
            foreach (string item in finalList.Distinct().ToList())
            {
                Console.WriteLine(item);
            }
        }

        public string AddWord(List<char> set)
        {
            List<string> refer = new List<string>();
            if (set.Count >= 3 && set.Count <= 7)
            {
                char[] list = set.ToArray();
                string s = new string(list);
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (line.Equals(s))
                    {
                        refer.Add(line);
//                        string result = string.Join("", refer.ToArray());
//                        Console.WriteLine(result);
                    }
                }
            }
            string result = string.Join("", refer.ToArray());
            return result;
        }
    }
}