using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesginPatterns.Entities;

namespace DesignPatterns.Interface
{
    public interface IProductAdapter
    {
        ProductEntity GetProduct();
    }
}
