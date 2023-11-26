
using InstitutoIENService.Core.Entities;
using InstitutoIENService.Core.Interfaces;
using InstitutoIENService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InstitutoIENService.Infrastructure.Repositories
{
    public class RrhhRepository : IRrhhRepository
    {
        private readonly InstitutoIencursoContext _context;
        public RrhhRepository(InstitutoIencursoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rrhh>> GetRrhh() 
        {
            var rrhh = await _context.Rrhhs.ToListAsync();
            return rrhh;       
        
        }


    }
    
    
}



        
    