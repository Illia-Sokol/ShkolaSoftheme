using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DesignPatterns.Modules.Models
{
    //Implementer
    public interface ICurrenyFormatter
    {
        string FormatOperation(string value);
    }

    //Concrete ImplementerA
    public class IndianCurrency : ICurrenyFormatter
    {
        public string FormatOperation(string value)
        {
            decimal parsed = decimal.Parse(value, CultureInfo.InvariantCulture);
            CultureInfo hindi = new CultureInfo("hi-IN");
            string format = string.Format(hindi, "{0:c}", parsed);
            return format;
        }
    }

    //Concrete ImplementerB
    partial class UsCurrency : ICurrenyFormatter
    {
        public string FormatOperation(string value)
        {
            decimal parsed = decimal.Parse(value, CultureInfo.InvariantCulture);
            string format = string.Format("{0:C}", parsed);
            return format;
        }
    }

    //Abstraction
    public abstract class Formatter
    {
        protected readonly ICurrenyFormatter _formatter;

        public Formatter(ICurrenyFormatter formatter)
        {
            _formatter = formatter;
        }
        public abstract string FormatOperation(string value);
    }

    public class RefinedFormatter : Formatter
    {
        public RefinedFormatter(ICurrenyFormatter formatter)
            : base(formatter)
        { }
        public override string FormatOperation(string value)
        {
            string format = string.Empty;
            format = _formatter.FormatOperation(value);
            return format;
        }
    }
}
