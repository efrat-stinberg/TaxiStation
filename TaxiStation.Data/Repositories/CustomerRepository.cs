using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Core.Entities;
using TaxiStation.Core.Repositories;

namespace TaxiStation.Data.Repositories
{
    public class CustomerRepository
    {
        public class CustomerRepository : ICustomerRepository
        {
            private readonly DataContext _context;

            public CustomerRepository(DataContext context)
            {
                _context = context;
            }

            public List<Customer> GetAll()
            {
                return _context.Customers;
            }

            public Customer? GetById(int id)
            {
                return _context.Customers.FirstOrDefault(x => x.Id == id);
            }

            public Customer Add(Customer Customer)
            {
                _context.Customers.Add(Customer);
                return Customer;
            }

            public Customer Update(Customer Customer)
            {
                var existingCustomer = GetById(Customer.Id);
                if (existingCustomer is null)
                {
                    throw new Exception("Customer not found");
                }
                existingCustomer.Name = Customer.Name;
                existingCustomer.Phone = Customer.Phone;
                return existingCustomer;
            }

            public void Delete(int id)
            {
                var existingCustomer = GetById(id);
                if (existingCustomer is not null)
                {
                    _context.Customers.Remove(existingCustomer);
                }
            }
        }
    }
}
