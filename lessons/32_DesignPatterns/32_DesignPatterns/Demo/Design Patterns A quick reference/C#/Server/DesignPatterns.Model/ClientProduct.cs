using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Interface;

namespace DesignPatterns.BusinessLayer
{
    public class ClientProduct : IClientProduct
    {
        public string ModuleName;
        public string Price;
        public string Warranty;

        public ClientProduct()
        {
        }

        public void GetProduct(string moduleName, string price, string warranty)
        {
            ModuleName = moduleName;
            Price = price;
            Warranty = warranty;
        }
    }
}
