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

        /* public async Task<Rover> GetAllCampsByEventDate()
         {
             _logger.LogInformation($"Getting all Camps");

             IQueryable<Camp> query = _context.Camps
                 .Include(c => c.Location);

             if (includeTalks)
             {
                 query = query
                   .Include(c => c.Talks)
                   .ThenInclude(t => t.Speaker);
             }

             // Order It
             query = query.OrderByDescending(c => c.EventDate)
               .Where(c => c.EventDate.Date == dateTime.Date);

             return await query.ToArrayAsync();
         }*/

        public async Task<Rover[]> GetAllRoversAsync()
        {
            return _rovers.ToArray();
        }

        public async Task<Rover> GetRoverByName(string name)
        {

            return  _rovers.FirstOrDefault(r => r.Name == name);
        }


    }
}
