using System.Globalization;

namespace _03_Delegates
{
    class UserInfo
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public decimal Salary { get; private set; }

        public UserInfo(string name, string family, decimal salary)
        {
            Name = name;
            Family = family;
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1}, {2:C}", Name, Family, Salary);
        }

        public static bool UserSalary(UserInfo obj1, UserInfo obj2)
        {
            return obj1.Salary > obj2.Salary;
        }
    }
}