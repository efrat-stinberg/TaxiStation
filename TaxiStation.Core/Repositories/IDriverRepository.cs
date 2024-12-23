using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.Repositories
{
    
    public interface IDriverRepository
    {
        public Driver(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }
    }
}
