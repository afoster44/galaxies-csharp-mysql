using galaxies.Services;

namespace galaxies.Controllers
{
    public class PlanetsSpecies
    {
        private readonly PlanetsSpeciesService _serv;

        public PlanetsSpecies(PlanetsSpeciesService serv)
        {
            _serv = serv;
        }
    }
}