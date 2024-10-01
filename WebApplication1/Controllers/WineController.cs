using Common.DTO;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly IWineService _wineService;
        public WineController(IWineService wineService)
        {
            _wineService = wineService;
        }

        [HttpGet]
        public IActionResult GetAllWines()
        {
            return Ok(_wineService.GetAllWines());
        }

        [HttpPost]
        public IActionResult New([FromBody] WineForCreation body)
        {
            WineForCreation wineForCreation = new()
            {
                Name = body.Name,
                Variety = body.Variety,
                Year = body.Year,
                Region = body.Region,
                Stock = body.Stock,
            };
            _wineService.AddWine(wineForCreation);
            return Created();
        }

        [HttpPut("add/{wineName}")]
        public IActionResult AddStock([FromBody] int amount, [FromRoute] string wineName)
        {
            try
            {
                _wineService.GetAllWines().Single(w => w.Name == wineName);
                _wineService.AddStock(amount, wineName);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPut("remove/{wineName}")]
        public IActionResult RemoveStock([FromBody] int amount, [FromRoute] string wineName)
        {
            try
            {
                _wineService.GetAllWines().Single(w => w.Name == wineName);
                _wineService.RemoveStock(amount, wineName);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
