using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ILogger<TicketsController> _logger;
        private readonly IConfiguration _configuration;

        public TicketsController(ILogger<TicketsController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from Tickets Controller - GET()");
        }

        [HttpPost]
        public IActionResult Post(Ticket ticket)
        {
            //Validation
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            return Ok("Hello from Contacts Controller - POST()");
        }
    }
}
