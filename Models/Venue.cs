using System;
namespace MightyCedrus.Models
{
  public class Venue
  {
    public int Id { get; set; }
    public string VenueName { get; set; }
    public string ContactName { get; set; }
    public string Email { get; set; }
    public int VenueNumber { get; set; }
    public string VenueURL { get; set; }

    public Venue()
    {
    }
  }
}
