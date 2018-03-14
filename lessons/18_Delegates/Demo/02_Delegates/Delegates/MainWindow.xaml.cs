using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using DataTypes;
using AuditService;
using DeliveryService;
using CheckoutService;

namespace Delegates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductsDataSource _data;
        private Order _order;
        private readonly Auditor _auditor;
        private readonly Shipper _shipper;
        private readonly CheckoutController _checkoutController;

        public MainWindow()
        {
            InitializeComponent();

            _auditor = new Auditor();
            _shipper = new Shipper();
            _checkoutController = new CheckoutController();
            _checkoutController.CheckoutProcessing += _auditor.AuditOrder;
            _checkoutController.CheckoutProcessing += _shipper.ShipOrder;

            _auditor.AuditProcessingComplete += DisplayMessage;
            _shipper.ShipProcessingComplete += DisplayMessage;
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            _data = new ProductsDataSource();
            productList.DataContext = _data.Products;

            _order = new Order { Date = DateTime.Now, Items = new List<OrderItem>(), OrderId = Guid.NewGuid(), TotalValue = 0 };
        }

        private void AddProductToOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                // Find the product ID of the selected product (contained in the Tag property of the button)
                Button addButton = sender as Button;
                string productId = addButton.Tag as string;

                // Display the list view header if it is not already visible
                listViewHeader.Visibility = Visibility.Visible;

                // Enable the checkout button if it is not already enabled
                checkout.IsEnabled = true;

                // Check to see whether this product has already been added to the order
                OrderItem orderItem = _order.Items.Find(o => o.Item.ProductID == productId);
                if (orderItem != null)
                {
                    // If the product is already included the order just increment the quantity
                    orderItem.Quantity++;

                    // Update the total value of the order
                    _order.TotalValue += orderItem.Item.Price;
                }
                else
                {
                    // If the product has not previously been included in the order then add it

                    // First, find the details of the product
                    Product product = _data.Products.Find(p => p.ProductID == productId);

                    // Create an OrderItem that references this product and set the Quatity to 1
                    orderItem = new OrderItem { Item = product, Quantity = 1 };

                    // Add the OrderItem to the Order
                    _order.Items.Add(orderItem);

                    // Update the total value of the order
                    _order.TotalValue += product.Price;
                }

                // Rebind the ListView to the order data to update the display
                orderDetails.DataContext = null;
                orderDetails.DataContext = _order.Items;

                // Display the total order value
                orderValue.Text = String.Format("{0:C}", _order.TotalValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void CheckoutButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                // Perform the checkout processing
                _checkoutController.StartCheckoutProcessing(_order);
                                 
                // Clear out the order details so the user can start again with a new order
                _order = new Order { Date = DateTime.Now, Items = new List<OrderItem>(), OrderId = Guid.NewGuid(), TotalValue = 0 };
                orderDetails.DataContext = null;
                orderValue.Text = String.Format("{0:C}", _order.TotalValue);
                listViewHeader.Visibility = Visibility.Collapsed;
                checkout.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void DisplayMessage(string message)
        {
            messageBar.Text += message + "\n";
        }
    }
}
