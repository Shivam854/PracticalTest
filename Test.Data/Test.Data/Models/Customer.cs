using System.ComponentModel.DataAnnotations;

namespace Test.Data.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }
    }

    public class CustomerViewModel
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> data = new List<Customer>();
            data.Add(new Customer()
            {
                Address = "Test",
                Id = Guid.Parse("FB983F8E-E9BD-4A4E-94A5-7568F935AEF2"),
                Name = "Shivam"
            });

            data.Add(new Customer()
            {
                Address = "Test",
                Id = Guid.Parse("FB983F8E-E9BD-4A4E-94A5-7568F935AEF1"),
                Name = "Roman"
            });

            return data;
        }
    }
}