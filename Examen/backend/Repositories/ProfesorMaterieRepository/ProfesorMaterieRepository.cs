using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories.ProfesorMaterieRepository
{
    public class ProfesorMaterieRepository: GenericRepository<ProfesorMaterie>, IProfesorMaterieRepository
    {
        public ProfesorMaterieRepository(DatabaseContext context) : base(context) { }
    }
}
