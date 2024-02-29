using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSorting
{
    internal class Program
    {
        static readonly Random random = new Random();
        static Card RandomCard()
        {
            suits suit = (suits)random.Next(4);
            values value = (values)random.Next(1, 14);

            return new Card(value, suit);
        }

        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();    
            Console.WriteLine("Enter the number of cards");
            int.TryParse(Console.ReadLine(),out int result);
            for (int i = 0; i < result; i++)
            {
                cards.Add(RandomCard());
            }

            PrintCards(cards);

            Console.WriteLine("... sorting the cards ...");
            
            CardComparerByValue cardComparerByValue = new CardComparerByValue();    
            cards.Sort(cardComparerByValue);
            PrintCards(cards);
            Console.ReadLine();
        }
    }
}
