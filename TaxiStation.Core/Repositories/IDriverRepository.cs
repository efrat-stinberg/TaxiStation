using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Entities;

namespace TaxiStation.Core.Repositories
{
    
    public interface IDriverRepository
    {
        List<Driver> GetAll();

        Driver? GetById(int id);

        Driver Add(Driver driver);

        Driver Update(Driver driver);

        void Delete(int id);
    }
}
