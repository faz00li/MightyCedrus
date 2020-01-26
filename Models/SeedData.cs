using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MightyCedrus.Data;
using System;
using System.Linq;

namespace MightyCedrus.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new MightyCedrusContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<MightyCedrusContext>>()))
      {
        // Look for any movies.
        if (context.Venues.Any())
        {
          return;   // DB has been seeded
        }

        context.Venues.AddRange(
            new Venue
            {
              VenueName = "Drom Taberna",
              ContactName = "Freddy Fingers",
              Email = "drom.taberna@gma",
              VenueNumber = 7482099,
              VenueURL = "www.dromtaberna.com"
            },

            new Venue
            {
              VenueName = "El Mocambo",
              ContactName = "Michael Wekerle",
              Email = "",
              VenueNumber = 3452345,
              VenueURL = "https://elmocambo.com/"
            }
        );
        context.SaveChanges();
      }
    }
  }
}