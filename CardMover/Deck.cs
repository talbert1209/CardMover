using System;
using System.Collections.Generic;

namespace CardMover
{
    public class Deck
    {
        private List<Card> _cards;
        private Random random = new Random();
        public int Count
        {
            get { return _cards.Count; }
        }

        public Deck()
        {
            _cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    _cards.Add(new Card((Suit)suit, (Value)value));
                }
            }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            _cards = new List<Card>(initialCards);
        }
    }
}