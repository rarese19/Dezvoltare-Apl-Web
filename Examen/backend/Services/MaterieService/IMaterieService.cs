using backend.Models.DTOs.ProfesorDTO;
using backend.Models;
using backend.Models.DTOs.MaterieDTO;

namespace backend.Services.MaterieService
{
    public interface IMaterieService
    {
        Task<List<Materie>> GetAll();
        Task Create(MaterieDTO materie);
        void Delete(Guid id);
        Task Update(MaterieUpdateDTO materie);

    }
}
