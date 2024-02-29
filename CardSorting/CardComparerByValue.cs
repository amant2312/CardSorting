using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSorting
{
    internal class CardComparerByValue: IComparer<Card>
    {
        public int Compare(Card a, Card b)
        {
            
            if (a.Suit < b.Suit) return -1;
            if (a.Suit > b.Suit) return 1;
            if(a.Value < b.Value) return -1;
            if(a.Value > b.Value)return 1;
            return 0;
        }
    }
}
