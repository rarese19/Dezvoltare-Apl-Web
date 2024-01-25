using AutoMapper;
using backend.Models;
using backend.Models.DTOs.ProfesorDTO;
using backend.Services.ProfesorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorService _profesorService;

        public ProfesorController(IProfesorService profesorService)
        {
            _profesorService = profesorService;
        }

        [HttpGet("getAllProf")]
        public async Task<IActionResult> GetAllProf()
        {
            try
            {
                return Ok(await _profesorService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProfesor([FromBody] ProfesorDTO profesor)
        {
            await _profesorService.Create(profesor);
            return Ok();
        }


        [HttpPatch("update")]
        public async Task<IActionResult> UpdateProfesor([FromBody] ProfesorUpdateDTO profesor)
        {
            await _profesorService.Update(profesor);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteProfesor(Guid id)
        {
            _profesorService.Delete(id);
            return Ok();
        }

    }
}
