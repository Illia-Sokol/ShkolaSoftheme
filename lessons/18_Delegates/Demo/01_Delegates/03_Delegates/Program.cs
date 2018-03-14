using System;

namespace _03_Delegates
{
    class Program
    {
        static void Main()
        {
            UserInfo[] userinfo = { new UserInfo("Dima", "Medvedev", 50000000000),
                                    new UserInfo("Alex", "Erohin", 100),
                                    new UserInfo("John", "Volkov", 40000),
                                    new UserInfo("Willy", "Coyote", 1000000)};

            Func<UserInfo, UserInfo, bool> comparisonFunc = UserInfo.UserSalary;

            ArraySort.Sort<UserInfo>(userinfo, comparisonFunc);

            Console.WriteLine("Sorting by salary:");
            foreach (var user in userinfo)
            {
                Console.WriteLine(user);
            }

            Console.ReadLine();
        }
    }
}
