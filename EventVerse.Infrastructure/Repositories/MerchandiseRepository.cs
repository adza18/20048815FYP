using EventVerse.Application.Interfaces.Repositories;
using EventVerse.Infrastructure.Persistence;

namespace EventVerse.Infrastructure.Repositories
{
    public class MerchandiseRepository : IMerchandise
    {
        public EventVerseContext _context;

    }
}
