using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Interface
{
    public interface IProduct
    {
        string GetModelName();

        string GetPrice();

        string GetWarranty();
    }
}
