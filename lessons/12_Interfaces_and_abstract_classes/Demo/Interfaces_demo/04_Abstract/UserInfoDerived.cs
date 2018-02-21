namespace _04_Abstract
{
    class UserInfoDerived : UserFamily
    {
        public UserInfoDerived(string family, string name, byte age)
            : base(family, name, age)
        {
        }

        //public override string GetAgeInfo()
        //{
        //    return "Nothing";
        //}

        public override string GetNameInfo()
        {
            return string.Format("My Name is: {0}", Name);
        }
    }
}