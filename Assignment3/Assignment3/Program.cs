using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
	class Program
	{
		/// <summary>
		/// Interface of the Assignment.  Prints a menu for each option using a Switch statement.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{

			//create constructor for type Word class
			Words word = new Words();
			bool exit = false;

			//While loop; only breaks out of the menu if exit = true;
			while (!exit)
			{
				Console.Write("1. All Words\n2. Rhyming words\n3. Scrabble words\n4. Morph words\n5. Morph chain\n6. Quit Program\nYour choice: ");

				//User input for to select a Option from the menu
				int input = int.Parse(Console.ReadLine());
				switch (input)
				{

					//Prints out all the content in the textfile using PrintAll method from Word Class.
					case 1:
						word.PrintAll();
						break;

					//Prompts user input and searches for words that end in the same input using the RhymeWord method from Word Class.
					case 2:
						Console.Write("Let's see your freestyle! Pick a rhyme scheme: ");
						string rhyme = Console.ReadLine();
						word.RhymeWord(rhyme);     //Takes a string (user input) for the function.
						break;

					//Prompts user input and searches for words that contain the same letters in the index using ScrabbleWord method from Word Class
					case 3:
						Console.WriteLine("You don't know how to rap? Don't worry, I'll search a word that your looking for: ");
						string scrabble = Console.ReadLine();
						word.ScrabbleWord(scrabble);  //Takes a string (user input) for the function.
						break;

					//Prompts user input and searches for words that differ from one letter in the index using MorphWord method from Word Class
					case 4:
						Console.WriteLine("I'll try to morph your word into something cool.");
						string morph = Console.ReadLine();
                        string alphabet = "sack"; //used for replacing the index of morph word
                        string[] set = word.MorphWord(morph, alphabet);      //Takes a string (user input) for the function.
				        int index = 0;
                        Console.WriteLine("Its Morphin' time!");
                        foreach (string s in set)
                        {
                        	Console.WriteLine("Morph Word {0}: {1}", index, s);
                        	index++;
                        }
                        break;

					//Breaks out of the loop
					case 5:
                        Console.Write("Enter Start Word: ");
                        string start = Console.ReadLine();
                        Console.Write("Enter end word: ");
                        string end = Console.ReadLine();
                        Console.Write("Enter maximum chain length: ");
                        int max = int.Parse(Console.ReadLine());
                        word.MorphChain(start, end, max);
				        break;
                    case 6:
						Console.WriteLine("Awesome job, thanks for playing!");
						exit = true;
						break;
				}
			}
			Console.ReadKey();
		}
	}
}
