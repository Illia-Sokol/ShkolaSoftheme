using System;

namespace Managin_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = getRandomNumber();

            for (var i = 0; i < 3;)
            {
                try
                {
                    bool isRightNumber = EnterNumber(number);
                    if(isRightNumber)
                    {
                        number = getRandomNumber();
                        i = 0;
                    }
                }
                catch (Exception e)
                {
                    i++;
                    Console.WriteLine(e);
                }
            }
        }

        static bool EnterNumber(int randomNumber)
        {
            Console.WriteLine("Plese enter number in the range from 0 to 10");
            var userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber == randomNumber)
            {
                Console.WriteLine("Success!!! You are win!!!");
                return true;
            }
            else if (userNumber < 0 || userNumber > 10)
            {
                throw new InvalidProgramException("ATTENTION!!! Your number must be in the range from 0 to 10");
            }
            throw new InvalidOperationException("Your number is wrong, please enter new number");
        }

        static int getRandomNumber()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(0, 10);
            Console.WriteLine("random number is {0}", number);
            return number;
        }
    }
}
