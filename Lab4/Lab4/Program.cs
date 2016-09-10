using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /// <summary>
    /// Implements Lab 4 functionality
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Lab 4 functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args) {
            // create a new deck and print the contents of the deck
            Deck deck = new Deck();        //Initialize varaible deck with type Deck to get new type Deck
            // shuffle the deck and print the contents of the deck
            deck.Print();
            deck.Shuffle();
            Console.Write("Shuffling...");
            Console.ReadKey();      //Continue the shuffle process; Comment out ReadKey if annoying
            deck.Print();
            // take the top card from the deck and print the card rank and suit
            Card info1 = deck.TakeTopCard();                                           //the object card info(n) gets that decks top card
            Console.WriteLine("The top card was {0} of {1}", info1.Rank, info1.Suit); //info1 has Card properties Rank and Suit
            // take the top card from the deck and print the card rank and suit
            Card info2 = deck.TakeTopCard();
            Console.WriteLine("Then next top card was {0} of {1}", info2.Rank, info2.Suit); //info2 has Card properties Rank and Suit
        }
    }
}
