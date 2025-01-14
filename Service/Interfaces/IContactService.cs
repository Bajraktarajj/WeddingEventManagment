using Domain.Models;
using System.Threading.Tasks;
using System.Threading;

namespace Service.Interfaces
{
    public interface IContactService
    {
        // Method to add a contact to the database asynchronously
        Task AddContactAsync(Contact contact, CancellationToken cancellationToken);
    }
}
