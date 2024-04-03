using LoansApplication.API.Data.Repositories.Shared;
using LoansApplication.API.ViewModels;

namespace LoansApplication.API.Data.Repositories.Loan
{
    public interface ILoanRepository : IRepositoryBase<Models.Loan>
    {
        Task<CustomerLoanViewModel> GetLoanByCustomerId(int customerId);
    }
}
