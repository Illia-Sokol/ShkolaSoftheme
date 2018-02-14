using System;

namespace Cards
{
    class Pack
    {
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        private readonly PlayingCard[,] _cardPack;
        private readonly Random _randomCardSelector = new Random();

        public Pack()
        {
            _cardPack = new PlayingCard[NumSuits, CardsPerSuit];
            for (var suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                for (var value = Value.Two; value <= Value.Ace; value++)
                {
                    _cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
                }
            }
        }

        public PlayingCard DealCardFromPack()
        {
            var suit = (Suit)_randomCardSelector.Next(NumSuits);
            while (IsSuitEmpty(suit))
            {
                suit = (Suit)_randomCardSelector.Next(NumSuits);
            }

            var value = (Value)_randomCardSelector.Next(CardsPerSuit);
            while (IsCardAlreadyDealt(suit, value))
            {
                value = (Value)_randomCardSelector.Next(CardsPerSuit);
            }

            var card = _cardPack[(int)suit, (int)value];
            _cardPack[(int)suit, (int)value] = null;
            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            var result = true;
            for (var value = Value.Two; value <= Value.Ace; value++)
            {
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            return (_cardPack[(int)suit, (int)value] == null);
        }
    }
}