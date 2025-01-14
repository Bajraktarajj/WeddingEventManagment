using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Presistent;
using Service.Interfaces;

namespace Service.Services
{
    public class WeddingService : IWeddingService
    {
        private readonly WeedingEventManagmentDbContext _context;

        public WeddingService(WeedingEventManagmentDbContext context)
        {
            _context = context;
        }
        public async Task<List<Wedding>> GetAll(CancellationToken cancellationToken)
        {
            var weddingList = await _context.Wedding.ToListAsync(cancellationToken);

            return weddingList;


        }

        public async Task<Wedding> GetById(int id, CancellationToken cancellationToken)
        {
            var getWedding = await _context.Wedding.FirstOrDefaultAsync(w => w.Id == id, cancellationToken);

            return getWedding;
        }

        public Wedding CreateWedding(string type)
        {
            switch (type)
            {
                case "Traditional":
                    return new TraditionalWedding();
                case "Modern":
                    return new ModernWedding();
                default:
                    throw new ArgumentException("Unknown wedding type.");
            }
        }
    }
}
