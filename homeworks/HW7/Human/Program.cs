using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            var humanOne = new Human(23, "Eric", "Eliot");
            Console.WriteLine("{0}, {1}, {2}", 
                humanOne._birthDate, humanOne._firstName, humanOne._lastName);

            Console.WriteLine("---------------------------------");

            var humanTwo = new Human(65, "Mark", "Bartra");
            Console.WriteLine("{0}, {1}, {2}",
                humanTwo._birthDate, humanTwo._firstName, humanTwo._lastName);

            Console.WriteLine(humanOne.Equals(humanOne));
            Console.WriteLine(humanTwo.Equals(humanOne));
        }
    }
}
