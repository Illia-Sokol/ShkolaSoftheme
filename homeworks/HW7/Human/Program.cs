using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            var humanOne = new Human(23, "Eric", "Eliot");
            Console.WriteLine("{0}, {1}, {2}", 
                humanOne.BirthDate, humanOne.FirstName, humanOne.LastName);

            Console.WriteLine("---------------------------------");

            var humanTwo = new Human(65, "Mark", "Bartra");
            Console.WriteLine("{0}, {1}, {2}",
                humanTwo.BirthDate, humanTwo.FirstName, humanTwo.LastName);

            Console.WriteLine(humanOne.Equals(humanOne));
            Console.WriteLine(humanTwo.Equals(humanOne));
        }
    }
}
