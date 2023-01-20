using EventVerse.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventVerse.Infrastructure.Persistence;



public class EventVerseContext : IdentityDbContext<ApplicationUser>
{
    public EventVerseContext(DbContextOptions<EventVerseContext> options)
        : base(options)
    {
    }

    public DbSet<Merchandise> Merchandises { get; set; }



}

