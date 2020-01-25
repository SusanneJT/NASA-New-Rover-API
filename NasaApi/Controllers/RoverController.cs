using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NasaApi.DTOs;
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

                return StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{name}/wheels")]
        public async Task<ActionResult<WheelDto>> GetWheels(string name)
        {
            try
            {
                var wheels = await _roverRepository.GetWheelsForRover(name);
                if (wheels == null) return NotFound();

                return wheels;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }

        [HttpGet("{name}/launchdate")]
        public async Task<ActionResult<LaunchDateDto>> GetLaunchDate(string name)
        {
            try
            {
                var launchDate = await _roverRepository.GetLaunchDateForRover(name);
                if (launchDate == null) return NotFound();

                return launchDate;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }

        [HttpGet("{name}/speed")]
        public async Task<ActionResult<SpeedDto>> GetSpeed(string name)
        {
            try
            {
                var speed = await _roverRepository.GetSpeedForRover(name);
                if (speed == null) return NotFound();

                return speed;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{name}/weight")]
        public async Task<ActionResult<WeightDto>> GetWeight(string name)
        {
            try
            {
                var weight = await _roverRepository.GetWeightForRover(name);
                if (weight == null) return NotFound();

                return weight;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }


    }
}
