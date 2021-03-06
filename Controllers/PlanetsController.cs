using System.Collections.Generic;
using galaxies.Models;
using galaxies.Services;
using Microsoft.AspNetCore.Mvc;

namespace galaxies.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PlanetsController : ControllerBase
    {
        private readonly PlanetsService _serv;

        public PlanetsController(PlanetsService serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Planet>> GetAll() 
        {
            try
            {
                return Ok(_serv.GetAll());
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Planet> GetById(int id)
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
        public ActionResult<Planet> Create([FromBody] Planet planet)
        {
            try
            {
                return Ok(_serv.Create(planet));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Planet> Delete(int id)
        {
            try
            {
                return Ok(_serv.Delete(id));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
    }
}