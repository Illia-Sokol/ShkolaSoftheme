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
            Console.WriteLine("{0}, {1}, {2}", userCopy.Name, userCopy.Surname, userCopy.Age);

            User userCopy2 = userCopy.Copy(userCopy);
            Console.WriteLine("{0}, {1}, {2}", userCopy2.Name, userCopy2.Surname, userCopy2.Age);

            userCopy.ChangeName("Jack");
            Console.WriteLine("{0}, {1}, {2}", userCopy.Name, userCopy.Surname, userCopy.Age);
            Console.WriteLine("{0}, {1}, {2}", userCopy2.Name, userCopy2.Surname, userCopy2.Age);

        }
    }
}
