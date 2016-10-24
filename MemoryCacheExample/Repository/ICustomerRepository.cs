using MemoryCacheExample.Models;
using System;
using System.Collections.Generic;

namespace MemoryCacheExample.Repository
{
    public interface ICustomerRepository
    {
        Customer FindById(int id);
        IEnumerable<Customer> Find(Predicate<Customer> predicate);
        IEnumerable<Customer> GetAll();
        void Add(Customer customer);
        void Delete(int id);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
