using System.Data;

namespace galaxies.Repositories
{
    public class SpeciesRepository
    {
        private readonly IDbConnection _db;

        public SpeciesRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}