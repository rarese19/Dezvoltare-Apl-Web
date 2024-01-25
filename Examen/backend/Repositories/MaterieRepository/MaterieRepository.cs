using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.MaterieRepository
{
    public class MaterieRepository: GenericRepository<Materie>, IMaterieRepository
    {
        public MaterieRepository(DatabaseContext context): base(context) { }
    }
}
