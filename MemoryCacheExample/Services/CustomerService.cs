using MemoryCacheExample.Models;
using MemoryCacheExample.Repository;
using System;
using System.Collections.Generic;

namespace MemoryCacheExample.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            if (repo == null)
            {
                throw new ArgumentNullException("Customer Repository");
            }
            _repo = repo;
        }

        public void Add(Customer customer)
        {
            _repo.Add(customer);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<Customer> FindCustomersByCity(string city)
        {
            var predicate = new Predicate<Customer>((c) => { return c.City.Equals(city); });
            return _repo.Find(predicate);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repo.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return _repo.FindById(id);
        }

        public void Update(Customer customer)
        {
            _repo.Update(customer);
        }
    }
}