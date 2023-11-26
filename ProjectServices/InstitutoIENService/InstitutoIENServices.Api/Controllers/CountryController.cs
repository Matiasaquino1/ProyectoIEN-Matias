using AutoMapper;
using InstitutoIENService.Core.DTOs;
using InstitutoIENService.Core.Interfaces;
using InstitutoIENServices.Api.Responses;
using Microsoft.AspNetCore.Mvc;

namespace InstitutoIENServices.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public CountryController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }
        public async Task<IActionResult> GetCountry()
        {
            var countries = await _countryService.GetAll();
            var countryDto = _mapper.Map<IEnumerable<CountryDto>>(countries);
            var response = new ApiResponse<IEnumerable<CountryDto>>(countryDto);
            return Ok(response);
        }
    }
}
    