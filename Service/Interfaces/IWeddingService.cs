using Domain.Models;

namespace Service.Interfaces
{
    public interface IWeddingService
    {
        Task<Wedding> GetById(int id, CancellationToken cancellationToken);

        Task<List<Wedding>> GetAll(CancellationToken cancellationToken);
    }
}
