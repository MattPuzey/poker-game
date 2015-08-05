using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck pokerDeck = new Deck();
            Hand handsInPlay = new Hand();

            List<Card> player1Hand = handsInPlay.GetNewHand();
            List<Card> player2Hand = handsInPlay.GetNewHand();
            //Play a new game enter
            //Compare hands
            //Console.Write(); each hand 
            //Winnder and why.

            Scoring.ShowHands(player1Hand, player2Hand);
        }

        

    }

}
