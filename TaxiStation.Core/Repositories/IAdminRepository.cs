using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Entities;

namespace TaxiStation.Core.Repositories
{
    public interface IAdminRepository
    {
        Admin? GetById(int id);

        Admin Add(Admin admin);

        Admin Update(Admin admin);

        void Delete(int id);

    }
}


