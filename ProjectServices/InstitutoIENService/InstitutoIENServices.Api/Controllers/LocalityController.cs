using Microsoft.AspNetCore.Mvc;
using InstitutoIENService.Core.Interfaces;

namespace InstitutoIENServices.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocalityController : ControllerBase
    {
        private readonly ILocalityRepository _localityRepository;

        public LocalityController(ILocalityRepository LocalityRepository)
        {
            _localityRepository = LocalityRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetLocality()
        {
            var locality = await _localityRepository.GetLocality();
            return Ok(locality);
        }

    }
}
