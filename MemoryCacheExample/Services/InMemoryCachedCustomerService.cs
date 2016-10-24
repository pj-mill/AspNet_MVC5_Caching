using MemoryCacheExample.Cache;
using MemoryCacheExample.Models;
using System;
using System.Collections.Generic;

namespace MemoryCacheExample.Services
{
    public class InMemoryCachedCustomerService : ICustomerService
    {
        private readonly ICustomerService _service;
        private readonly ICache _cache;

        public InMemoryCachedCustomerService(ICustomerService service, ICache cache)
        {
            if (service == null) { throw new ArgumentNullException("Customer Service"); }
            if (cache == null) { throw new ArgumentNullException("Cache Service"); }
            _service = service;
            _cache = cache;
        }
        public void Add(Customer customer)
        {
            _service.Add(customer);
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        public IEnumerable<Customer> FindCustomersByCity(string city)
        {
            return _service.FindCustomersByCity(city);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _service.GetAllCustomers();
        }

        public Customer GetCustomer(int id)
        {
            return _service.GetCustomer(id);
        }

        public void Update(Customer customer)
        {
            _service.Update(customer);
        }
    }
}