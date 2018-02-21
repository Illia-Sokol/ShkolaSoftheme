using System;

namespace _04_Abstract
{
    class Program
    {
        static void Main()
        {
            var user1 = new UserFamily("Erohin", "Alexandr", 26);
            Console.WriteLine(user1.GetInfo());
            Console.WriteLine(user1.GetAgeInfo());
            Console.WriteLine(user1.GetNameInfo());

            var user2 = new UserInfoDerived("Smith", "John", 99);
            Console.WriteLine(user2.GetInfo());
            Console.WriteLine(user2.GetAgeInfo());
            Console.WriteLine(user2.GetNameInfo());


            Console.ReadLine();
        }
    }
}
