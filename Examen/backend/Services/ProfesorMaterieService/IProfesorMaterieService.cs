using backend.Models.DTOs.RelatieDTO;

namespace backend.Services.ProfesorMaterieService
{
    public interface IProfesorMaterieService
    {
        Task Create(RelatieCreateDTO test);
        void Delete(Guid id);
    }
}
