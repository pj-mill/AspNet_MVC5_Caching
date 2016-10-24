using System;

namespace MemoryCacheExample.Cache
{
    public interface ICache
    {
        void Remove(string key);
        void Store(string key, object data);
        void Store(string key, object data, DateTime absoluteExpiration, TimeSpan slidingExpiration);
        T Retrieve<T>(string key);
    }
}