using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace PA4
{
    /// <summary>
    /// The Bulk of the Assignment.  Provides methods for variables.  Class uses default constructor.
    /// </summary>
    public class Words
    {
        //Initialized the dictionary text into a string array[].
        public string[] Lines = Properties.Resources.WordList.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

        /// <summary>
        /// Prints all the content inside the WordList.txt
        /// </summary>
        public string[] PrintAll()
        {
            // Uses foreach to iterate through each index/line of the dictionary and print out that line.
            return Lines;
        }
        /// <summary>
        /// Checks to see if word rhymes/ends in the same user input string
        /// </summary>
        /// <param name="rhyme"></param>
        public List<string> RhymeWord(string rhyme)
        {
            List<string> rhymeList = new List<string>();
            //Iterates through each index/line of the dictionary to see if the string line ends with user input string rhyme and prints it out.
            foreach (string line in Lines)
            {
                if (line.EndsWith(rhyme) && !line.Equals(rhyme))
                {
                    rhymeList.Add(line);
                }
            }
            return rhymeList;
        }
        /// <summary>
        /// Checks user input to make up a word inside the dictionary
        /// </summary>
        /// <param name="scrabble"></param>
        public List<string> ScrabbleWord(string scrabble)
        {
            Console.WriteLine("Scrabbling Word...");
            List<string> finalList = new List<string>();
            //Initialize a new empty HashSet of generic string to store distinct strings
            //Iterates through the entire WordList file
            for (int k = 0; k < Lines.Length; k++)
            {
                List<char> words = new List<char>();
                //Intialize a  new empty List of generic char to store multiple letters for each line in WordList
                string line = Lines[k]; //line gets the index or location of where you are in the WordsList
                //If your word length is greater or equal to the string line length, then that string line is valid as a scrabble word
                //e.g (your input: noqmopu) (string line: moon) noqmopu is greater than moon; returns true and is a valid scrabble word
                if (scrabble.Length >= line.Length)
                {
                    //Iterates through the string line length (e.g. string "moon" length is 4)
                    for (int i = 0; i < line.Length; i++)
                    {
                        //Iterates through string user input length (e.g string "noqmopu" length is 7)
                        for (int j = 0; j < scrabble.Length; j++)
                        {
                            //if your the string index/letter is equal to the string line's index/letter then it returns true.
                            if (scrabble[j].Equals(line[i]))
                            {
                                words.Add(Lines[k][i]); //adds the letter to the List words.
                                break;
                                //and breaks out of the current loop j. Goes to next iteration of index for string line.
                            }
                            //End of user input iteration.
                        }
                        //End of iteration for line length.  List words should return an array of characters representing a string/word.
                    }
                }
                //Intialize a new List that refractors and checks for any duplicate letters that List word contains that scrabble does not contain and if it does removes that instance of List words.
                List<char> finalChar = RemoveLeftovers(words, scrabble);
                //Adds the refractored List finalChar to the finalList strings.
                finalList.Add(AddWord(finalChar));
            }
            //Iterates through each item in the finalList and prnts out the item string.
            return finalList.Distinct().ToList();
        }
        /// <summary>
        /// Checks for any duplicate letters that do not match with user input's letters and removes them
        /// </summary>
        /// <param name="set"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public List<char> RemoveLeftovers(List<char> set, string words)
        {
            List<char> temp = new List<char>(set); //Initalize a temporary List to get values in the List set.
            //Iterates through user input word length and temp length
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < temp.Count; j++)
                {
                    //Checks equal letters from user input and temporary.  If true it removes from the list.
                    //Checks that if there are left over words in temporary then temporary is not a valid scrabble word.
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
                return set; //Returns the original List <char> if there are no left over words in temp.
            }
            if (temp.Count > 0)
            {
                temp.Clear();
            }
            return temp; //Returns temp as invalid scrabble word if cannot check duplicate letters.
        }
        /// <summary>
        /// Double checks if the List set is equal to type string line
        /// Converts List set to a string and returns it.
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public string AddWord(List<char> set)
        {
            List<string> temp = new List<string>(); //Empty List to store strings
            if (set.Count >= 3 && set.Count <= 7)
            {
                char[] list = set.ToArray();
                string s = new string(list); //Convert List type char set to a type string
                for (int i = 0; i < Lines.Length; i++)
                {
                    string line = Lines[i];
                    if (line.Equals(s)) //Checks if it line equals the set
                    {
                        temp.Add(line); //Adds to the List string outside the loop.
                    }
                }
            }
            string result = string.Join("", temp.ToArray()); //Makes result as a readable string from refer.
            return result;
        }
        /// <summary>
        /// Checks for words in the dictionary if it is equal to the morphed word "temp"
        /// </summary>
        /// <param name="morph"></param>
        public string[] MorphWord(string morph)
        {
            HashSet<string> MorphSet = new HashSet<string>();
            string alphabet = "abcdefghijklmnopqrstuvwxyz"; //used for replacing the index of morph word
            for (int i = 0; i < Lines.Length; i++)
            {
                string line = Lines[i];
                for (int j = 0; j < morph.Length; j++)
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        //Replaces your input string index with the index of the alphabet
                        string temp = morph.Remove(j, 1);
                        temp = temp.Insert(j, alphabet[k].ToString());
                        // Checks if the from the WordList.txt equals temp and not equal to the user input morph word; prints results
                        if ((string.Equals(line, temp, StringComparison.OrdinalIgnoreCase)) && !line.Equals(morph))
                        //StringComparison.OrdinalIgnoreCase makes word case-insensitive
                        {
                            MorphSet.Add(line); //Adds to the Hashset to remove any duplicate strings
                        }
                    }
                }
            }
            string[] set = MorphSet.ToArray();
            return set;
        }
        /// <summary>
        /// MorphChain method creates a List of Chains that holds a Lists of string.
        /// dynamically creating a new List of strings for every unique morph word and building it
        /// on top of the previous List; adding it to our List of Chains to find the end chain word
        /// WARNING: Takes forever to compile long chains because it searches through all the lists of chains until it finds the end word.  
        /// These lists are dynamically added to the List of chains and has an expontential growth rate.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="max"></param>
        public List<string> MorphChain(string start, string end, int max)
        {
            if (!Lines.Contains(start) || !Lines.Contains(end) || start.Length != end.Length)
                return null;
            Console.WriteLine("Solution Chain");
            Words morphSet = new Words();
            List<List<string>> totalChains = new List<List<string>>().Distinct().ToList();      //List of string arrays
            List<string> setOne = new List<string>(morphSet.MorphWord(start));      //starting word {e.g told: {bold, cold, fold, gold...}
            List<string> wordsFound = new List<string>();
            List<string> foundMorph = new List<string>();
            for (int i = 0; i < setOne.Count; i++)
            {
                //temp list to stores the start word and the current indexed morph word
                List<string> temp = new List<string>();
                temp.Add(start);                            //add start word
                temp.Add(setOne[i]);                        //add that specific index word
                totalChains.Add(temp);		//totalChains gets e.g 0: {told, bold}, 1: {told, cold}, 2: {told, sold}...
                wordsFound.Add(setOne[i]);
            }
            int x = 0;

            //while x is less than the number of elements inside totalchains...
            while (x < totalChains.Count)
            {
                List<string> chain = totalChains[x]; //assign chain to that specfic x index
                if (chain.Count <= max) // while the number of elements in chain is less than the max length provided
                {
                    if (chain.Contains(end))
                    {
                        foundMorph = chain;
                        break;
                    }
                    if (foundMorph.Contains(end)) //if the end word/word we're looking for is inside chain
                    {
                        //found the morph list; gets that chain; breaks out of loop
                        break;
                    }
                    List<string> nextChain = new List<string>(morphSet.MorphWord(chain.Last())); //nextChain gets the morphed word of the last word in chain

                    //iterate through the morph word
                    for (int i = 0; i < nextChain.Count; i++)
                    {
                        if (!wordsFound.Contains(nextChain[i]))
                        {
                            //temp gets every element inside chain; copies all of its contents
                            List<string> temp = new List<string>();
                            foreach (string element in chain)
                            {
                                temp.Add(element);
                            }
                            temp.Add(nextChain[i]); //temps adds the last index of next chain
                            if (nextChain[i].Equals(end))
                            {
                                foundMorph = temp;
                                break;
                            }
                            totalChains.Add(temp); //total chains adds new list temp
                            wordsFound.Add(nextChain[i]);
                        }
                    }
                }
                else if (chain.Count >= max)
                    break;

                x++; //x will increment until it hits the max count in total chains
            }
            return foundMorph;
        }
    }
}