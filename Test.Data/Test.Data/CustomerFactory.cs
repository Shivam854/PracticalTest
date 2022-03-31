using Test.Data.Models;
using Test.Data.Request;

namespace Test.Data
{
    public class CustomerFactory : ICustomerFactory
    {
        public CustomerCart ToCustomerCart(AddToCartRequest request)
        {
            if (request == null) return null;

            return new CustomerCart()
            {
                CustomerId = request.CustomerID,
                ProductId = request.ProductID,
                Price = request.Price,
                Quantity = request.Quantity,
                Id = Guid.NewGuid()
            };
        }

        public IEnumerable<CustomerCart> ToCustomerCartList(List<AddToCartRequest> request)
        {
            var customerCartList = new List<CustomerCart>();
            request.ForEach(customerCart => customerCartList.Add(ToCustomerCart(customerCart)));
            return customerCartList;
        }
    }
}