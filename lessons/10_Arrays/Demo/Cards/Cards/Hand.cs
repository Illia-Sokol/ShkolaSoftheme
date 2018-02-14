using System;

namespace Cards
{	
	class Hand
	{
        public const int HandSize = 13;
        private readonly PlayingCard[] _cards = new PlayingCard[HandSize];
        private int _playingCardCount;

		public void AddCardToHand(PlayingCard cardDealt)
		{
            if (_playingCardCount >= HandSize)
            {
                throw new ArgumentException("Too many cards");
            }
            _cards[_playingCardCount] = cardDealt;
            _playingCardCount++;
		}

		public override string ToString()
		{
			var result = "";
			foreach (var card in _cards)
			{
				result += card + "\n";
			}

			return result;
		}
	}
}