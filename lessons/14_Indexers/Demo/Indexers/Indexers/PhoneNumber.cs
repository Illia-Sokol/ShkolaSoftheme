
namespace Indexers
{
	struct PhoneNumber
	{
        private readonly string _number;

		public PhoneNumber(string text)
		{
			_number = text;
		}

		public string Text
		{
			get { return _number; }
		}

		public override int GetHashCode()
		{
			return _number.GetHashCode();
		}

		public override bool Equals(object other)
		{
			return (other is PhoneNumber) && Equals((PhoneNumber)other);
		}
		
		public bool Equals(PhoneNumber other)
		{
			return _number == other._number;
		}
	}
}
