using backend.Models.DTOs.RelatieDTO;
using backend.Services.ProfesorMaterieService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorMaterieController : ControllerBase
    {
        private readonly IProfesorMaterieService _profesorMaterieService;

        public ProfesorMaterieController(IProfesorMaterieService profesorMaterieService)
        {
            _profesorMaterieService = profesorMaterieService;
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AdaugaMaterie([FromBody] RelatieCreateDTO dto)
        {
            await _profesorMaterieService.Create(dto);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult Delete(Guid id) 
        {
            _profesorMaterieService.Delete(id);
            return Ok();
        }
    }
}
