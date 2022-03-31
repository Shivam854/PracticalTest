using MediatR;
using Test.Data;
using Test.Data.Repositories;
using Test.Data.Request;
using Test.Data.Response;

namespace Test.Domain.Commands
{
    public class AddToCartCommand : IRequest<AddToCartResponse>
    {
        public AddToCartCommand(Guid customerId,
            Guid productId,
            int quantity,
            double price)
        {
            CustomerID = customerId;
            ProductID = productId;
            Quantity = quantity;
            Price = price;
        }

        public Guid CustomerID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public class AddToCartCommandHandler : IRequestHandler<AddToCartCommand, AddToCartResponse>
    {
        private readonly ICustomerCartRepository _customerCartRepository;
        private readonly ICustomerFactory _customerFactory;

        public AddToCartCommandHandler(ICustomerCartRepository customerCartRepository,
            ICustomerFactory customerFactory)
        {
            this._customerCartRepository = customerCartRepository;
            this._customerFactory = customerFactory;
        }

        public async Task<AddToCartResponse> Handle(AddToCartCommand request, CancellationToken cancellationToken)
        {
            var requestModel = new AddToCartRequest()
            {
                CustomerID = request.CustomerID,
                ProductID = request.ProductID,
                Quantity = request.Quantity,
                Price = request.Price
            };
            var model = _customerFactory.ToCustomerCart(requestModel);
            return await _customerCartRepository.AddProductToCart(model);
        }
    }
}