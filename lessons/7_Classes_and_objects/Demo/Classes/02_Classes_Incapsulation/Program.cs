using System;

namespace _02_Classes_Incapsulation
{
    class Program
    {
        static void Main()
        {
            var bob = new Employee("Bob", "Simon", 200);

            Console.WriteLine(bob.FirstName);
            Console.WriteLine(bob.LastName);
            //Console.WriteLine(bob.Salary);

            Console.WriteLine(bob.GetFullInfo());

            Console.ReadKey();
        }
    }

    class Employee
    {
        public Employee(string firstName, string lastName)
            : this(firstName, lastName, 0)
        {
        }

        public Employee(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        private int Salary { get; set; }

        public string GetFullInfo()
        {
            var message = string.Format("Name: {0}, FName: {1}, Salary: {2}", FirstName, LastName, Salary);
            return message;
        }
    }
}
