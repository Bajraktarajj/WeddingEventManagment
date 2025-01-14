using Domain.Models;
using Presistent;
using Service.Interfaces;

namespace Service.Services
{
    public class ContactService : IContactService
    {
        private readonly WeedingEventManagmentDbContext _context;

        // Constructor to initialize the context via Dependency Injection
        public ContactService(WeedingEventManagmentDbContext context)
        {
            _context = context; // Initializes the private _context field with the provided DbContext instance
        }

        // Method to add contact to the database asynchronously
        public async Task AddContactAsync(Contact contact, CancellationToken cancellationToken)
        {
            // Add the contact entity to the context
            _context.Contacts.Add(contact);

            // Save changes asynchronously to persist the contact in the database
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
