using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using DesignPatterns.Modules.Models;
using System.Reflection;

namespace DesignPatterns.Modules.ViewModels
{
    public class FactoryMethodViewModel : ViewModelBase
    {
        private string modelName;
        private string price;
        private string warranty;

        public string ModelName
        {
            get
            {
                return this.modelName;
            }
            set
            {
                this.modelName = value;
                this.OnPropertyChanged("ModelName");
            }
        }

        public string Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
                this.OnPropertyChanged("Price");
            }
        }

        public string Warranty
        {
            get
            {
                return this.warranty;
            }
            set
            {
                this.warranty = value;
                this.OnPropertyChanged("Warranty");
            }
        }

        public FactoryMethodViewModel()
        {
            IBrandFactory factory = InvokeFactory();
            IBrand brand = factory.GetBrand();
            ModelName = brand.GetModelName();
            Price = brand.GetPrice();
            Warranty = brand.GetWarranty();
        }

        static IBrandFactory InvokeFactory()
        {
            string factoryName = Properties.Settings.Default.BrandFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IBrandFactory;
        }
    }
}
