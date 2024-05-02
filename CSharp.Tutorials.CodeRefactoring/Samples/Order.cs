namespace CSharp.Tutorials.CodeRefactoring.Samples
{
	public class Order
    {
        public Customer Customer { get; set; }

        public List<Product> Products { get; set; }

        public Address Address { get; set; }

        public bool IsValid { get; set; }
    }
}