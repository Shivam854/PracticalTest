using Test.Data.Models;
using Test.Data.Response;

namespace Test.Data.Repositories
{
    public class CustomerCartRepository : ICustomerCartRepository
    {
        public Task<AddToCartResponse> AddProductToCart(CustomerCart model)
        {
            // Checking
            return Task.FromResult(new AddToCartResponse()
            {
                Id = Guid.NewGuid(),
                message = "Success"
            });
        }

        public Task<List<CustomerCart>> GetCartByCustomer(Guid customerId)
        {
            var result = CustomerClassViewModel.GetCustomerCarts();
            return Task.FromResult(result.Where(cart => cart.CustomerId.Equals(customerId)).ToList());
        }
    }
}