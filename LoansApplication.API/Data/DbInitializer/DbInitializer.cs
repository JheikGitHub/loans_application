using LoansApplication.API.Data.Context;
using LoansApplication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LoansApplication.API.Data.DbInitializer
{
    public class DbInitializer(DataContext context) : IDbInitializer
    {
        private readonly DataContext _context = context;

        public void Initialize()
        {
            _context.Database.Migrate();

            var isLoanTypes = _context.LoanTypes.Any();

            if (!isLoanTypes)
            {
                _context.LoanTypes.AddRange(LoanType.GetTypeLoans());
                _context.SaveChanges();
            }
        }
    }
}
