using Domain.Models; // Add this to reference the Contact model

namespace Service.Interfaces
{
    public interface IContactService
    {
        Task AddContactAsync(Contact contact, CancellationToken cancellationToken);
    }
}
