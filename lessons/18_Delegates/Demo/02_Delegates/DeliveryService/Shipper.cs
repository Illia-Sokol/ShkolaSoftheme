using System;
using System.Windows;
using DataTypes;
using System.IO;

namespace DeliveryService
{
    public class Shipper
    {
        public delegate void ShippingCompleteDelegate(string message);
        public event ShippingCompleteDelegate ShipProcessingComplete;

        public void ShipOrder(Order order)
        {
            DoShipping(order);
        }

        private void DoShipping(Order order)
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var seperator = Path.DirectorySeparatorChar;
                var file = File.Create(path + seperator + "dispatch-" + order.OrderId + ".txt");

                var dispatchNote = "Order Summary: " +
                                    "\r\nOrder ID: " + order.OrderId +
                                    "\r\nOrder Total: " + string.Format("{0:C}", order.TotalValue);

                var writer = new StreamWriter(file);
                writer.Write(dispatchNote);
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally
            {
                if (ShipProcessingComplete != null)
                {
                    ShipProcessingComplete(string.Format("Dispatch note generated for Order {0}", order.OrderId));
                }
            }

        }
    }
}
