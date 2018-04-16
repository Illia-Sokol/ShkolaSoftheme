using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Modules.Models
{
    public class ProductEntity
    {
        public string ModelName { get; set; }

        public string Price { get; set; }

        public string Warranty { get; set; }
    }

    //Defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected.
    public interface IProductSubject
    {
        ProductEntity GetProductRequest();
    }

    //Defines the real object that the proxy represents.
    public class ProductRealSubject : IProductSubject
    {
        public ProductEntity GetProductRequest()
        {
            ProductEntity entity = new ProductEntity();
            entity.ModelName = "Galaxy Tab 2 7.0 P3100";
            double price = 100.00;
            entity.Price = string.Format("{0:C}", price);
            entity.Warranty = "1 year Manufacture Warranty";
            return entity;
        }
    }

    // Maintains a reference that lets the proxy access the real subject.
    // Creates an object on demand
    public class VirtualProxy : IProductSubject
    {
        ProductRealSubject realSubject;
        public ProductEntity GetProductRequest()
        {
            // A virtual proxy creates the object only on its first method call i.e On demand
            if (realSubject == null)
                realSubject = new ProductRealSubject();
            return realSubject.GetProductRequest();
        }
    }

    // Maintains a reference that lets the proxy access the real subject.
    //An authentication proxy first asks for a password
    public class ProtectionProxy : IProductSubject
    {
        string validationMessage = string.Empty;
        ProductRealSubject realSubject;
        string password = "Poison";

        public string Authenticate(string _password)
        {
            if (_password != password)
            {
                validationMessage = "Authentication Failed";
            }
            else
            {
                realSubject = new ProductRealSubject();
                validationMessage = "Authenticated, Kindly Continue Shopping";
            }
            return validationMessage;
        }

        public ProductEntity GetProductRequest()
        {
            if (realSubject == null)
            {
                validationMessage = "Authentication Failed";
            }
            return realSubject.GetProductRequest();
        }
    }
}
