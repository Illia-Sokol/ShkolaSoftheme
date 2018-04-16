using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using System.Collections.ObjectModel;
using DesignPatterns.Modules.Models;
using System.Globalization;

namespace DesignPatterns.Modules.ViewModels
{
    public class DecoratorViewModel : ViewModelBase
    {
        private string widgetDescription;
        private string widgetCost;

        public string WidgetDescription
        {
            get
            {
                return this.widgetDescription;
            }
            set
            {
                this.widgetDescription = value;
                this.OnPropertyChanged("WidgetDescription");
            }
        }

        public string WidgetCost
        {
            get
            {
                return this.widgetCost;
            }
            set
            {
                this.widgetCost = value;
                this.OnPropertyChanged("WidgetCost");
            }
        }
        public DecoratorViewModel()
        {
            Widget widget = new ConcreteSamsung();
            widget = new SamsungLaptop(widget);
            widget = new SamsungTab2(widget);

            this.WidgetDescription = widget.GetDescription();
            this.WidgetCost = string.Format("{0:C}", widget.GetCost());

        }
    }
}