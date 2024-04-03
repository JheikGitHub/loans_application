using Microsoft.AspNetCore.Mvc;
using LoansApplication.API.Models;
using LoansApplication.API.Data.Repositories.Customer;
using LoansApplication.API.ViewModels;

namespace LoansApplication.API.Controllers.v1
{
    /// <summary>
    /// CustomerController
    /// </summary>

    public class CustomerController : ControllerBaseCustom
    {
        private readonly ICustomerRepository _customerRepository;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="customerRepository"></param>
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        /// <summary>
        /// Retorna todos os cliente cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet("customer/get_all")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return Ok(await _customerRepository.GetAllAsync());
        }

        /// <summary>
        /// Retorna um cliente buscando pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("customer/{id}")]
        [ProducesResponseType<CustomerLoanViewModel>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _customerRepository.GetAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        //// PUT: api/Customer/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCustomer(int id, Customer customer)
        //{
        //    if (id != customer.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(customer).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CustomerExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Customer
        //[HttpPost]
        //public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        //{
        //    _context.Customers.Add(customer);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        //}
    }
}
