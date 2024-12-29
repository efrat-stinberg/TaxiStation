using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Entities;
using TaxiStation.Core.Repositories;

namespace TaxiStation.Data.Repositories
{
    public class AdminRepository: IAdminRepository
    {
        private readonly DataContext _context;

        public AdminRepository(DataContext context)
        {
            _context = context;
        }

        public List<Admin> GetAll()
        {
            return _context.Admin;
        }

        public Admin? GetById(int id)
        {
            return _context.Admin.FirstOrDefault(x => x.Id == id);
        }

        public Admin Add(Admin Admin)
        {
            _context.Admin.Add(Admin);
            return Admin;
        }

        public Admin Update(Admin Admin)
        {
            var existingAdmin = GetById(Admin.Id);
            if (existingAdmin is null)
            {
                throw new Exception("Admin not found");
            }
            existingAdmin.Name = Admin.Name;
            existingAdmin.Phone = Admin.Phone;
            return existingAdmin;
        }

        public void Delete(int id)
        {
            var existingAdmin = GetById(id);
            if (existingAdmin is not null)
            {
                _context.Admin.Remove(existingUser);
            }
        }
    }
}
