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
            int index = 1;
            foreach (string line in lines)
            {
                if (line.EndsWith(rhyme))
                {
                    Console.WriteLine("Rhyme Word: {0}: {1}", index, line);
                    index++;
                }
            }
        }

        public void ScrabbleWord(string scrabble)
        {
            Console.WriteLine("Scrabbling Word...");
            List<string> finalList = new List<string>();
            for (int k = 0; k < lines.Length; k++)
            {
                List<char> words = new List<char>();
                string line = lines[k];
                if (scrabble.Length >= line.Length)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        for (int j = 0; j < scrabble.Length; j++)
                        {
                            if (scrabble[j].Equals(lines[k][i]))
                            {
                                words.Add(lines[k][i]);
                                break;
                            }
                        }
                    }
                }
                List<char> finalChar = Refractor(words, scrabble);
                finalList.Add(AddWord(finalChar, scrabble));
            }
            int index = 1;
            foreach (string item in finalList.Distinct().ToList())
            {
                if (item != "")
                {
                    Console.WriteLine("Scrabble Word {0}: {1}", index, item);
                }
                index++;
            }
        }

        public List<char> Refractor(List<char> set, string words)
        {
            List<char> temp = new List<char>(set);
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < temp.Count; j++)
                {
                    if (words[i].Equals(temp[j]))
                    {
                        temp.Remove(temp[j]);
                        break;
                    }
                }
            }
            if (temp.Count == 0)
            {
                temp.Clear();
                return set;
            }
            if (temp.Count > 0)
            {
                temp.Clear();
            }
            return temp;
        }

        public string AddWord(List<char> set, string input)
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
                    }
                }
            }
            string result = string.Join("", refer.ToArray());
            return result;
        }

        public void MorphWord(string morph)
        {
            int index = 1;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Its Morphin' time!");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                for (int j = 0; j < morph.Length; j++)
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        string temp = morph.Replace(morph[j], alphabet[k]);
                        if (string.Equals(line, temp, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Morph Word {0}: {1}", index, line);
                            index++;
                        }
                    }
                }
            }
        }
    }
}