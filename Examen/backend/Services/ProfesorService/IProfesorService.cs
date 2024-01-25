using backend.Models;
using backend.Models.DTOs.ProfesorDTO;

namespace backend.Services.ProfesorService
{
    public interface IProfesorService
    {
        Task<List<Profesor>> GetAll();
        Task Create(ProfesorDTO profesor);
        void Delete(Guid id);
        Task Update(ProfesorUpdateDTO profesor);
    }
}
