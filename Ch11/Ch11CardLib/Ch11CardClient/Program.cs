using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ch11CardLib;

namespace Ch11CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Running: Ch11CardClient");
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Write(tempCard.ToString());
                if (i != 51)
                {
                    Write(", ");
                }
                else
                {
                    WriteLine();
                }
            }
            WriteLine();

            // Second test with overloaded comparison operators
            WriteLine("Second set of tests.");
            Card.isAceHigh = true;
            WriteLine("Aces are high.");
            Card.useTrumps = true;
            Card.trump = Suit.Club;
            WriteLine("Clubs are trumps.");
            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Club, Rank.Five);
            card2 = new Card(Suit.Club, Rank.Five);
            card3 = new Card(Suit.Club, Rank.Ace);
            card4 = new Card(Suit.Heart, Rank.Ten);
            card5 = new Card(Suit.Diamond, Rank.Ace);
            WriteLine($"{card1.ToString()} == {card2.ToString()} ? {card1 == card2}");
            WriteLine($"{card1.ToString()} != {card3.ToString()} ? {card1 != card3}");
            WriteLine($"{card1.ToString()}.Equals({card4.ToString()}) ? " + $"{card1.Equals(card4)}");
            WriteLine($"Card.Equals({card3.ToString()}, {card4.ToString()}) ? " + $"{ Card.Equals(card3, card4)}");
            WriteLine($"{card1.ToString()} > {card2.ToString()} ? {card1 > card2}");
            WriteLine($"{card1.ToString()} <= {card3.ToString()} ? {card1 <= card3}");
            WriteLine($"{card1.ToString()} > {card4.ToString()} ? {card1 > card4}");
            WriteLine($"{card4.ToString()} > {card1.ToString()} ? {card4 > card1}");
            WriteLine($"{card5.ToString()} > {card4.ToString()} ? {card5 > card4}");
            WriteLine($"{card4.ToString()} > {card5.ToString()} ? {card4 > card5}");

            //ReadKey();
        }
    }
}

