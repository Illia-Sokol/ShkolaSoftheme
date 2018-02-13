using System;

namespace _03_StructsAndEnums_Flags
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DoSomeAction();

            switch (result)
            {
                case ResultCode.Success:
                    Console.WriteLine("Success");
                    break;

                case ResultCode.Warning:
                    Console.WriteLine("Warning");
                    break;

                case ResultCode.Error:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ReadKey();
        }

        public static ResultCode DoSomeAction()
        {
            var result = new Random().Next(0, 2);
            return (ResultCode)result;
        }
    }

    public enum ResultCode
    {
        Success,
        Warning,
        Error
    }
}
