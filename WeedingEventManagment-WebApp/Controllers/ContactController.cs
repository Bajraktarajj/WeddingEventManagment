using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Models;

namespace WeedingEventManagment_WebApp.Controllers
{
    [ApiController]
    [Route("contact")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost("submit")]
        public async Task<IActionResult> SubmitContact(Contact contact, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _contactService.AddContactAsync(contact, cancellationToken);
            return Ok("Contact form submitted successfully.");
        }
    }
}