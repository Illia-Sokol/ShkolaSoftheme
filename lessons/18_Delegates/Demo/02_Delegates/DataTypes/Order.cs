using System;
using System.Collections.Generic;

namespace DataTypes
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public DateTime Date { get; set; }
        
        public decimal TotalValue { get; set; }
        
        public List<OrderItem> Items { get; set; }
    }
}
