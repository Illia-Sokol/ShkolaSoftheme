using System;

namespace Finally
{
    public class ExceptionThrowableFinalizer
    {
        public ExceptionThrowableFinalizer()
        {
            Value = new Random().Next(0, 999);
        }

        public int Value { get; set; }

        ~ExceptionThrowableFinalizer()
        {
            throw new InvalidOperationException("Exception from finalizer");
        }
    }
}