namespace _04_Abstract
{
    abstract class UserInfo
    {
        protected string Name;
        protected byte Age;

        protected UserInfo(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public abstract string GetInfo();

        public virtual string GetAgeInfo()
        {
            var message = string.Format("{0} is {1} years old", Name, Age);
            return message;
        }

        public virtual string GetNameInfo()
        {
            var message = string.Format("Name is {0}", Name);
            return message;
        }
    }
}