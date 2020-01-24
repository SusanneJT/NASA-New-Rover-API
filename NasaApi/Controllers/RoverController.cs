using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NasaApi.Models;
using NasaApi.Repositories;

namespace NasaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoverController : ControllerBase
    {
        private readonly IRoverRepository _roverRepository;

        public RoverController(IRoverRepository roverRepository)
        {
            _roverRepository = roverRepository;
        }

        // GET: api/Rover
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rover>>> GetRovers()
        {
            return await _roverRepository.GetAllRoversAsync();
        }



        // GET: api/Rover/RoverName
        [HttpGet("{name}")]
        public async Task<ActionResult<Rover>> GetRoverByName(string name)
        {

            try
            {
                var result = await _roverRepository.GetRoverByName(name);
                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }


    }
}
