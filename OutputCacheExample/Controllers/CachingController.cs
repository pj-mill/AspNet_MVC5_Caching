using OutputCacheExample.Models;
using System;
using System.Web.Mvc;

namespace OutputCacheExample.Controllers
{
    public class CachingController : Controller
    {
        [OutputCache(Duration = 10)]
        public ViewResult Index()
        {
            // A new person object will only be passed to the view every 10 seconds.
            // Otherwise, it will be retrieved from the cache.
            Person person = new Person() { Name = "John", Created = DateTime.Now };
            return View(person);
        }

        [OutputCache(CacheProfile = "Aggressive")]
        public ViewResult AggressiveCacheProfile()
        {
            Person person = new Person() { Name = "Aggressive Profile", Created = DateTime.Now };
            return View(person);
        }

        [OutputCache(CacheProfile = "Short")]
        public ViewResult ShortCacheProfile()
        {
            Person person = new Person() { Name = "Short Profile", Created = DateTime.Now };
            return View(person);
        }
    }
}