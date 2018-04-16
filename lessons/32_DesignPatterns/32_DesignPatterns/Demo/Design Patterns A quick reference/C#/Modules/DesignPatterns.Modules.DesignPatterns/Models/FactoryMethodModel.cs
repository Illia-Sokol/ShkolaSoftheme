using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Modules.Models
{
    public interface IBrand
    {
        string GetModelName();

        string GetPrice();

        string GetWarranty();
    }

    public class Sony : IBrand
    {

        public string GetModelName()
        {
            string model = string.Empty;
            model = " Sony Tab S SGPT111IN/S";
            return model;
        }

        public string GetPrice()
        {
            double doublePrice = 150;
            string price = String.Format("{0:C}", doublePrice);
            return price;
        }

        public string GetWarranty()
        {
            string Warranty = "2 Year Manufacuture Warranty ";
            return Warranty;
        }
    }

    public class Samsung : IBrand
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

    public interface IBrandFactory
    {
        IBrand GetBrand();
    }

    public class SonyFactory : IBrandFactory
    {
        public IBrand GetBrand()
        {
            return new Sony();
        }
    }

    public class SamsungFactory : IBrandFactory
    {
        public IBrand GetBrand()
        {
            return new Samsung();
        }
    }

}
