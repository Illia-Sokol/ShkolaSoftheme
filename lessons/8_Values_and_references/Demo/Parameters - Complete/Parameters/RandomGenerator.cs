using System;

namespace Parameters
{
	static class RandomGenerator
	{
	    private static readonly Random Random = new Random();

	    public static void UpdateValueType(ref int valueType)
        {
            valueType = GenerateRandomValue();
        }

        public static void Reference(WrappedInt refType)
        {
            refType.Number = GenerateRandomValue();
        }

	    private static int GenerateRandomValue()
	    {
	        var randomValue = Random.Next(0, 999);
	        return randomValue;
	    }
	}
}