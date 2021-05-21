using System.Collections.Generic;
using galaxies.Models;
using galaxies.Services;
using Microsoft.AspNetCore.Mvc;

namespace galaxies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanetsSpeciesController : ControllerBase
    {
        private readonly PlanetsSpeciesService _serv;

        public PlanetsSpeciesController(PlanetsSpeciesService serv)
        {
            _serv = serv;
        }

        [HttpGet("{id}")]
        public ActionResult<PlanetsSpecies> GetById(int id)
        {
            try
            {
                return Ok(_serv.GetById(id));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<PlanetsSpecies> Create([FromBody] PlanetsSpecies newPS)
        {
            try
            {
                return Ok(_serv.Create(newPS));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
    }
}