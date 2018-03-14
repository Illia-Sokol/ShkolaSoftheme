using System;
using System.Windows;
using System.Collections.Generic;
using DataTypes;
using System.IO;
using System.Xml;

namespace AuditService
{
    public class Auditor
    {
        public delegate void AuditingCompleteDelegate(string message);
        public event AuditingCompleteDelegate AuditProcessingComplete;

        public void AuditOrder(Order order)
        {
            DoAuditing(order);
        }

        private void DoAuditing(Order order)
        {
            List<OrderItem> ageRestrictedItems = FindAgeRestrictedItems(order);
            if (ageRestrictedItems.Count > 0)
            {
                try
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    char seperator = Path.DirectorySeparatorChar;
                    FileStream file = File.Create(path + seperator + "audit-" + order.OrderId + ".xml");

                    XmlDocument doc = new XmlDocument();
                    XmlElement root = doc.CreateElement("Order");
                    root.SetAttribute("ID", order.OrderId.ToString());
                    root.SetAttribute("Date", order.Date.ToString());

                    foreach (OrderItem orderItem in ageRestrictedItems)
                    {
                        XmlElement itemElement = doc.CreateElement("Item");
                        itemElement.SetAttribute("Product", orderItem.Item.Name);
                        itemElement.SetAttribute("Description", orderItem.Item.Description);
                        root.AppendChild(itemElement);
                    }

                    doc.AppendChild(root);

                    doc.Save(file);
                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
                finally
                {
                    if (AuditProcessingComplete != null)
                    {
                        AuditProcessingComplete(string.Format("Audit record written for Order {0}", order.OrderId));
                    }
                }
            }
        }

        private List<OrderItem> FindAgeRestrictedItems(Order order)
        {
            return order.Items.FindAll(o => o.Item.AgeRestricted);
        }
    }
}
