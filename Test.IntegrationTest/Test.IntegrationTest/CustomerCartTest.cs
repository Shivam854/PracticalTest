using MediatR;
using Test.Data.Models;
using Test.Domain.Commands;
using Xunit;
using Xunit.Abstractions;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace Test.IntegrationTest
{
    public class CustomerCartTest : TestBed<TestFixture>
    {
        private readonly IMediator _mediator;

        public CustomerCartTest(ITestOutputHelper testOutputHelper, TestFixture fixture)
            : base(testOutputHelper, fixture)
        {
            _mediator = _fixture.GetService<IMediator>(testOutputHelper);
        }

        [Theory]
        [InlineData("FB983F8E-E9BD-4A4E-94A5-7568F935AEF2", "8EC57A26-BADE-4E62-A36E-6B34B279ADF2", 1, 100)]
        public async Task AddProductAToCartAsync(Guid customerId,
            Guid productId,
            int quantity,
            double price)
        {
            // Arrange
            var command = new AddToCartCommand(customerId, productId, quantity, price);

            // Act
            var response = await _mediator.Send(command);

            // Assert
            Assert.NotNull(response);
        }

        [Theory]
        [InlineData("FB983F8E-E9BD-4A4E-94A5-7568F935AEF2", "8EC57A26-BADE-4E62-A36E-6B34B279ADF1", 1, 100)]
        public async Task AddProductBToCartAsync(Guid customerId,
            Guid productId,
            int quantity,
            double price)
        {
            // Arrange
            var command = new AddToCartCommand(customerId, productId, quantity, price);

            // Act
            var response = await _mediator.Send(command);

            // Assert
            Assert.NotNull(response);
        }

        [Theory]
        [InlineData("FB983F8E-E9BD-4A4E-94A5-7568F935AEF2")]
        public async Task GetCartDetalsByCustomer(Guid cusotmerId)
        {
            // Arrange
            var query = new GetCartByCustomerQuery(cusotmerId);

            // Act
            List<CustomerCart> response = await _mediator.Send(query);

            // Assert
            Assert.Equal(2, response.Count);
        }
    }
}