using NasaApi.DTOs;
using NasaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NasaApi.Repositories
{
    public interface IRoverRepository
    {
        Task<Rover[]>  GetAllRoversAsync();
        Task<Rover> GetRoverByName(string name);
        Task<WheelDto> GetWheelsForRover(string name);
        Task<LaunchDateDto> GetLaunchDateForRover(string name);
        Task<WeightDto> GetWeightForRover(string name);
        Task<SpeedDto> GetSpeedForRover(string name);
    }
}
