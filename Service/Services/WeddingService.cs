using Presistent;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class WeddingService : IWeddingService
    {
        private readonly WeedingEventManagmentDbContext _context;

        public WeddingService(WeedingEventManagmentDbContext context)
        {
            _context = context;
        }
        public async Task<List<object>> GetAll()
        {
            var weddingList = await _context 

        }

        public Task<object> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
