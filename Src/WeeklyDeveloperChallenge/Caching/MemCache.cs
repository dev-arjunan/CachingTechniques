using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using WeeklyDeveloperChallenge.Caching.Interfaces;

namespace WeeklyDeveloperChallenge.Caching
{
    public class MemCache : ICacheStorage
    {
        public void Remove(string key)
        {
            MemoryCache.Default.Remove(key);
        }

        public void Store(string key, object data)
        {
            MemoryCache.Default.Add(key, data, DateTime.Now.AddMinutes(30));
        }

        public T Retrieve<T>(string key)
        {
            T item = (T)MemoryCache.Default.Get(key);
            if (item == null)
            {
                item = default(T);
            }
            return item;
        }
    }
}