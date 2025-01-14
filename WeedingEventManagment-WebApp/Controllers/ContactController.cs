using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Domain.Models;

namespace WeedingEventManagment_WebApp.Controllers
{
    //[ApiController]
    //[Route("contact")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitContact(Contact contact, CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _contactService.AddContactAsync(contact, cancellationToken);
            return RedirectToAction(controllerName: nameof(HomeController), actionName: nameof(Index));
        }
    }
}