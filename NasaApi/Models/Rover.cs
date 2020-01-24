using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NasaApi.Models
{
    public class Rover
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LaunchDate { get; set; }
        public int Wheels { get; set; }
        public int Speed { get; set; }
        public decimal Weight { get; set; }
    }
}
