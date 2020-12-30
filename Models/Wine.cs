namespace WineRacksWeb.Models
{
  public class Wine
  {
    public int ID { get; set; }
    public string Winery { get; set; }
    public string Name { get; set; }
    public WineCategory Category { get; set; }
  }

  public enum WineCategory
  {
    Claret,
    Malbec,
    OtherRed,
    OtherWhite,
    RedBlend,
  }
}