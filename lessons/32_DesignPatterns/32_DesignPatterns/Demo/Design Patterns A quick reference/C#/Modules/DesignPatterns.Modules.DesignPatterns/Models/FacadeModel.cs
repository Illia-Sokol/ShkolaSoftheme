using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Modules.Models
{
    public class Model
    {
        public string GetModelName()
        {
            string ModuleName = "Galaxy Tab 2 7.0 P3100";
            return ModuleName;
        }
    }

    public class Price
    {
        public string GetPrice()
        {
            double doublePrice = 100;
            string price = String.Format("{0:C}", doublePrice);
            return price;
        }
    }

    public class Warranty
    {
        public string GetWarranty()
        {
            string Warranty = "1 Year Manufacuture Warranty ";
            return Warranty;
        }
    }

    public class FacadeProduct
    {
        Model model = new Model();
        Price price = new Price();
        Warranty warranty = new Warranty();

        public FacadeEntity GetProduct()
        {
            FacadeEntity items = new FacadeEntity();
            items.Model = model.GetModelName();
            items.Price = price.GetPrice();
            items.Warranty = warranty.GetWarranty();
            return items;
        }
    }

    public class FacadeEntity
    {
        public string Model { get; set; }
        public string Price { get; set; }
        public string Warranty { get; set; }
    }
}
