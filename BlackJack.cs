using System;
using System.Collection.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)

        int option = startOption();
        int32[] values;

        private List<Card> cards;

        /// <summary>
        /// Initilize on creation of Deck.
        /// </summary>
        public Deck()
        {
            Initialize();
        }
        /// <returns>
        /// Returns a Cold Deck-- a deck organized by Suit and Face.
        /// </returns>
        public List<Card> GetColdDeck()
        {
            List<Card> coldDeck = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    coldDeck.Add(new Card((Suit)j, (Face)i));
                }
            }
    }
}