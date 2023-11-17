using Lab4_23.Models;
using Lab4_23.Models.One_to_Many;
using Lab4_23.Repositories.GenericRepository;

namespace Lab4_23.Repositories.SnowWhiteRepository
{
    public interface ISWRepo : IGenericRepository<SnowWhite>
    {
        public List<SnowWhite> OrderByName(string name);
    }
}
