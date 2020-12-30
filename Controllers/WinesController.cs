using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WineRacksWeb.Data;
using WineRacksWeb.Models;
using WineRacksWeb.Services.Interfaces;

namespace WineRacksWeb.Controllers
{
  [Authorize]
  [ApiController]
  [Route("api/[controller]")]
  public class WinesController : ControllerBase
  {
    public WinesController(IWineService service)
    {
      _wineService = service;
    }

    private IWineService _wineService;

    [HttpGet]
    public IEnumerable<Wine> GetWines()
    {
      return _wineService.GetWines();
    }

    [HttpPost]
    public IActionResult CreateWine([FromBody] SaveNewWineRequest request)
    {
      var id = _wineService.SaveNewWine(request);
      return Created($"/api/wines/{id}", id);
    }

    [HttpDelete]
    public IActionResult DeleteWine(int wineID)
    {
      _wineService.DeleteWine(wineID);
      return Ok();
    }
  }
}