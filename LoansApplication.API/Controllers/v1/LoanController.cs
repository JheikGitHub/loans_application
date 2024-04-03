using LoansApplication.API.Data.Repositories.Loan;
using LoansApplication.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LoansApplication.API.Controllers.v1
{
    /// <summary>
    /// LoanController
    /// </summary>
    public class LoanController : ControllerBaseCustom
    {
        private readonly ILoanRepository _loanRepository;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="loanRepository"></param>
        public LoanController(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        /// <summary>
        /// Busca os emprestimos disponiveis para o cliente passando o id do cliente
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("customer_loan/{customerId}")]
        [ProducesResponseType<CustomerLoanViewModel>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLoanByCustomerId(int customerId)
        => Ok(await _loanRepository.GetLoanByCustomerId(customerId));
    }
}
