using LoansApplication.API.Enums;

namespace LoansApplication.API.Models
{
    public class Loan : EntityBase
    {
        protected Loan() { }

        public static IEnumerable<LoanType> CalculateLoan(Customer customer)
        {
            var listLoans = new List<LoanType>();

            if (customer.Income <= 3000)
                listLoans.Add(LoanType.GetTypeLoans().FirstOrDefault(x=>x.Type == EloanType.PERSONAL));

            if (customer.Income >= (decimal)3000.01
                && customer.Income <= 5000
                && customer.Age < 30
                && customer.Location.Equals("SP", StringComparison.InvariantCultureIgnoreCase))
                listLoans.Add(LoanType.GetTypeLoans().FirstOrDefault(x => x.Type == EloanType.PERSONAL));

            if (customer.Income >= 5000)
                listLoans.Add(LoanType.GetTypeLoans().FirstOrDefault(x => x.Type == EloanType.CONSIGNMENT));

            if (customer.Income <= 3000)
                listLoans.Add(LoanType.GetTypeLoans().FirstOrDefault(x => x.Type == EloanType.GUARANTEED));

            if (customer.Income >= 3000
                && customer.Income <= 5000
                && customer.Age < 30
                && customer.Location.Equals("SP", StringComparison.InvariantCultureIgnoreCase))
                listLoans.Add(LoanType.GetTypeLoans().FirstOrDefault(x => x.Type == EloanType.GUARANTEED));

            return listLoans;
        }
    }
}
