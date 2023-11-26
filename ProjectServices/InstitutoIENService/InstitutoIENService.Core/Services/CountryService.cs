using InstitutoIENService.Core.Entities;
using InstitutoIENService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoIENService.Core.Services
{
    public class CountryService : ICountryService
    {
        public readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public void Agregar(Country country)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Country>> GetAll()
        {
            var countries = await _countryRepository.GetCountries();
            return countries;
        }

        public Task<Country> GetCountry(int id)
        {
            throw new NotImplementedException();
        }
    }
}
