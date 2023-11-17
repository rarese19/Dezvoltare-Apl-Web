using Lab4_23.Data;
using Lab4_23.Models.DTOs;
using Lab4_23.Models.One_to_Many;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab4_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly Lab4Context _lab4Context;

        public DatabaseController(Lab4Context lab4Context)
        {
            _lab4Context = lab4Context;
        }

        [HttpGet("snowwhite")]
        public async Task<IActionResult> GetModel1()
        {
            return Ok(await _lab4Context.SnowWhite.ToListAsync());
        }

        [HttpPost("snowwhite")]
        public async Task<IActionResult> Create (SnowWhiteDTO SnowWHiteDTO)
        {
            var SnowWhite = new SnowWhite
            {
                Id = Guid.NewGuid(),
                Name = SnowWHiteDTO.Name
            };

            await _lab4Context.AddAsync(SnowWhite);
            await _lab4Context.SaveChangesAsync();

            return Ok(SnowWhite);
        }

        [HttpPost("snowwhite_update")]
        public async Task<IActionResult> Update(SnowWhiteDTO SnowWhiteDTO)
        {
            SnowWhite SnowWhitebyID = await _lab4Context.SnowWhite.FirstOrDefaultAsync(x => x.Id == SnowWhiteDTO.Id);
            if (SnowWhitebyID == null)
            {
                return BadRequest("Object does not exist");
            }

            SnowWhitebyID.Name = SnowWhiteDTO.Name;
            _lab4Context.Update(SnowWhiteDTO);
            await _lab4Context.SaveChangesAsync();
            
            return Ok(SnowWhitebyID);
        }


    }
}
