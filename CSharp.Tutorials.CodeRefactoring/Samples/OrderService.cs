namespace CSharp.Tutorials.CodeRefactoring.Samples
{
    class OrderService
    {
        // Before refactoring
        public static void ProcessOrder(Order order)
        {
			Console.WriteLine("Processing order before refactoring...");

			// Step 1: Validate order
			if (!order.IsValid)
            {
                throw new ArgumentException("Invalid order.");
            }

            // Step 2: Update inventory
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

            // Step 3: Calculate total price
            double totalPrice = order.Products.Sum(p => p.Price);
            double discount = 0;

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

            totalPrice -= discount;
            Console.WriteLine($"Order Total: {totalPrice}");

            // Step 4: Generate shipping label
            string shippingLabel = $"Shipping label for {order.Customer.Name} at {order.Address.Street}, {order.Address.City}, {order.Address.ZipCode}";

            // Step 5: Notify customer
            Console.WriteLine($"Sending notification to customer {order.Customer.Name}: Your order has been shipped. Shipping label: {shippingLabel}");
        }

		public static Order GetOrder()
		{
			var order = new Order { IsValid = true };
			order.Customer = new Customer { Name = "Jiyan Epözdemir" };
			order.Address = new Address { Street = "Baker Street", City = "London", ZipCode = "111" };
			order.Products = new List<Product>
			{
				new Product {Name="Product 1", Price=10, AvailableQuantity=10},
				new Product {Name="Product 2", Price=20, AvailableQuantity=20},
				new Product {Name="Product 3", Price=30, AvailableQuantity=30},
				new Product {Name="Product 4", Price=40, AvailableQuantity=40}
			};
			return order;
		}
	}
}
