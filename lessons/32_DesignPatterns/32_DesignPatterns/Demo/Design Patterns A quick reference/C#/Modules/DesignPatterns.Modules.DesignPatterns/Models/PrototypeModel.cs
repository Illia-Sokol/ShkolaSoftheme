using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Modules.Models
{

    public class ProductPrototype : ICloneable
    {
        public string ModuleName;
        public string Price;
        public string Warranty;

        public string GetModelName()
        {
            ModuleName = "Galaxy Tab 2 7.0 P3100";
            return ModuleName;
        }

        public string GetPrice()
        {
            double doublePrice = 100;
            Price = String.Format("{0:C}", doublePrice);
            return Price;
        }

        public string GetWarranty()
        {
            Warranty = "1 Year Manufacuture Warranty ";
            return Warranty;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
