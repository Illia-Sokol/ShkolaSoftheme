using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Modules.Models
{
    public interface IProduct
    {
        string GetModelName();

        string GetPrice();

        string GetWarranty();
    }

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

    public interface IClientProduct
    {
        void GetProduct(string moduleName, string price, string warranty);
    }

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

    public class ProductAdapter : IProductAdapter
    {
        public ProductAdapter()
        {

        }

        public ClientProduct GetProduct()
        {
            Product product = new Product();
            ClientProduct client = new ClientProduct();
            client.GetProduct(product.GetModelName(), product.GetPrice(), product.GetWarranty());
            return client;
        }
    }

    public interface IProductAdapter
    {
        ClientProduct GetProduct();
    }
}
