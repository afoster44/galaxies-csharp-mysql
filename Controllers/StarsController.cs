using galaxies.Services;

namespace galaxies.Controllers
{
    public class StarsController
    {
        private readonly StarsService _service;

        public StarsController(StarsService service)
        {
            _service = service;
        }
    }
}