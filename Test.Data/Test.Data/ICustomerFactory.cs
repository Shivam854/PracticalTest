using Test.Data.Models;
using Test.Data.Request;

namespace Test.Data
{
    public interface ICustomerFactory
    {
        public CustomerCart ToCustomerCart(AddToCartRequest request);

        public IEnumerable<CustomerCart> ToCustomerCartList(List<AddToCartRequest> request);
    }
}