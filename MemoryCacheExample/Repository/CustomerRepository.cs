using MemoryCacheExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryCacheExample.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private List<Customer> customers = new List<Customer>();

        public CustomerRepository()
        {
            LoadCustomers();
        }

        public void Add(Customer customer)
        {
            if (customers.Contains(customer))
            {
                Update(customer);
            }
            customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customer);
        }

        public void Delete(int id)
        {
            var custToDelete = FindById(id);
            if (custToDelete != null)
            {
                Delete(custToDelete);
            }
        }

        public IEnumerable<Customer> Find(Predicate<Customer> predicate)
        {
            return customers.FindAll(predicate);
        }

        public Customer FindById(int id)
        {
            return (from c in customers where c.Id == id select c).FirstOrDefault();
        }

        public IEnumerable<Customer> GetAll()
        {
            return customers;
        }

        public void Update(Customer customer)
        {
            var custToUpdate = FindById(customer.Id);
            if (custToUpdate != null)
            {
                Delete(custToUpdate);
                Add(customer);
            }
        }

        private void LoadCustomers()
        {
            customers.Add(Customer.Create("John", "Dublin"));
            customers.Add(Customer.Create("Philip", "London"));
            customers.Add(Customer.Create("Mary", "Dublin"));
            customers.Add(Customer.Create("Frank", "Cork"));
            customers.Add(Customer.Create("Martin", "Dublin"));
            customers.Add(Customer.Create("Jane", "Cork"));
            customers.Add(Customer.Create("Henry", "London"));
        }
    }
}
