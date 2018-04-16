using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using DesignPatterns.Modules.Models;

namespace DesignPatterns.Modules.ViewModels
{
    public class ProxyViewModel : ViewModelBase
    {
        #region Private Properties
        private string modelName;
        private string price;
        private string warranty;
        #endregion

        #region Public Properties
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
        
        #endregion

        public ProxyViewModel()
        {
            IProductSubject proxy = new VirtualProxy();
            var items = proxy.GetProductRequest();
            this.ModelName = items.ModelName;
            this.Price = items.Price;
            this.Warranty = items.Warranty;
        }
    }
}
