using System.ComponentModel.DataAnnotations;

namespace Test.Data.Models
{
    public class CustomerCart
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public static class CustomerClassViewModel
    {
        public static List<CustomerCart> GetCustomerCarts()
        {
            List<CustomerCart> data = new List<CustomerCart>();
            data.Add(new CustomerCart()
            {
                Id = Guid.NewGuid(),
                CustomerId = Guid.Parse("FB983F8E-E9BD-4A4E-94A5-7568F935AEF2"),
                Price = 4000,
                ProductId = Guid.Parse("8EC57A26-BADE-4E62-A36E-6B34B279ADF2"),
                Quantity = 20
            });
            data.Add(new CustomerCart()
            {
                Id = Guid.NewGuid(),
                CustomerId = Guid.Parse("FB983F8E-E9BD-4A4E-94A5-7568F935AEF2"),
                Price = 4000,
                ProductId = Guid.Parse("8EC57A26-BADE-4E62-A36E-6B34B279ADF1"),
                Quantity = 20
            });

            return data;
        }
    }
}