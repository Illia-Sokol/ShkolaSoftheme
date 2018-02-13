using System;

namespace _05_Classes_Anonymous_type
{
    class Program
    {
        static void Main()
        {
            var user1 = new { Name = "Bob", Age = 20 };
            var user2 = new { Name = "John", Age = 19 };

            //var user2 = new { Name = "John", Age = 19, LName = "Smith" };

            Console.WriteLine(user1.Name, user1.Age);
            Console.WriteLine(user1.GetType().ToString());

            Console.WriteLine("/n--------------------/n");

            Console.WriteLine(user2.Name, user2.Age);
            Console.WriteLine(user2.GetType().ToString());


            //user1.Name = "Adam";
            //user1.Age = 22;

            var arrayOfUsers = new[] { user1, user2 };

            foreach (var user in arrayOfUsers)
            {
                Console.WriteLine(user.Name);
            }

            var anonymousUser = ReturnAnonymousUser();
            Console.WriteLine(anonymousUser.ToString());
            Console.WriteLine(anonymousUser.GetType().ToString());
            //Console.WriteLine(anonymousUser.Name);

            //var propertyInfo = anonymousUser.GetType().GetProperty("Name");
            //var value = propertyInfo.GetValue(anonymousUser, null) as string;
            //Console.WriteLine(value);

            Console.ReadKey();
        }

        public static object ReturnAnonymousUser()
        {
            var user1 = new { Name = "AnonymousBob", Age = 20 };
            return user1;
        }
    }
}
