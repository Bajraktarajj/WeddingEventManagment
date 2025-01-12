using Service.Interfaces;
using Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Service.Services
{
    public class ContactService : IContactService
    {
        private readonly WeedingEventManagmentDbContext _context;

        public ContactService(WeedingEventManagmentDbContext context)
        {
            _context = context;
        }

        public async Task AddContactAsync(Contact contact, CancellationToken cancellationToken)
        {
            await _context.Contacts.AddAsync(contact, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
