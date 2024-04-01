using LoansApplication.API.Models;

namespace LoansApplication.Test._Builders
{
    public class CustomerBuilder
    {
        public CustomerBuilder()
        {

        }

        private readonly string _name = "Vuxaywua Zukiagou";
        private readonly string _cpf = "275.484.389-23";
        private int _age = 26;
        private decimal _income = 3000;
        private string _location = "MG";

        public Customer Builder()
        {
            return new Customer(_name, _cpf, _age, _income, _location);
        }

        public CustomerBuilder SetIncome(decimal income)
        {
            _income = income;
            return this;
        }

        public CustomerBuilder SetAge(int age)
        {
            _age = age;
            return this;
        }

        public CustomerBuilder SetLocation(string location)
        {
            _location = location;
            return this;
        }
    }
}
