using backend.Data;
using backend.Models;

namespace backend.Helpers.Seeders;

public class TestSeeder
{
    private readonly DatabaseContext _dbContext;

    public TestSeeder(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

   
}