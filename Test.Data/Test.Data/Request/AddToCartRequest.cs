namespace Test.Data.Request
{
    public class AddToCartRequest
    {
        public Guid CustomerID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}