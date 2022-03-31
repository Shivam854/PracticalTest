using System.ComponentModel.DataAnnotations;

namespace Test.Data.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }
    }

    public static class ProductViewModel
    {
        public static List<Product> GetProducts()
        {
            List<Product> data = new List<Product>();
            data.Add(
                new Product()
                {
                    Name = "A",
                    Description = "Test",
                    Id = Guid.Parse("8EC57A26-BADE-4E62-A36E-6B34B279ADF2")
                });

            data.Add(
                new Product()
                {
                    Name = "B",
                    Description = "Test",
                    Id = Guid.Parse("8EC57A26-BADE-4E62-A36E-6B34B279ADF1")
                });

            return data;
        }
    }
}