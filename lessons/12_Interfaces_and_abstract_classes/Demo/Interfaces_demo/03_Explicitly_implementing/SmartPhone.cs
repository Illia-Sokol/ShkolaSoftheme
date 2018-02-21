using System;

namespace _03_Explicitly_implementing
{
    public class SmartPhone : IPhone, ICamera, IGameConsole, IPlayer
    {
        public void Call(string number)
        {
            Console.WriteLine("Calling: {0}", number);
        }

        public void TakePicture()
        {
            Console.WriteLine("Tacking picture");
        }

        void IPlayer.Play(string songName)
        {
            Console.WriteLine("Start playing song '{0}'", songName);
        }

        void IGameConsole.Play(string gameName)
        {
            Console.WriteLine("Starting the game '{0}'", gameName);
        }
    }
}