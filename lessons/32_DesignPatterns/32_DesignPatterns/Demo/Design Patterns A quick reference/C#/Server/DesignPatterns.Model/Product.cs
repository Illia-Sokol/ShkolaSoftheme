using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Interface;

namespace DesignPatterns.BusinessLayer
{
    public class Product : IProduct
    {
        public string GetModelName()
        {
            string ModuleName = "Galaxy Tab 2 7.0 P3100";
            return ModuleName;
        }

        public string GetPrice()
        {
            double doublePrice = 100;
            string price = String.Format("{0:C}", doublePrice);
            return price;
        }

        public string GetWarranty()
        {
            string Warranty = "1 Year Manufacuture Warranty ";
            return Warranty;
        }
    }
}
