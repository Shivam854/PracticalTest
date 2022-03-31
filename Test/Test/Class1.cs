using MediatR;
using Test.Data.Models;
using Test.Data.Response;
using Test.Domain.Commands;

namespace Test
{
    public class Class1
    {
        private readonly IMediator _mediator;

        public Class1(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public async Task<AddToCartResponse> AddProductAToCart(Guid customerId,
            Guid productId,
            int quantity,
            double price)
        {
            var command = new AddToCartCommand(customerId, productId, quantity, price);
            var response = await _mediator.Send(command);

            return response;
        }

        public async Task<List<CustomerCart>> GetCartByCustomer(Guid customerId)
        {
            var query = new GetCartByCustomerQuery(customerId);
            var response = await _mediator.Send(query);

            return response;
        }
    }
}