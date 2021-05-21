using System.Data;

namespace galaxies.Repositories
{
    public class PlanetsSpeciesRepository
    {
        private readonly IDbConnection _db;

        public PlanetsSpeciesRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}