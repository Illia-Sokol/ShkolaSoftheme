using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03_PLINQ
{
    class Program
    {
        public static void Main()
        {
            PrintDataSourceInfo();

            OrderedThenUnordered();

            SimpleOrdering();

            SequentialDemo();

            PLINQExceptions_1();

            PLINQExceptions_2();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void PrintDataSourceInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Customer count: {0}", GetCustomers().Count());
            Console.WriteLine("Product count: {0}", GetProducts().Count());
            Console.WriteLine("Order count: {0}", GetOrders().Count());
            Console.WriteLine("Order Details count: {0}", GetOrderDetails().Count());
            Console.ResetColor();
        }

        #region DataClasses
        public class Order
        {
            private Lazy<OrderDetail[]> _orderDetails;
            public Order()
            {
                _orderDetails = new Lazy<OrderDetail[]>(() => GetOrderDetailsForOrder(OrderID));
            }
            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime ShippedDate { get; set; }
            public OrderDetail[] OrderDetails { get { return _orderDetails.Value; } }
        }

        public class Customer
        {
            private Lazy<Order[]> _orders;
            public Customer()
            {
                _orders = new Lazy<Order[]>(() => GetOrdersForCustomer(CustomerID));
            }
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
            public Order[] Orders
            {
                get
                {
                    return _orders.Value;
                }
            }
        }

        public class Product
        {
            public string ProductName { get; set; }
            public int ProductID { get; set; }
            public double UnitPrice { get; set; }
        }

        public class OrderDetail
        {
            public int OrderID { get; set; }
            public int ProductID { get; set; }
            public double UnitPrice { get; set; }
            public double Quantity { get; set; }
            public double Discount { get; set; }
        }
        #endregion

        public static IEnumerable<string> GetCustomersAsStrings()
        {
            return System.IO.File.ReadAllLines(@"..\..\plinqdata.csv")
                                            .SkipWhile((line) => line.StartsWith("CUSTOMERS") == false)
                                             .Skip(1)
                                            .TakeWhile((line) => line.StartsWith("END CUSTOMERS") == false);
        }

        public static IEnumerable<Customer> GetCustomers()
        {
            var customers = System.IO.File.ReadAllLines(@"..\..\plinqdata.csv")
                                             .SkipWhile((line) => line.StartsWith("CUSTOMERS") == false)
                                             .Skip(1)
                                             .TakeWhile((line) => line.StartsWith("END CUSTOMERS") == false);
            return (from line in customers
                    let fields = line.Split(',')
                    let custID = fields[0].Trim()
                    select new Customer()
                    {
                        CustomerID = custID,
                        CustomerName = fields[1].Trim(),
                        Address = fields[2].Trim(),
                        City = fields[3].Trim(),
                        PostalCode = fields[4].Trim()
                    });
        }

        public static Order[] GetOrdersForCustomer(string id)
        {
            // Assumes we copied the file correctly!
            var orders = System.IO.File.ReadAllLines(@"..\..\plinqdata.csv")
                                             .SkipWhile((line) => line.StartsWith("ORDERS") == false)
                                              .Skip(1)
                                            .TakeWhile((line) => line.StartsWith("END ORDERS") == false);
            var orderStrings = from line in orders
                               let fields = line.Split(',')
                               where fields[1].CompareTo(id) == 0
                               select new Order()
                               {
                                   OrderID = Convert.ToInt32(fields[0]),
                                   CustomerID = fields[1].Trim(),
                                   OrderDate = DateTime.Parse(fields[2]),
                                   ShippedDate = DateTime.Parse(fields[3])
                               };
            return orderStrings.ToArray();
        }

        //  "10248, VINET, 7/4/1996 12:00:00 AM, 7/16/1996 12:00:00 AM
        public static IEnumerable<Order> GetOrders()
        {
            // Assumes we copied the file correctly!
            var orders = System.IO.File.ReadAllLines(@"..\..\plinqdata.csv")
                                            .SkipWhile((line) => line.StartsWith("ORDERS") == false)
                                             .Skip(1)
                                            .TakeWhile((line) => line.StartsWith("END ORDERS") == false);
            return from line in orders
                   let fields = line.Split(',')

                   select new Order()
                   {
                       OrderID = Convert.ToInt32(fields[0]),
                       CustomerID = fields[1].Trim(),
                       OrderDate = DateTime.Parse(fields[2]),
                       ShippedDate = DateTime.Parse(fields[3])
                   };
        }

        public static IEnumerable<Product> GetProducts()
        {
            // Assumes we copied the file correctly!
            var products = System.IO.File.ReadAllLines(@"..\..\plinqdata.csv")
                                            .SkipWhile((line) => line.StartsWith("PRODUCTS") == false)
                                             .Skip(1)
                                            .TakeWhile((line) => line.StartsWith("END PRODUCTS") == false);
            return from line in products
                   let fields = line.Split(',')
                   select new Product()
                   {
                       ProductID = Convert.ToInt32(fields[0]),
                       ProductName = fields[1].Trim(),
                       UnitPrice = Convert.ToDouble(fields[2])

                   };
        }

        public static IEnumerable<OrderDetail> GetOrderDetails()
        {
            // Assumes we copied the file correctly!
            var orderDetails = System.IO.File.ReadAllLines(@"..\..\plinqdata.csv")
                                            .SkipWhile((line) => line.StartsWith("ORDER DETAILS") == false)
                                             .Skip(1)
                                            .TakeWhile((line) => line.StartsWith("END ORDER DETAILS") == false);

            return from line in orderDetails
                   let fields = line.Split(',')
                   select new OrderDetail()
                   {
                       OrderID = Convert.ToInt32(fields[0]),
                       ProductID = Convert.ToInt32(fields[1]),
                       UnitPrice = Convert.ToDouble(fields[2]),
                       Quantity = Convert.ToDouble(fields[3]),
                       Discount = Convert.ToDouble(fields[4])
                   };
        }

        public static OrderDetail[] GetOrderDetailsForOrder(int id)
        {
            // Assumes we copied the file correctly!
            var orderDetails = System.IO.File.ReadAllLines(@"..\..\plinqdata.csv")
                                            .SkipWhile((line) => line.StartsWith("ORDER DETAILS") == false)
                                             .Skip(1)
                                            .TakeWhile((line) => line.StartsWith("END ORDER DETAILS") == false);

            var orderDetailStrings = from line in orderDetails
                                     let fields = line.Split(',')
                                     let ordID = Convert.ToInt32(fields[0])
                                     where ordID == id
                                     select new OrderDetail()
                                     {
                                         OrderID = ordID,
                                         ProductID = Convert.ToInt32(fields[1]),
                                         UnitPrice = Convert.ToDouble(fields[2]),
                                         Quantity = Convert.ToDouble(fields[3]),
                                         Discount = Convert.ToDouble(fields[4])
                                     };

            return orderDetailStrings.ToArray();
        }

        // Paste into PLINQDataSample class.
        static void OrderedThenUnordered()
        {
            Console.WriteLine();
            Console.WriteLine("OrderedThenUnordered");
            var orders = GetOrders();
            var orderDetails = GetOrderDetails();

            var q2 = orders.AsParallel()
               .Where(o => o.OrderDate < DateTime.Parse("07/04/1997"))
               .Select(o => o)
               .OrderBy(o => o.CustomerID) // Preserve original ordering for Take operation.
               .Take(20)
               .AsUnordered()  // Remove ordering constraint to make join faster.
               .Join(
                      orderDetails.AsParallel(),
                      ord => ord.OrderID,
                      od => od.OrderID,
                      (ord, od) =>
                      new
                      {
                          ID = ord.OrderID,
                          Customer = ord.CustomerID,
                          Product = od.ProductID
                      }
                     )
               .OrderBy(i => i.Product); // Apply new ordering to final result sequence.

            foreach (var v in q2)
                Console.WriteLine("{0} {1} {2}", v.ID, v.Customer, v.Product);

        }

        // Paste into PLINQDataSample class.
        static void SimpleOrdering()
        {
            Console.WriteLine();
            Console.WriteLine("SimpleOrdering");
            var customers = GetCustomers();

            // Take the first 20, preserving the original order
            var firstTwentyCustomers = customers
                                        .AsParallel()
                                        .AsOrdered()
                                        .Take(20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("First Twenty Customers");
            Console.ResetColor();
            foreach (var c in firstTwentyCustomers)
                Console.Write("{0} ", c.CustomerID);
            Console.WriteLine();

            // All elements in reverse order.
            var reverseOrder = customers
                                .AsParallel()
                                .AsOrdered()
                                .Reverse();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reverse Order");
            Console.ResetColor();
            foreach (var v in reverseOrder)
                Console.Write("{0} ", v.CustomerID);
            Console.WriteLine();

            // Get the element at a specified index. 
            var cust = customers.AsParallel()
                                .AsOrdered()
                                .ElementAt(48);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Element #48 is: {0}", cust.CustomerID);
            Console.ResetColor();
        }

        static void SequentialDemo()
        {
            Console.WriteLine();
            Console.WriteLine("SequentialDemo");
            var orders = GetOrders();
            var query = (from ord in orders.AsParallel()
                         orderby ord.CustomerID
                         select new
                         {
                             Details = ord.OrderID,
                             Date = ord.OrderDate,
                             Shipped = ord.ShippedDate
                         })
                         .AsSequential().Take(5);

            Console.WriteLine("Order results: ");
            foreach (var order in query.ToArray())
            {
                Console.WriteLine("ID: {0}, Date: {1}, Shipped: {2}", order.Details, order.Date, order.Shipped);
            }

            Console.WriteLine();
        }

        static void PLINQExceptions_1()
        {
            Console.WriteLine();
            Console.WriteLine("PLINQExceptions_1");
            // Using the raw string array here. See PLINQ Data Sample.
            string[] customers = GetCustomersAsStrings().ToArray();


            // First, we must simulate some currupt input.
            customers[45] = "###";

            var parallelQuery = from cust in customers.AsParallel()
                                let fields = cust.Split(',')
                                where fields[3].StartsWith("C") //throw indexoutofrange
                                select new { city = fields[3], thread = Thread.CurrentThread.ManagedThreadId };
            try
            {
                // We use ForAll although it doesn't really improve performance
                // since all output is serialized through the Console.
                parallelQuery.ForAll(e => Console.WriteLine("City: {0}, Thread:{1}", e.city, e.thread));
            }

            // In this design, we stop query processing when the exception occurs.
            catch (AggregateException e)
            {
                foreach (var ex in e.InnerExceptions)
                {
                    Console.WriteLine(ex.Message);
                    if (ex is IndexOutOfRangeException)
                        Console.WriteLine("The data source is corrupt. Query stopped.");
                }
            }
        }

        static void PLINQExceptions_2()
        {
            Console.WriteLine();
            Console.WriteLine("PLINQExceptions_2");
            var customers = GetCustomersAsStrings().ToArray();
            // Using the raw string array here.
            // First, we must simulate some currupt input
            customers[45] = "###";

            // Create a delegate with a lambda expression.
            // Assume that in this app, we expect malformed data
            // occasionally and by design we just report it and continue.
            Func<string[], string, bool> isTrue = (f, c) =>
            {
                try
                {
                    string s = f[3];
                    return s.StartsWith(c);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Malformed cust: {0}", f);
                    return false;
                }
            };

            // Using the raw string array here
            var parallelQuery = from cust in customers.AsParallel()
                                let fields = cust.Split(',')
                                where isTrue(fields, "C") //use a named delegate with a try-catch
                                select new { city = fields[3] };
            try
            {
                // We use ForAll although it doesn't really improve performance
                // since all output must be serialized through the Console.
                parallelQuery.ForAll(e => Console.WriteLine(e.city));
            }

            // IndexOutOfRangeException will not bubble up      
            // because we handle it where it is thrown.
            catch (AggregateException e)
            {
                foreach (var ex in e.InnerExceptions)
                    Console.WriteLine(ex.Message);
            }
        }
    }
}
