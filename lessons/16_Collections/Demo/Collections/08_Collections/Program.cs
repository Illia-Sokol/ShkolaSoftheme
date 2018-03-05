using System;
using System.Collections.Generic;

namespace _08_Collections
{
    class Program
    {
        static void Main()
        {
            var userList = new List<User>
            {
                new User {Name = "Bob", Age = 20},
                new User {Name = "Mike", Age = 30},
                new User {Name = "Alice", Age = 20}
            };

            var user = userList.Find(userItem => userItem.Name.Equals("Mike"));

            Console.WriteLine("User Name: {0}, user Age: {1}", user.Name, user.Age);
        }
    }
}
