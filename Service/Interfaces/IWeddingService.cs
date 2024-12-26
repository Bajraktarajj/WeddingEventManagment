using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IWeddingService
    {
        Task<object> GetById(int id);

        Task<List<object>> GetAll();
    }
}
