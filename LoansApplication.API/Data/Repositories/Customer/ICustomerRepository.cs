using LoansApplication.API.Data.Repositories.Shared;

namespace LoansApplication.API.Data.Repositories.Customer
{
    public interface ICustomerRepository
        : IRepositoryBase<Models.Customer>
    {
        Task<bool> CustomerExists(int id);
    }
}
