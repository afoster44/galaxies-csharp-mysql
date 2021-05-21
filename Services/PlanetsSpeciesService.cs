using galaxies.Repositories;

namespace galaxies.Services
{
    public class PlanetsSpeciesService
    {
        private readonly PlanetsSpeciesRepository _repo;

        public PlanetsSpeciesService(PlanetsSpeciesRepository repo)
        {
            _repo = repo;
        }
    }
}