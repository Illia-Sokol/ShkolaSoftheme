namespace Cards
{
	class PlayingCard
	{
        private readonly Suit _suit;
        private readonly Value _value;

		public PlayingCard(Suit s, Value v)
		{
			_suit = s;
			_value = v;
		}

        public override string ToString()
		{
            var result = string.Format("{0} of {1}", _value, _suit);
			return result;
		}

        public Suit CardSuit()
        {
            return _suit;
        }

        public Value CardValue()
        {
            return _value;
        }
	}
}