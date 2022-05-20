using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DBFirstTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly axienta_dbContext _context;

        public CustomerController(axienta_dbContext context)
        {
            _context = context;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            return Ok(await _context.Customers.ToListAsync());
        }
        /*

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */ 
    }
}
