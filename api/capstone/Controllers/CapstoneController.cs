using capstone.Model;
using capstone.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace capstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapstoneController : ControllerBase
    {
        private readonly IDataRepository<Customer> _dataRepository;
        public CapstoneController(IDataRepository<Customer> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET: api/Employee
        [HttpGet]
        [Route("getcustomerdata")]
        public async Task<IEnumerable<Customer>> Get()
        {
            var customers = await _dataRepository.GetAll();
            return customers;
        }
        [HttpPost]
        [Route("validate-sim")]
        public async Task<string> ValidateSim([FromBody] Customer customer)
        {
            string result = await _dataRepository.Validate(customer);
            return result;
        }

        [HttpPost]
        [Route("validate-customer")]
        public async Task<string> Validatecustomer([FromBody] Customer customer)
        {
            string result = await _dataRepository.Validate(customer);
            return result;
        }
        [HttpPost]
        [Route("validate-customer-details")]
        public async Task<string> Validatecustomerdetails([FromBody] Customer customer)
        {
            string result = await _dataRepository.Validate(customer);
            return result;
        }
        [HttpPost]
        [Route("validate-id-proof")]
        public async Task<string> Validateidproof([FromBody] Customer customer)
        {
            string result = await _dataRepository.Validate(customer);
            return result;
        }

        [HttpPost]
        [Route("special-offers")]
        public async Task<IEnumerable<offers>> Specialoffers([FromBody] offers offers)
        {
            return await _dataRepository.GetAlloffers(offers.ServiceNumber,offers.SimNumber);
            
        }
    }
}
