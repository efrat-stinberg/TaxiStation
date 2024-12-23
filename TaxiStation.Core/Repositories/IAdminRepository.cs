using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.Repositories
{
    public interface IAdminRepository
    {
        public Admin(int id, string name, List<Driver> drivers)
        {
            Id = id;
            Name = name;
            Drivers = drivers;
        }



    }
}
