using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment2
{
	/// <summary>
	/// The Bulk of the Assignment.  Provides methods for variables.  Class uses default constructor.
	/// </summary>
	public class Words
	{
		//Initialized the dictionary text into a string array[].
		public string[] Lines = File.ReadAllLines(@"../../WordsList.txt");

		/// <summary>
		/// Prints all the content inside the WordList.txt
		/// </summary>
		public void PrintAll()
		{

			// Uses foreach to iterate through each index/line of the dictionary and print out that line.
			foreach (string line in Lines)
			{
				Console.WriteLine(line);
			}
		}

		/// <summary>
		/// Checks to see if word rhymes/ends in the same user input string
		/// </summary>
		/// <param name="rhyme"></param>
		public void RhymeWord(string rhyme)
		{
			//index to keep track of the number of rhyme words
			int index = 1;

			//Iterates through each index/line of the dictionary to see if the string line ends with user input string rhyme and prints it out.
			foreach (string line in Lines)
			{
				if (line.EndsWith(rhyme))
				{
					Console.WriteLine("Rhyme Word: {0}: {1}", index, line);
					index++;
				}
			}
		}

		/// <summary>
		/// Checks user input to make up a word inside the dictionary
		/// </summary>
		/// <param name="scrabble"></param>
		public void ScrabbleWord(string scrabble)
		{
			Console.WriteLine("Scrabbling Word...");
			HashSet<string> finalList = new HashSet<string>();        //Initialize a new empty HashSet of generic string to store distinct strings

			//Iterates through the entire WordList file
			for (int k = 0; k < Lines.Length; k++)
			{
				List<char> words = new List<char>();    //Intialize a  new empty List of generic char to store multiple letters for each line in WordList

				string line = Lines[k];                 //line gets the index or location of where you are in the WordsList

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
								words.Add(Lines[k][i]);     //adds the letter to the List words.
								break;                      //and breaks out of the current loop j. Goes to next iteration of index for string line.
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
			int index = 1;

			//Iterates through each item in the finalList and prnts out the item string.
			foreach (string item in finalList)
			{
				if (item != "")     //Check for any empty items
				{
					Console.WriteLine("Scrabble Word {0}: {1}", index, item);
				}
				index++;
			}
		}

		/// <summary>
		/// Checks for any duplicate letters that do not match with user input's letters and removes them
		/// </summary>
		/// <param name="set"></param>
		/// <param name="words"></param>
		/// <returns></returns>
		public List<char> RemoveLeftovers(List<char> set, string words)
		{
			List<char> temp = new List<char>(set);      //Initalize a temporary List to get values in the List set.

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
				return set;     //Returns the original List <char> if there are no left over words in temp.
			}
			if (temp.Count > 0)
			{
				temp.Clear();
			}
			return temp;        //Returns temp as invalid scrabble word if cannot check duplicate letters.
		}


		/// <summary>
		/// Double checks if the List set is equal to type string line
		/// Converts List set to a string and returns it.
		/// </summary>
		/// <param name="set"></param>
		/// <returns></returns>
		public string AddWord(List<char> set)
		{
			List<string> temp = new List<string>();    //Empty List to store strings
			if (set.Count >= 3 && set.Count <= 7)
			{
				char[] list = set.ToArray();
				string s = new string(list);        //Convert List type char set to a type string
				for (int i = 0; i < Lines.Length; i++)
				{
					string line = Lines[i];
					if (line.Equals(s))     //Checks if it line equals the set
					{
						temp.Add(line);        //Adds to the List string outside the loop.
					}
				}
			}
			string result = string.Join("", temp.ToArray());       //Makes result as a readable string from refer.
			return result;
		}

		/// <summary>
		/// Checks for words in the dictionary if it is equal to the morphed word "temp"
		/// </summary>
		/// <param name="morph"></param>
		public void MorphWord(string morph)
		{
			int index = 1;
			HashSet<string> FinalMorphSet = new HashSet<string>();
			string alphabet = "abcdefghijklmnopqrstuvwxyz";     //used for replacing the index of morph word
			Console.WriteLine("Its Morphin' time!");
			for (int i = 0; i < Lines.Length; i++)
			{
				string line = Lines[i];
				for (int j = 0; j < morph.Length; j++)
				{
					for (int k = 0; k < alphabet.Length; k++)
					{
						//Replaces your input string index with the index of the alphabet
						string temp = morph.Replace(morph[j], alphabet[k]);

						// Checks if the from the WordList.txt equals temp and not equal to the user input morph word; prints results
						if ((string.Equals(line, temp, StringComparison.OrdinalIgnoreCase)) && !line.Equals(morph)) //StringComparison.OrdinalIgnoreCase makes word case-insensitive
						{
							FinalMorphSet.Add(line);        //Adds to the Hashset to remove any duplicate strings
						}
					}
				}
			}
			foreach (string s in FinalMorphSet)
			{
				Console.WriteLine("Morph Word {0}: {1}", index, s);
				index++;
			}
		}
	}
}