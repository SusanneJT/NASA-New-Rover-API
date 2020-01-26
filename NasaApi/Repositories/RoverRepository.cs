using NasaApi.DTOs;
using NasaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NasaApi.Repositories
{
    public class RoverRepository : IRoverRepository
    {
        private readonly List<Rover> _rovers;

        public RoverRepository()
        {
            _rovers = new List<Rover>
            {
                new Rover {Id=1, Name="Lazy", LaunchDate="2020-04-01", Speed=8, Wheels=8, Weight=30},
                new Rover {Id=2, Name="Fatty", LaunchDate="2020-08-13", Speed=60, Wheels=6, Weight=480},
                new Rover {Id=3, Name="Speedy", LaunchDate="2020-06-10", Speed=220, Wheels=3, Weight=80}
            };
        }


        public async Task<LaunchDateDto> GetLaunchDateForRover(string name)
        {
            LaunchDateDto launchInfo = new LaunchDateDto
            {
                Name = name,
                LaunchDate = _rovers.FirstOrDefault(r => r.Name == name).LaunchDate
            };

            return launchInfo;
        }

        public async Task<SpeedDto> GetSpeedForRover(string name)
        {
            SpeedDto speedInfo = new SpeedDto
            {
                Name = name,
                Speed = _rovers.FirstOrDefault(r => r.Name == name).Speed
            };

            return speedInfo;
        }

        public async Task<WeightDto> GetWeightForRover(string name)
        {
            WeightDto weightInfo = new WeightDto
            {
                Name = name,
                Weight = _rovers.FirstOrDefault(r => r.Name == name).Weight
            };

            return weightInfo;
        }

        public async Task<WheelDto> GetWheelsForRover(string name)
        {
            WheelDto wheelInfo = new WheelDto
            {
                Name = name,
                Wheels = _rovers.FirstOrDefault(r => r.Name == name).Wheels
            };

            return wheelInfo;
        }
    }
}
