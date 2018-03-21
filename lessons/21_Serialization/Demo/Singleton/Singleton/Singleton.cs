using System;

namespace Singleton
{
    public class Singleton
    {
        private static volatile uint _random;
        private static readonly Lazy<Singleton> InstanceValue = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
            _random++;
            Value = _random;
        }

        public long Value { get; }

        public static Singleton Construct()
        {
            return InstanceValue.Value;
        }
    }
}
