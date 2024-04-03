using LoansApplication.API.Enums;

namespace LoansApplication.API.Models
{
    public class LoanType
    {
        public int Id { get; private set; }
        public EloanType Type { get; private set; }
        public double InterestRate { get; private set; }

        public static IEnumerable<LoanType> GetTypeLoans()
        {
            return [
                    new() { Type = EloanType.PERSONAL, InterestRate = 4},
                    new() { Type = EloanType.GUARANTEED, InterestRate = 3},
                    new() { Type = EloanType.CONSIGNMENT, InterestRate = 2},
                ];
        }
    }
}
