using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Interface
{
    public interface IClientProduct
    {
        void GetProduct(string moduleName, string price, string warranty);
    }
}
