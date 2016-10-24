using MemoryCacheExample.Cache;
using MemoryCacheExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryCacheExample.Services
{
    public class InMemoryCachedCustomerService : ICustomerService
    {
        private readonly ICustomerService _service;
        private readonly ICache _cache;

        private const string getAllCustomersKey = "GetAllCustomers";
        private const string findCustomersByCityKey = "FindCustomersByCity";

        public InMemoryCachedCustomerService(ICustomerService service, ICache cache)
        {
            if (service == null) { throw new ArgumentNullException("Customer Service"); }
            if (cache == null) { throw new ArgumentNullException("Cache Service"); }
            _service = service;
            _cache = cache;
        }

        public void Add(Customer customer)
        {
            _cache.Remove(getAllCustomersKey); // Force a lookup from repository
            _service.Add(customer);
        }

        public void Delete(int id)
        {
            _cache.Remove(getAllCustomersKey); // Force a lookup from repository
            _service.Delete(id);
        }

        public IEnumerable<Customer> FindCustomersByCity(string city)
        {
            if (String.IsNullOrWhiteSpace(city))
            {
                return GetAllCustomers();
            }

            List<Customer> customers;
            try
            {
                string storageKey = $"{findCustomersByCityKey}:{city}";
                customers = _cache.Retrieve<List<Customer>>(storageKey);
                if (customers == null)
                {
                    customers = _service.FindCustomersByCity(city).ToList();
                    _cache.Store(storageKey, customers, DateTime.UtcNow.AddMinutes(1), TimeSpan.Zero);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return customers;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            List<Customer> customers;
            try
            {
                customers = _cache.Retrieve<List<Customer>>(getAllCustomersKey);
                if (customers == null)
                {
                    customers = _service.GetAllCustomers().ToList();
                    _cache.Store(getAllCustomersKey, customers, DateTime.UtcNow.AddMinutes(1), TimeSpan.Zero);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return customers;
        }

        public Customer GetCustomer(int id)
        {
            return _service.GetCustomer(id);
        }

        public void Update(Customer customer)
        {
            _cache.Remove(getAllCustomersKey); // Force a lookup from repository
            _service.Update(customer);
        }
    }
}