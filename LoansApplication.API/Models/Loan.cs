using LoansApplication.API.Enums;
using System.Diagnostics.CodeAnalysis;

namespace LoansApplication.API.Models
{
    public class Loan : IEqualityComparer<Loan>
    {
        protected Loan() { }

        public EloanType Type { get; private set; }
        public double InterestRate { get; private set; }

        public static IEnumerable<Loan> GetTypeLoans()
        {
            return [
                    new(){ Type = EloanType.PERSONAL, InterestRate = 4},
                    new() {Type = EloanType.GUARANTEED, InterestRate = 3},
                    new() {Type = EloanType.CONSIGNMENT, InterestRate = 2},
                ];
        }

        public static IEnumerable<Loan> CalculateLoan(Customer customer)
        {
            var listLoans = new List<Loan>();

            if (customer.Income <= 3000)
                listLoans.Add(new Loan() { Type = EloanType.PERSONAL, InterestRate = 4 });

            if (customer.Income >= (decimal)3000.01
                && customer.Income <= 5000
                && customer.Age < 30
                && customer.Location.Equals("SP", StringComparison.InvariantCultureIgnoreCase))
                listLoans.Add(new Loan() { Type = EloanType.PERSONAL, InterestRate = 4 });

            if (customer.Income >= 5000)
                listLoans.Add(new Loan() { Type = EloanType.CONSIGNMENT, InterestRate = 2 });

            if (customer.Income <= 3000)
                listLoans.Add(new Loan() { Type = EloanType.GUARANTEED, InterestRate = 3 });

            if (customer.Income >= 3000
                && customer.Income <= 5000
                && customer.Age < 30
                && customer.Location.Equals("SP", StringComparison.InvariantCultureIgnoreCase))
                listLoans.Add(new Loan() { Type = EloanType.GUARANTEED, InterestRate = 3 });

            return listLoans;
        }

        public bool Equals(Loan? x, Loan? y)
        => x?.InterestRate == y?.InterestRate
            && x?.Type == y?.Type;

        public int GetHashCode([DisallowNull] Loan obj)
        => obj.Type.GetHashCode();
    }
}
