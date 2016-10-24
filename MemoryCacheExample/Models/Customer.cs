using System;

namespace MemoryCacheExample.Models
{
    public class Customer : IEquatable<Customer>
    {
        private static int currentId = 0;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
        public DateTime LastAccessed { get; private set; }
        public Customer() { }

        public static Customer Create(string name, string city)
        {
            return new Customer()
            {
                Id = ++currentId,
                Name = name,
                City = city,
                LastAccessed = DateTime.UtcNow
            };
        }

        public bool Equals(Customer other)
        {
            return (this.Id == other.Id) ? true : false;
        }

        public void UpdateLastAccessDate()
        {
            LastAccessed = DateTime.UtcNow;
        }
    }
}
