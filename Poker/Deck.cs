using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Poker
{
    public static class Deck
    {
        public static List<Card> CardsAlreadyDrawn = new List<Card>();
        public static int currentDeckSize { get; set; }
 

        /* Count the number of cards drawn.
        static int counter = 0;

        public Card()
        {
            Interlocked.Increment(ref counter);
        }

        public ~Card()
        {
            Interlocked.Decrement(ref counter);
        }
        */


    }
}
