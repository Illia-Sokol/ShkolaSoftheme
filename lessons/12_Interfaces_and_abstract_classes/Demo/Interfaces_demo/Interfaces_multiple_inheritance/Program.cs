using System;

namespace Interfaces_multiple_inheritance
{
    class Program
    {
        static void Main()
        {
            ISmartPhone phone = new SmartPhone();

            ICamera camera = phone;
            camera.TakePicture();

            phone.Call("12345678");
            phone.Call("12345678");

            phone.PlayGame("Mario");

            phone.TakePicture();

            Console.ReadKey();
        }
    }
}
