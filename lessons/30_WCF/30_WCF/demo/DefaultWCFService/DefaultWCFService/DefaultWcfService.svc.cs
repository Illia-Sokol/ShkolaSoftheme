using System;
using System.Globalization;

namespace DefaultWCFService
{
    public class DefaultWcfService : IDefaultWcfService
    {
        public string GetData(int value)
        {
            return string.Format(CultureInfo.InvariantCulture, "You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException(nameof(composite));
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }

            return composite;
        }
    }
}
