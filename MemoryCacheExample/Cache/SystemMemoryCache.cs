using System;
using System.Runtime.Caching;

namespace MemoryCacheExample.Cache
{
    /// <summary>
    /// Responsible for caching data using System Runtime Caching
    /// </summary>
    public class SystemMemoryCache : ICache
    {
        public void Remove(string key)
        {
            ObjectCache cache = MemoryCache.Default;
            cache.Remove(key);
        }

        public T Retrieve<T>(string key)
        {
            ObjectCache cache = MemoryCache.Default;
            return cache.Contains(key) ? (T)cache[key] : default(T);
        }

        public void Store(string key, object data)
        {
            ObjectCache cache = MemoryCache.Default;
            cache.Add(key, data, null);
        }

        public void Store(string key, object data, DateTime absoluteExpiration, TimeSpan slidingExpiration)
        {
            ObjectCache cache = MemoryCache.Default;

            // Create a new policy for this object
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = absoluteExpiration,
                SlidingExpiration = slidingExpiration
            };

            // Remove if it already exists
            if (cache.Contains(key))
            {
                cache.Remove(key);
            }

            // Add to cache
            cache.Add(key, data, policy);
        }
    }
}