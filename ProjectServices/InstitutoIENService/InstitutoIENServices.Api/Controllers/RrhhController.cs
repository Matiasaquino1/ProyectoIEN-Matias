using InstitutoIENService.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace InstitutoIENServices.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class RrhhController : ControllerBase
    {
        private readonly IRrhhRepository _rrhhRepository;

        public RrhhController(IRrhhRepository rrhhRepository) 
        {
            _rrhhRepository = rrhhRepository;          
        }


        [HttpGet]
        public async Task<IActionResult> GetRrhh()
        {
            var Rrhh = await _rrhhRepository.GetRrhh();
            return Ok (Rrhh);
        }

    }
}
