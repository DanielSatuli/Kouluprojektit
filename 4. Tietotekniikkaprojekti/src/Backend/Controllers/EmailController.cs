using Microsoft.AspNetCore.Mvc;
using EmailService;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : Controller
    {
        private readonly IEmailSender _emailSender;
        public EmailController(IEmailSender emailSender) {
            _emailSender = emailSender;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var message = new Message("eetu.nykanen@gmail.com", "Test email", "This is the content from our email.");
            await _emailSender.SendEmailAsync(message);

            return Ok();
        }
    }
}
