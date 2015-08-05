using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class ScoringSession
    {
        //Ordered dict necessary for foreach iterations?
        private Dictionary<int, string> rankMapping = new Dictionary<int, string>()
        {
            {1, "A"},{2, "K"},{3, "Q"},{4, "J"},{5, "10"},{6, "11"},{7, "9"},{8, "8"},
            {9, "7"}, {10, "6"}, {11, "5"}, {12, "4"}, {13, "3"}, {14, "2"}
        };

        private Dictionary<int, string> pokerHandsMapping = new Dictionary<int, string>()
        {
            {1, "Straight flush"}, {2, "Four of a kind"}, {3, "Full House"}, 
            {4, "Flush"}, {5, "Straight"}, {6, "Three of A Kind"}, {7, "Two Pairs"},
            {8, "Pair"}
            // else high cards are picked
        };

        public string ShowHands(List<Card> hand1, List<Card> hand2)
        {
            // Handle high card calculation between two hands:
            // which item in a list matches a value that is associated with the
            // highest key of the rankMapping dict.  
            int highCard1 = FindHighcard(hand1);
            int highCard2 = FindHighcard(hand2);
            if (highCard1 > highCard2)
                return "Player 1 wins!";
            return "Player 2 wins!";

        }

        private int FindHighcard(List<Card> cardsinHand)
        {
            int highCardVal = 2; 
            // for each value in rankMapping values, is the value in the hand?
            //exit when it is, exit and make note of exiting value.
            foreach (KeyValuePair<int, string> rankKeyValuePair in rankMapping)
            {
                
                var matches = cardsinHand.Where(p => p.Rank == rankKeyValuePair.Value);
                
                if (matches != null)
                {
                    highCardVal = rankKeyValuePair.Key;
                    break;
                }
            }

            return highCardVal;
        }


    }

}
