using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories.ProfesorRepository
{
    public class ProfesorRepository: GenericRepository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(DatabaseContext context) : base(context) { }

        public List<Profesor> ProfesorMaterie()
        {
            IQueryable<Profesor> query = _table;

            query = query.Include(p => p.ProfesorMaterie);

            return query.ToList();
        }
    }
}
