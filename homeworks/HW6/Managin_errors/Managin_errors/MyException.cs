using System;
using System.Collections.Generic;
using System.Text;

namespace Managin_errors
{
    class MyException : Exception
    {
        public MyException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
