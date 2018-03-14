using DataTypes;

namespace CheckoutService
{
    public class CheckoutController
    {
        public delegate void CheckoutDelegate(Order order);
        public CheckoutDelegate CheckoutProcessing = null;

        private bool RequestPayment()
        {
            // Payment processing goes here

            // Payment logic is not implemented in this example
            // - simply return true
            return true;
        }

        public void StartCheckoutProcessing(Order order)
        {
            // Perform the checkout processing
            if (RequestPayment())
            {
                if (CheckoutProcessing != null)
                {
                    CheckoutProcessing(order);
                }
            }
        }
    }
}
