using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {

        // Scoring code is bloated  but is composed of resuable methods, 
        //for example if you were to expand the game to work for more than two players.
        //Not a proper TDD approach to the kata.
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

            ScoringSession newSession = new ScoringSession();
            newSession.ShowHands(player1Hand, player2Hand);


            
        }

        

    }

}
