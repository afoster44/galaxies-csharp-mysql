using System.Collections.Generic;
using System.Threading.Tasks;
using galaxies.Models;
using galaxies.Services;
using Microsoft.AspNetCore.Mvc;

namespace galaxies.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class GalaxyController : ControllerBase
    {
        private readonly GalaxyService _service;
        public GalaxyController(GalaxyService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Galaxy>> GetAll()
        {
            try
            {
                return Ok(_service.GetAll());
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPost]

        public ActionResult<Galaxy> Create([FromBody] Galaxy galaxy)
        {
            try
            {
                return Ok(_service.Create(galaxy));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
    }
}