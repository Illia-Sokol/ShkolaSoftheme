using System;

namespace Indexers
{
	sealed class PhoneBook
	{
        private int _used;
        private Name[] _names;
        private PhoneNumber[] _phoneNumbers;

		public PhoneBook()
		{
			int initialSize = 0;
			_used = 0;
			_names = new Name[initialSize];
			_phoneNumbers = new PhoneNumber[initialSize];
		}
		
		public void Add(Name name, PhoneNumber number)
		{
			EnlargeIfFull();
			_names[_used] = name;
			_phoneNumbers[_used] = number;
			_used++;
		}

        public Name this[PhoneNumber number]
        {
            get
            {
                var i = Array.IndexOf(_phoneNumbers, number);
                if (i != -1)
                {
                    return _names[i];
                }

                return new Name();
            }
        }

        public PhoneNumber this[Name name]
        {
            get
            {
                var i = Array.IndexOf(_names, name);
                if (i != -1)
                {
                    return _phoneNumbers[i];
                }

                return new PhoneNumber();
            }
        }

		private void EnlargeIfFull()
		{
			if (_used == _names.Length)
			{
				var bigger = _used + 16;
				
				var moreNames = new Name[bigger];
				_names.CopyTo(moreNames, 0);
				
				var morePhoneNumbers = new PhoneNumber[bigger];
				_phoneNumbers.CopyTo(morePhoneNumbers, 0);
						
				_names = moreNames;
				_phoneNumbers = morePhoneNumbers;
			}
		}
	}
}