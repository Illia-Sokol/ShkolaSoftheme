using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;

namespace DesignPatterns.Modules.Models
{
    public abstract class Widget
    {
        public string Description { get; set; }

        public abstract string GetDescription();

        public abstract double GetCost();
    }

    public class ConcreteSamsung : Widget
    {
        public ConcreteSamsung()
        {
            Description = " Samsung Offer";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetCost()
        {
            return 100.00;
        }
    }

    public class WidgetDecorator : Widget
    {
        protected Widget _widget;
        public WidgetDecorator(Widget widget)
        {
            this._widget = widget;

        }

        public override string GetDescription()
        {
            return this._widget.Description;
        }

        public override double GetCost()
        {
            return this._widget.GetCost();
        }
    }

    public class SamsungTab2 : WidgetDecorator
    {
        public SamsungTab2(Widget widget)
            : base(widget)
        {
            Description = " Galaxy Tab 2 7.0 P3100 @ Only";
        }

        public override string GetDescription()
        {
            return string.Format("{0} {1}", _widget.GetDescription(), Description);
        }

        public override double GetCost()
        {
            return _widget.GetCost() + 300.00;
        }

    }

    partial class SamsungLaptop : WidgetDecorator
    {
        public SamsungLaptop(Widget widget)
            : base(widget)
        {
            Description = "Samsung Serires 350E +";
        }

        public override string GetDescription()
        {
            return string.Format("{0} {1}", _widget.GetDescription(), Description);
        }

        public override double GetCost()
        {
            return _widget.GetCost() + 400.00;
        }
    }
}
