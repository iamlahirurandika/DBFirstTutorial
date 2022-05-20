using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DBFirstTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly axienta_dbContext _context;

        //Create a constructor
        //Then inject context 
        //Then initialize context field 

        public ProductController(axienta_dbContext context)
        {
            _context = context;
        }

        //Http GET to get data
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(await _context.Products.ToListAsync()); 
        }
    }
}
