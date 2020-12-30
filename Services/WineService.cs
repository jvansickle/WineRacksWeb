using System;
using System.Collections.Generic;
using System.Linq;
using WineRacksWeb.Data;
using WineRacksWeb.Models;
using WineRacksWeb.Services.Interfaces;

namespace WineRacksWeb.Services
{
  public class WineService : IWineService
  {
    public WineService(ApplicationDbContext context)
    {
      _context = context;
    }

    private readonly ApplicationDbContext _context;

    public IEnumerable<Wine> GetWines()
    {
      return _context.Wines.ToList();
    }

    public int SaveNewWine(SaveNewWineRequest request)
    {
      var newWine = new Wine
      {
        Winery = request.Winery,
        Name = request.Name,
        Category = request.Category,
      };

      _context.SaveChanges();

      return newWine.ID;
    }

    public void DeleteWine(int ID)
    {
      var matchingWine = _context.Wines.FirstOrDefault(w => w.ID == ID);

      if (matchingWine != null)
      {
        _context.Wines.Remove(matchingWine);
        _context.SaveChanges();
      }
    }
  }
}