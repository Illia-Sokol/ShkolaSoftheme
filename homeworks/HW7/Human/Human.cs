using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Human
    {
        public int _birthDate;
        public string _firstName;
        public string _lastName;
        private readonly int _age;

        public Human(int birthDate, string firstName, string lastName)
        {
            _birthDate = birthDate;
            _firstName = firstName;
            _lastName = lastName;
            _age = 23;
        }

        public Human(int birthDate, string firstName, string lastName, int age)
        {
            _birthDate = birthDate;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public bool Equals(Human human)
        {
            if (_birthDate == human._birthDate
                && _firstName == human._firstName
                && _lastName == human._lastName)
            {
                return true;
            }
            return false;
        }
    }
}
