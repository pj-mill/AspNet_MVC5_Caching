using MemoryCacheExample.Models;
using System.Collections.Generic;

namespace MemoryCacheExample.Services
{
    public interface ICustomerService
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetAllCustomers();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        IEnumerable<Customer> FindCustomersByCity(string city);
    }
}