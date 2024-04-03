using LoansApplication.API.Enums;
using System.Text.Json.Serialization;

namespace LoansApplication.API.ViewModels
{
    public class LoanTypeViewModel
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EloanType Type { get; set; }

        public double InterestRate { get; set; }
    }
}
