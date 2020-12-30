using System.Collections.Generic;
using WineRacksWeb.Models;

namespace WineRacksWeb.Services.Interfaces
{
  public interface IWineService
  {
    IEnumerable<Wine> GetWines();
    int SaveNewWine(SaveNewWineRequest request);
    void DeleteWine(int ID);
  }

  public class SaveNewWineRequest
  {
    public string Winery { get; set; }
    public string Name { get; set; }
    public WineCategory Category { get; set; }
  }
}