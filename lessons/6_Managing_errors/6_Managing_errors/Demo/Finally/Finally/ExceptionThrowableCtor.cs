using System;

namespace Finally
{
    public class ExceptionThrowableCtor
    {
        public ExceptionThrowableCtor()
        {
            Value = new Random().Next(0, 999);

            throw new InvalidOperationException("Exception from ctor");
        }

        public int Value { get; set; }

        ~ExceptionThrowableCtor()
        {
            throw new InvalidOperationException("Exception from finalizer");
        }
    }
}