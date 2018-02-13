using System;

namespace _04_Classes_Static_ctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(User.Company);

            //var user = new User("Bob");

            //var user = new User();

            //Console.WriteLine(user.ToString());
            Console.ReadKey();
        }
    }

    public class User
    {
        public static string Company = "Softheme";

        static User()
        {
            Console.WriteLine("Static ctor");
        }

        public User()
        {
            Console.WriteLine("Default ctor");
        }

        public User(string name)
        {
            Name = name;
            Console.WriteLine("Parameterized ctor");
        }

        public string Name { get; set; }
    }
}
