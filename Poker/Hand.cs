using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;



namespace Poker
{
    public class Hand
    {
        public List<Card> newHand;


        public List<Card> GetNewHand()
        {
            //Keep drawing a new card from the deck until the drawn card has not
            //been drawn is drawn already. If it has not been drawn add it to 
            //the 'cards' list of cards already drawn and then add to this hand.
            while (newHand.Count <= 5)
            {
                
                Card drawnCard = DrawCardFromDeck();
                if (CurrentCardIsDuplicate(drawnCard))
                {
                    drawnCard = null;
                }
                Deck.CardsAlreadyDrawn.Add(drawnCard);
                --Deck.CurrentDeckSize;
                newHand.Add(drawnCard);
            }
            return newHand;
        }


        private Card DrawCardFromDeck()
        {
            //Return a card of card random suit and rank
            Card newCard = new Card();
            Random random = new Random();

            string possibleSuits = "CDHS";
            char newSuit = GetRandomCharacter(possibleSuits, random);

            string possibleRanks = "23456789JQKA";
            char newRank = GetRandomCharacter(possibleRanks, random);

            newCard.Suit = newSuit;
            newCard.Rank = newRank;
            return newCard;
        }

        private static char GetRandomCharacter(string text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }



        public bool CurrentCardIsDuplicate(Card thisCard)
        {
            bool alreadyExists = Deck.CardsAlreadyDrawn.Contains(thisCard);
            if (alreadyExists)
            {
                return true;
            }
            return false;
        }

      

    }
}

