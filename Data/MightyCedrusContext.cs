using Microsoft.EntityFrameworkCore;
using MightyCedrus.Models;

namespace MightyCedrus.Data
{
  public class MightyCedrusContext : DbContext
  {
    public MightyCedrusContext(DbContextOptions<MightyCedrusContext> options) : base(options)
    {

    }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Performer> Performers { get; set; }
    public DbSet<Venue> Venues { get; set; }
  }
}
