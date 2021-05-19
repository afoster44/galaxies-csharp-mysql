using System.Collections.Generic;
using galaxies.Models;
using galaxies.Services;
using Microsoft.AspNetCore.Mvc;

namespace galaxies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StarsController : ControllerBase
    {
        private readonly StarsService _service;

        public StarsController(StarsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Star>> GetAll()
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

        [HttpGet("{id}")]
        public  ActionResult<Star> GetById(int id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Star> Create([FromBody] Star star)
        {
            try
            {
                return Ok(_service.Create(star));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Star> Delete(int id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
    }
}