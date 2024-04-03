using LoansApplication.API.Data.Repositories.Customer;
using LoansApplication.API.Data.Repositories.Loan;
using LoansApplication.API.Data.Repositories.Shared;

namespace LoansApplication.API.Extensions.IoC
{
    public static class NativeInjectorConfig
    {
        public static WebApplicationBuilder AddRegisterServices(this WebApplicationBuilder builder)
        {

            return builder;
        }

        public static WebApplicationBuilder AddRegisterRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ILoanRepository, LoanRepository>();

            return builder;
        }
    }
}
