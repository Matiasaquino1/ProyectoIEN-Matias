using InstitutoIENService.Core.Entities;

namespace InstitutoIENService.Core.Interfaces
{
    public interface ICountryService
    {
        void Agregar(Country country);
        
        Task<Country> GetCountry(int id);

        Task<IEnumerable<Country>> GetAll();
    }
}
