using System;

namespace Managin_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EnterNumber();
            }
            catch (MyException e)
            {
                Console.WriteLine(e);
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad format for number");
            }
        }

        static void EnterNumber()
        {
            var number = getRandomNumber();
            var i = 0;

            while(true)
            {
                Console.WriteLine("Plese enter number in the range from 0 to 10");
                var userNumber = Int32.Parse(Console.ReadLine());

                if (userNumber < 0 || userNumber > 10)
                {
                    throw new MyException("ATTENTION!!! Your number must be in the range from 0 to 10");
                }
                if (userNumber == number)
                {
                    Console.WriteLine("Success!!! You are win!!!");
                    number = getRandomNumber();
                    i = 0;
                }
                else
                {
                    Console.WriteLine("Your number is wrong, please enter new number");
                    i++;
                    if(i > 2)
                    {
                        break;
                    }
                }
            }
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
