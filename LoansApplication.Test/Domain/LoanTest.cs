using LoansApplication.API.Enums;
using LoansApplication.API.Models;
using LoansApplication.Test._Builders;

namespace LoansApplication.Test.Domain
{
    public  class LoanTest
    {
        private readonly CustomerBuilder _customerBuilder;
        public LoanTest()
        {
            _customerBuilder = new CustomerBuilder();
        }

        [Fact]
        public void Deve_Conceder_Emprestimo_Pessoal_Salario_Menor_Ou_Igual_TresMil()
        {
            Customer customer = _customerBuilder.SetIncome(3000).Builder();

            var listActual = Loan.CalculateLoan(customer);

            Assert.NotNull(listActual);
            Assert.Contains(listActual, x => x.Type == EloanType.PERSONAL);
        }

        [Fact]
        public void Deve_Conceder_Emprestimo_Pessoal_Salario_Entre_Tres_Mil_E_Cinco_Mil_E_Menos_30_Anos_E_Residir_SP()
        {
            Customer customer = _customerBuilder.SetIncome(4500).SetAge(29).SetLocation("SP").Builder();

            var listActual = Loan.CalculateLoan(customer);

            Assert.NotNull(listActual);
            Assert.Contains(listActual, x => x.Type == EloanType.PERSONAL);
        }

        [Fact]
        public void Deve_Conceder_Emprestimo_Consignado_Salario_Maior_Ou_Igual_Cinco_Mil()
        {
            Customer customer = _customerBuilder.SetIncome(7000).Builder();

            var listActual = Loan.CalculateLoan(customer);

            Assert.NotNull(listActual);
            Assert.Contains(listActual, x => x.Type == EloanType.CONSIGNMENT);
        }

        [Fact]
        public void Deve_Conceder_Emprestimo_Garantia_Salario_Menor_Ou_Igual_Tres_Mil()
        {
            Customer customer = _customerBuilder.SetIncome(1500).Builder();

            var listActual = Loan.CalculateLoan(customer);

            Assert.NotNull(listActual);
            Assert.Contains(listActual, x => x.Type == EloanType.GUARANTEED);
        }

        [Fact]
        public void Deve_Conceder_Emprestimo_Garantia_Salario_Entre_Tres_Mil_E_Cinco_Mil_E_Menos_30_Anos_E_Residir_SP()
        {
            Customer customer = _customerBuilder.SetIncome(4500).SetAge(29).SetLocation("SP").Builder();

            var listActual = Loan.CalculateLoan(customer);

            Assert.NotNull(listActual);
            Assert.Contains(listActual, x => x.Type == EloanType.GUARANTEED);
        }
    }
}
