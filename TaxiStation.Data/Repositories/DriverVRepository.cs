using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Entities;
using TaxiStation.Core.Repositories;

namespace TaxiStation.Data.Repositories
{
    public class DriverVRepository
    {
        public class DriverRepository : IDriverRepository
        {
            private readonly DataContext _context;

            public DriverRepository(DataContext context)
            {
                _context = context;
            }

            public List<Driver> GetAll()
            {
                return _context.Drivers;
            }

            public Driver? GetById(int id)
            {
                return _context.Drivers.FirstOrDefault(x => x.Id == id);
            }

            public Driver Add(Driver Driver)
            {
                _context.Drivers.Add(Driver);
                return Driver;
            }

            public Driver Update(Driver Driver)
            {
                var existingDriver = GetById(Driver.Id);
                if (existingDriver is null)
                {
                    throw new Exception("Driver not found");
                }
                existingDriver.Name = Driver.Name;
                existingDriver.Phone = Driver.Phone;
                return existingDriver;
            }

            public void Delete(int id)
            {
                var existingDriver = GetById(id);
                if (existingDriver is not null)
                {
                    _context.Drivers.Remove(existingDriver);
                }
            }
        }
    }
}
