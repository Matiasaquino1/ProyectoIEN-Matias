using InstitutoIENService.Core.Entities;
using InstitutoIENService.Core.Interfaces;
using InstitutoIENService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InstitutoIENService.Infrastructure.Repositories
{
    public class LocalityRepository : ILocalityRepository
    {
        private readonly InstitutoIencursoContext _context;
        public LocalityRepository(InstitutoIencursoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Locality>> GetLocality()
        {
            var locality = await _context.Localities.ToListAsync();
            return locality;
        }
    }
}
