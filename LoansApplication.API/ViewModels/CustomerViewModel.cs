using LoansApplication.API.Models;

namespace LoansApplication.API.ViewModels
{
    public class CustomerViewModel
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }
        public decimal Income { get; set; }
        public string Location { get; set; }

        public static CustomerViewModel ToCustomerViewModel(Customer customer)
        {
            return new CustomerViewModel
            {
                Name = customer.Name,
                CPF = customer.CPF,
                Age = customer.Age,
                Income = customer.Income,
                Location = customer.Location
            };
        }
    }
}
