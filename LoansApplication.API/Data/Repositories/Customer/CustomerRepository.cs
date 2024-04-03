using LoansApplication.API.Data.Context;
using LoansApplication.API.Data.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace LoansApplication.API.Data.Repositories.Customer
{
    public class CustomerRepository :
        RepositoryBase<Models.Customer>,
        ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
            : base(context) 
        { 
            _context = context;
        }

        public async Task<bool> CustomerExists(int id)
        {
            return await _context.Customers.AnyAsync(e => e.Id == id);
        }
    }
}
