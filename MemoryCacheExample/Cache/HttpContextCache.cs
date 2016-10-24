using System;
using System.Web;

namespace MemoryCacheExample.Cache
{
    /// <summary>
    /// Responsible for caching data using HttpContext
    /// </summary>
    public class HttpContextCache : ICache
    {
        public void Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        public T Retrieve<T>(string key)
        {
            T itemStored = (T)HttpContext.Current.Cache.Get(key);
            return itemStored != null ? itemStored : default(T);
        }

        public void Store(string key, object data)
        {
            HttpContext.Current.Cache.Insert(key, data);
        }

        public void Store(string key, object data, DateTime absoluteExpiration, TimeSpan slidingExpiration)
        {
            HttpContext.Current.Cache.Insert(key, data, null, absoluteExpiration, slidingExpiration);
        }
    }
}