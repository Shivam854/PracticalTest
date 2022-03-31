using MediatR;
using Test.Data.Models;
using Test.Data.Repositories;

namespace Test.Domain.Commands
{
    public class GetCartByCustomerQuery : IRequest<List<CustomerCart>>
    {
        public GetCartByCustomerQuery(Guid customerId)
        {
            CustomerID = customerId;
        }

        public Guid CustomerID { get; set; }
    }

    public class GetCartByCustomerQueryHandler : IRequestHandler<GetCartByCustomerQuery, List<CustomerCart>>
    {
        private readonly ICustomerCartRepository _customerCartRepository;

        public GetCartByCustomerQueryHandler(ICustomerCartRepository customerCartRepository)
        {
            this._customerCartRepository = customerCartRepository;
        }

        public async Task<List<CustomerCart>> Handle(GetCartByCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _customerCartRepository.GetCartByCustomer(request.CustomerID);
        }
    }
}