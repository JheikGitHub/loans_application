using LoansApplication.API.Models;

namespace LoansApplication.API.ViewModels
{
    public class LoanViewModel
    {
        public IEnumerable<LoanTypeViewModel> LoanTypes { get; set; }

        public static LoanViewModel ToLoanViewModel(IEnumerable<LoanType> loanTypes)
        {
            return new LoanViewModel
            {
                LoanTypes = loanTypes
                .Select(x => new LoanTypeViewModel
                {
                    Type = x.Type,
                    InterestRate = x.InterestRate
                })
            };
        }
    }
}
