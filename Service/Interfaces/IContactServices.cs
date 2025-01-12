namespace Service.Interfaces
{
    public interface IContactService
    {
        Task AddContactAsync(Contact contact, CancellationToken cancellationToken);
    }
}
