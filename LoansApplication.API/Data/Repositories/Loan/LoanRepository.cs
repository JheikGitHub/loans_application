using LoansApplication.API.Data.Context;
using LoansApplication.API.Data.Repositories.Customer;
using LoansApplication.API.Data.Repositories.Shared;
using LoansApplication.API.ViewModels;

namespace LoansApplication.API.Data.Repositories.Loan
{
    public class LoanRepository : RepositoryBase<Models.Loan>, ILoanRepository
    {
        private readonly ICustomerRepository _customerRepository;
        public LoanRepository(DataContext context, ICustomerRepository customerRepository)
            : base(context)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerLoanViewModel> GetLoanByCustomerId(int customerId)
        {
            var customer = await _customerRepository.GetAsync(customerId);

            var loanTypes = Models.Loan.CalculateLoan(customer);

            return new CustomerLoanViewModel
            {
                Customer = CustomerViewModel.ToCustomerViewModel(customer),
                Loan = LoanViewModel.ToLoanViewModel(loanTypes)
            };
        }
    }
}
