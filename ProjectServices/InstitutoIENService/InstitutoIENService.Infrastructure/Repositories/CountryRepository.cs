using InstitutoIENService.Core.Entities;
using InstitutoIENService.Core.Interfaces;
using InstitutoIENService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InstitutoIENService.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly InstitutoIencursoContext _context;
        public CountryRepository(InstitutoIencursoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Country>> GetCountries()
        {
            var countries = await _context.Countries.ToListAsync();
            return countries;
        }
         
    }
}

