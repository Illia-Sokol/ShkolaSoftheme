using System;
using System.IO;

namespace _05_Dispose_pattern
{
    public class DisposableResourceHolder : IDisposable
    {
        private readonly StreamReader _resource;
        private bool _disposed;

        public DisposableResourceHolder()
        {
            this._resource = new StreamReader(@"D:\file.txt");
        }

        ~DisposableResourceHolder()
        {
            Dispose(false);
        }

        public void DoSomeAction()
        {
            Console.WriteLine("Some action");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // free managed resources
                    if (_resource != null)
                    {
                        _resource.Dispose();
                    }
                }

                // free unmanaged resources
                // ...
                
                _disposed = true;
            }
        }
    }
}