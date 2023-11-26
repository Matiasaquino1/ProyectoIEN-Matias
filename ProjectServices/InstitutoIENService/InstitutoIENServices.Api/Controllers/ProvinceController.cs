using Microsoft.AspNetCore.Mvc;
using InstitutoIENService.Core.Interfaces;



namespace InstitutoIENServices.Api.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceRepository _provinceRepository;

        public ProvinceController(IProvinceRepository ProvinceRepository) 
        {
            _provinceRepository = ProvinceRepository;          
        }


        [HttpGet]
        public async Task<IActionResult> GetProvince()
        {
            var provinces = await _provinceRepository.GetProvince();
            return Ok (provinces);
        }

    }
}
