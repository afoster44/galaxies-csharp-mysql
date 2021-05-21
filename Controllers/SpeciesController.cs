using System.Collections.Generic;
using galaxies.Models;
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

        [HttpGet]
        public ActionResult<IEnumerable<Species>> GetAll()
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
        public ActionResult<Species> GetById(int id)
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
        public ActionResult<Species> Create([FromBody] Species species)
        {
            try
            {
                return Ok(_serv.Create(species));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Species> Delete(int id)
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