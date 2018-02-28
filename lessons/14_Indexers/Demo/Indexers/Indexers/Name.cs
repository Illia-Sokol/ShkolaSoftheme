
namespace Indexers
{
	struct Name
	{
        private readonly string _name;

		public Name(string text)
		{
			_name = text;
		}

		public string Text
		{
			get { return _name; }
		}

		public override int GetHashCode()
		{
			return _name.GetHashCode();
		}

		public override bool Equals(object other)
		{
			return (other is Name) && Equals((Name)other);
		}
		
		public bool Equals(Name other)
		{
			return _name == other._name;
		}
	}
}