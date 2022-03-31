using Test.Data.Models;
using Test.Data.Response;

namespace Test.Data.Repositories
{
    public interface ICustomerCartRepository
    {
        public Task<AddToCartResponse> AddProductToCart(CustomerCart model);

        public Task<List<CustomerCart>> GetCartByCustomer(Guid customerId);
    }
}