using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Models.One_to_Many;
using Lab4_23.Repositories.GenericRepository;
using Lab4_23.Repositories.SnowWhiteRepository;

namespace Lab4_23.Repositories.SnowWhiteRepository
{
    public class SWRepo : GenericRepository<SnowWhite>, ISWRepo
    {
        public SWRepo(Lab4Context lab4Context) : base(lab4Context) { }
        public List<SnowWhite> OrderByName(string name)
        {
            var SnowWhiteOrdered = _table.OrderBy(x => x.Name);
            return SnowWhiteOrdered.ToList();
        }
    }
}
