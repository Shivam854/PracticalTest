using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Test.Data;
using Test.Data.Repositories;
using Test.Domain.Commands;
using Xunit.Microsoft.DependencyInjection;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace Test.IntegrationTest
{
    public class TestFixture : TestBedFixture
    {
        protected override void AddServices(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration? configuration)
        {
            services.AddMediatR(typeof(GetCartByCustomerQuery).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(AddToCartCommand).GetTypeInfo().Assembly);
            services.AddTransient<ICustomerCartRepository, CustomerCartRepository>();
            services.AddTransient<ICustomerFactory, CustomerFactory>();
        }

        protected override ValueTask DisposeAsyncCore()
            => new();

        [Obsolete]
        protected override IEnumerable<string> GetConfigurationFiles()
        {
            yield return "appsettings.json";
        }

        protected override IEnumerable<TestAppSettings> GetTestAppSettings()
        {
            yield return new() { Filename = "appsettings.json", IsOptional = true };
        }
    }
}