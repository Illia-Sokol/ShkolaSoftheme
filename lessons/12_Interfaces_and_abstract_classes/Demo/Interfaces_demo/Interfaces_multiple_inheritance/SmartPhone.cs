using System;

namespace Interfaces_multiple_inheritance
{
    public class SmartPhone : ISmartPhone
    {
        public void Call(string number)
        {
            Console.WriteLine("Calling: {0}", number);
        }

        public void TakePicture()
        {
            Console.WriteLine("Tacking picture");
        }

        public void PlayGame(string name)
        {
            Console.WriteLine("Playing game");
        }
    }
}