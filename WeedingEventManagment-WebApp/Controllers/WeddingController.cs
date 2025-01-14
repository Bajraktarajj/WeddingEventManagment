using Domain.Models;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace WeedingEventManagment_WebApp.Controllers
{
    //[ApiController]
    public class WeddingController : Controller
    {
        private readonly IWeddingService _weddingService;

        public WeddingController(IWeddingService weddingService)
        {
            _weddingService = weddingService;
        }

        //[HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var getWeddingById = await _weddingService.GetById(id, cancellationToken);
            return Ok(getWeddingById);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new WeddingViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(WeddingViewModel model)
        {
            var wedding = _weddingService.CreateWedding(model.Type);
            wedding.BrideName = model.BrideName;
            wedding.GroomName = model.GroomName;
            wedding.DateReservation = model.DateReservation;

            return View();
        }

    }
}