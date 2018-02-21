namespace _04_Abstract
{
    class UserFamily : UserInfo
    {
        readonly string _family;

        public UserFamily(string family, string name, byte age)
            : base(name, age)
        {
            _family = family;
        }

        public override string GetInfo()
        {
            return _family + " " + Name + " " + Age;
        }

        public sealed override string GetAgeInfo()
        {
            return "Nothing";
        }
    }
}