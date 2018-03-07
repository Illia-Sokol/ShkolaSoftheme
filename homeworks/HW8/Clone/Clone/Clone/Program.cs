using System;

namespace Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________User Copy by Reference____________");
            User userCopyByReference = new User("David", "Beckham", 40);
            Console.WriteLine("{0}, {1}, {2}", 
                userCopyByReference.Name, userCopyByReference.Surname, userCopyByReference.Age);

            User userCopyByReference2 = userCopyByReference.CopyByReference(userCopyByReference);
            Console.WriteLine("{0}, {1}, {2}",
                userCopyByReference2.Name, userCopyByReference2.Surname, userCopyByReference2.Age);

            userCopyByReference.ChangeName("Jack");
            Console.WriteLine("{0}, {1}, {2}", 
                userCopyByReference.Name, userCopyByReference.Surname, userCopyByReference.Age);
            Console.WriteLine("{0}, {1}, {2}",
                userCopyByReference2.Name, userCopyByReference2.Surname, userCopyByReference2.Age);

            Console.WriteLine("_________________User Copy__________________________");

            User userCopy = new User("David", "Beckham", 40);
            User userCopy2 = userCopy.Copy(userCopy);
            PrintUser(userCopy);
            PrintUser(userCopy2);

            userCopy.ChangeName("Jack");
            PrintUser(userCopy);
            PrintUser(userCopy2);
        }

        static void PrintUser(User user)
        {
            Console.WriteLine("{0}, {1}, {2}", user.Name, user.Surname, user.Age);
        }
    }
}
