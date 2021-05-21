using galaxies.Repositories;

namespace galaxies.Services
{
    public class SpeciesService
    {
        private readonly SpeciesRepository _repo;

        public SpeciesService(SpeciesRepository repo)
        {
            _repo = repo;
        }
    }
}