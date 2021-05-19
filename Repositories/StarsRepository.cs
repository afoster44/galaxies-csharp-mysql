using System.Data;

namespace galaxies.Repositories
{
    public class StarsRepository
    {
        private readonly IDbConnection _repo;

        public StarsRepository(IDbConnection repo)
        {
            _repo = repo;
        }
    }
}