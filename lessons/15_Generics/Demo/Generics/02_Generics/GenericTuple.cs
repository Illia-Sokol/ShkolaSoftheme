using System;

namespace _02_Generics
{
    public class GenericTuple<TValue1, TValue2, TValue3>
    {
        private readonly TValue1 _value1;
        private readonly TValue2 _value2;
        private readonly TValue3 _value3;

        public GenericTuple(TValue1 value1, TValue2 value2, TValue3 value3)
        {
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
        }

        public override string ToString()
        {
            var typesInfo = string.Format("Type1: {0}, Type2: {1}, Type3: {2}", typeof(TValue1), typeof(TValue2), typeof(TValue3));
            var valuesToString = string.Format("Type1: {0}, Type2: {1}, Type3: {2}", _value1, _value2, _value3);

            return string.Concat(typesInfo, Environment.NewLine, valuesToString);
        }
    }
}