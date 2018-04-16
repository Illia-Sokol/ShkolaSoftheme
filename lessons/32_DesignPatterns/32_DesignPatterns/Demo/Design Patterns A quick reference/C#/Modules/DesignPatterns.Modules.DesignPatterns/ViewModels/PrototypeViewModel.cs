using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using DesignPatterns.Modules.Models;

namespace DesignPatterns.Modules.ViewModels
{
    public  class PrototypeViewModel : ViewModelBase
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
        public PrototypeViewModel()
        {
            var prototype = new ProductPrototype();
            ModelName = prototype.GetModelName();
            Price = prototype.GetPrice();
            Warranty = prototype.GetWarranty();

            //Cloning the Object
            var prototype2 = prototype.Clone();

        }
    
    }
}
