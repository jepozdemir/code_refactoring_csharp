using CSharp.Tutorials.CodeRefactoring.Samples;

namespace CSharp.Tutorials.CodeRefactoring
{
    class ExtractMethod
    {
		// After refactoring
		public static void ProcessOrder(Order order)
        {
			Console.WriteLine("Processing order by using seperated methods...");
			ValidateOrder(order);
            UpdateInventory(order);
            CalculateTotalPrice(order);
            NotifyCustomer(order);
        }

        static void ValidateOrder(Order order)
        {
            if (!order.IsValid)
            {
                throw new ArgumentException("Invalid order.");
            }
        }

        static void UpdateInventory(Order order)
        {
            foreach (var product in order.Products)
            {
                // Reduce inventory by 1 for each ordered product
                int updatedQuantity = product.AvailableQuantity - 1;

                // Ensure the updated quantity is non-negative
                updatedQuantity = Math.Max(updatedQuantity, 0);

                // Update the product's available quantity
                product.AvailableQuantity = updatedQuantity;

                // Print a message to simulate inventory update
                Console.WriteLine($"Inventory updated for product '{product.Name}': Available Quantity = {product.AvailableQuantity}");
            }
        }

        static void CalculateTotalPrice(Order order)
        {
            double totalPrice = order.Products.Sum(p => p.Price);
            totalPrice -= CalculateDiscount(order);
            Console.WriteLine($"Order Total: {totalPrice}");
        }

        static double CalculateDiscount(Order order)
        {
            double discount = 0;
            double totalPrice = order.Products.Sum(p => p.Price);

            // Check if the customer is a preferred customer and apply a discount if eligible
            if (order.Customer.IsPreferredCustomer)
            {
                // Apply a 10% discount for preferred customers
                discount = totalPrice * 0.1;
            }

            // Check if the order total exceeds a certain threshold and apply additional discount
            if (totalPrice >= 1000)
            {
                // Apply a $50 discount for orders totaling $1000 or more
                discount += 50;
            }
            else if (totalPrice >= 500)
            {
                // Apply a $20 discount for orders totaling $500 or more
                discount += 20;
            }

            // Ensure the discount does not exceed the order total
            discount = Math.Min(discount, totalPrice);

            return discount;
        }

        static void NotifyCustomer(Order order)
        {
            string shippingLabel = GenerateShippingLabel(order.Customer, order.Address);
            Console.WriteLine($"Sending notification to customer {order.Customer.Name}: Your order has been shipped. Shipping label: {shippingLabel}");
        }

        static string GenerateShippingLabel(Customer customer, Address address)
        {
            return $"Shipping label for {customer.Name} at {address.Street}, {address.City}, {address.ZipCode}";
        }
    }
}
