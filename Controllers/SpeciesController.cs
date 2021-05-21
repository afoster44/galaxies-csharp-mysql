using galaxies.Services;
using Microsoft.AspNetCore.Mvc;

namespace galaxies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpeciesController : ControllerBase
    {
        private readonly SpeciesService _serv;

        public SpeciesController(SpeciesService serv)
        {
            _serv = serv;
        }
    }
}