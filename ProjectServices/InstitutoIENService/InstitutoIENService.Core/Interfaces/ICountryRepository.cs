using InstitutoIENService.Core.Entities;

namespace InstitutoIENService.Core.Interfaces
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetCountries();
    }
}

