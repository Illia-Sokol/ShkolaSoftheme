using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Modules.Models
{
    public class GadgetEntity
    {
        public string Model { get; set; }
        public string Price { get; set; }
        public string Warranty { get; set; }
    }

    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        { 
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public GadgetEntity GetProduct()
        {
            GadgetEntity entity = new GadgetEntity();
            Product product = new Product();
            entity.Model = product.GetModelName();
            entity.Price = product.GetPrice();
            entity.Warranty = product.GetWarranty();
            return entity;
        }
    
    }
}
