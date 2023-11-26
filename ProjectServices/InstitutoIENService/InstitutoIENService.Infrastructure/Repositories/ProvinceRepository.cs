using InstitutoIENService.Core.Entities;
using InstitutoIENService.Core.Interfaces;
using InstitutoIENService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InstitutoIENService.Infrastructure.Repositories
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly InstitutoIencursoContext _context;
        public ProvinceRepository(InstitutoIencursoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Province>> GetProvince()
        {
            var province = await _context.Provinces.ToListAsync();
            return province;
        }
    }
}
