using OutputCacheExample.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OutputCacheExample.Controllers
{
    public class CachingController : Controller
    {
        private int counter = 0;

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

        [OutputCache(Duration = 15, VaryByParam = "id")]
        public ViewResult CacheByParm(int id)
        {

            Person person = new Person() { Name = $"Mary {id}", Created = DateTime.Now };
            return View(person);
        }

        public ViewResult AjaxCaching()
        {
            return View();
        }

        [OutputCache(Duration = 5)]
        public JsonResult GetPeople()
        {
            List<Person> list = new List<Person>();

            Person person1 = new Person() { Name = $"Mary", Created = DateTime.Now };
            Person person2 = new Person() { Name = "Larry", Created = DateTime.Now };
            Person person3 = new Person() { Name = "Willie", Created = DateTime.Now };
            Person person4 = new Person() { Name = "Jane", Created = DateTime.Now };

            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            list.Add(person4);

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}