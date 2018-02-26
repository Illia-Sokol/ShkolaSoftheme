using System;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool _disposed = false;

        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }

        public void Dispose()
        {
            if (!this._disposed)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Calculator being disposed");
                Console.ResetColor();
            }

            this._disposed = true;
            GC.SuppressFinalize(this);
        }

    }
}
