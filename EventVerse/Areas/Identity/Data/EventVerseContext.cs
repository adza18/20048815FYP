using EventVerse.Areas.Identity.Data;
using EventVerse.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventVerse.Data;

public class EventVerseContext : IdentityDbContext<ApplicationUser>
{
    public EventVerseContext(DbContextOptions<EventVerseContext> options)
        : base(options)
    {
    }

    public DbSet<Merchandise> Merchandises { get; set; }

   
}

