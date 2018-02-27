using System;
using System.Collections.Generic;
using System.Text;

namespace Clone
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; }
        public int Age { get; }

        public User (string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public User Copy (User user)
        {
            return new User(user.Name, user.Surname, user.Age);
        }

        public User CopyByReference(User user)
        {
            return user;
        }

        public void ChangeName (string name)
        {
            Name = name;
        }
    }
}
