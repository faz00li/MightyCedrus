using System.Collections.Generic;

namespace MightyCedrus.Models
{
  public class Concert
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string VenueName { get; set; }
    public int Date { get; set; }
    public decimal Price { get; set; }

    public ICollection<Performer> Performers { get; set; }
    public ICollection<Venue> Venues { get; set; }

    public Concert()
    {
      this.Performers = new HashSet<Performer>();
      this.Venues = new HashSet<Venue>();
    }
  }
}