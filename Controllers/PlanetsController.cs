using galaxies.Services;
using Microsoft.AspNetCore.Mvc;

namespace galaxies.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PlanetsController
    {
        private readonly PlanetsService _serv;

        public PlanetsController(PlanetsService serv)
        {
            _serv = serv;
        }
    }
}