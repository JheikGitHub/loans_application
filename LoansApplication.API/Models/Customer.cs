namespace LoansApplication.API.Models
{
    public class Customer : EntityBase
    {
        protected Customer() { }

        public Customer(
            string name,
            string cPF,
            int age,
            decimal income,
            string location)
        {
            Name = name;
            CPF = cPF;
            Age = age;
            Income = income;
            Location = location;
        }

        public string? Name { get; private set; }
        public string? CPF { get; private set; }
        public int Age { get; private set; }
        public decimal Income { get; private set; }
        public string? Location { get; private set; }

    }
}
