using NasaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NasaApi.Repositories
{
    public interface IRoverRepository
    {
        //Task<Rover> GetSpeakerAsync();
        Task<Rover[]>  GetAllRoversAsync();
        Task<Rover> GetRoverByName(string name);
    }
}
