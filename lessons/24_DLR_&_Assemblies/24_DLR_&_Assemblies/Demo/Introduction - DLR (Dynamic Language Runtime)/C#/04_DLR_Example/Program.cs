using System;
using System.Collections.Generic;
using System.Dynamic;

namespace _04_DLR_Example
{
    class MyDynamicObject : DynamicObject
    {
        readonly Dictionary<string, object> _dynamicDictionary;

        public MyDynamicObject()
        {
            _dynamicDictionary = new Dictionary<string, object>();
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            bool operationResult;
            if (_dynamicDictionary.ContainsKey(binder.Name))
            {
                result = _dynamicDictionary[binder.Name];
                operationResult = true;
            }
            else
            {
                result = "Member was not found";
                operationResult = false;
            }
            return operationResult;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _dynamicDictionary[binder.Name] = value;
            return true;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            dynamic method = _dynamicDictionary[binder.Name];
            result = method((int)args[0]);
            return result != null;
        }
    }

    class Program
    {
        static void Main()
        {
            dynamic person = new MyDynamicObject();
            person.Name = "Tom";
            person.Age = 23;
            Func<int, int> Incr = delegate(int x) { person.Age += x; return person.Age; };
            person.IncrementAge = Incr;
            Console.WriteLine("{0} - {1}", person.Name, person.Age); // Tom - 23
            person.IncrementAge(4);
            Console.WriteLine("{0} - {1}", person.Name, person.Age); // Tom - 27
        }
    }
}
