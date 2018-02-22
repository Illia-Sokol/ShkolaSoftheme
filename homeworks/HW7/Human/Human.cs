using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Human
    {
        public int BirthDate { get; }
        public string FirstName { get; }
        public string LastName { get; }
        private readonly int Age;

        public Human(int birthDate, string firstName, string lastName)
        {
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
            Age = 23;
        }

        public Human(int birthDate, string firstName, string lastName, int age)
        {
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public bool Equals(Human human)
        {
            if (BirthDate == human.BirthDate
                && FirstName == human.FirstName
                && LastName == human.LastName)
            {
                return true;
            }
            return false;
        }
    }
}
