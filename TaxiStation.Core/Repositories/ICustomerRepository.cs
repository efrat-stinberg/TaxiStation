using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.Repositories
{
    public interface ICustomerRepository
    {
        public Customer(int id, string name, string address, string city, string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            Phone = phone;
        }
    }
}
