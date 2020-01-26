using System;
namespace MightyCedrus.Models
{
  public class Performer
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public decimal Payout { get; set; }

    public Performer()
    {
    }
  }
}
