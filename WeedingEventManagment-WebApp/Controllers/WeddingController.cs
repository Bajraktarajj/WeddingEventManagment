using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace WeedingEventManagment_WebApp.Controllers
{
    [ApiController]
    public class WeddingController : Controller
    {
        private readonly IWeddingService _weddingService;

        public WeddingController(IWeddingService weddingService)
        {
            _weddingService = weddingService;
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var getWeddingById = await _weddingService.GetById(id, cancellationToken);
            return Ok(getWeddingById); 
        }
    }
}
