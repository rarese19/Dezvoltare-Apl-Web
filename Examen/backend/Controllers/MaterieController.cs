using backend.Models.DTOs.MaterieDTO;
using backend.Models.DTOs.ProfesorDTO;
using backend.Services.MaterieService;
using backend.Services.ProfesorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterieController : ControllerBase
    {
        private readonly IMaterieService _materieService;

        public MaterieController(IMaterieService materieService)
        {
            _materieService = materieService;
        }

        [HttpGet("getAllMaterii")]
        public async Task<IActionResult> GetAllMaterii()
        {
            try
            {
                return Ok(await _materieService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateMaterie([FromBody] MaterieDTO materie)
        {
            await _materieService.Create(materie);
            return Ok();
        }


        [HttpPatch("update")]
        public async Task<IActionResult> UpdateMaterie([FromBody] MaterieUpdateDTO materie)
        {
            await _materieService.Update(materie);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteMaterie(Guid id)
        {
            _materieService.Delete(id);
            return Ok();
        }
    }
}
