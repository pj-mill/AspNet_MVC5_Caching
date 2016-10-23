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
            Person person = new Person() { Name = "John", Created = DateTime.Now };
            return View(person);
        }
    }
}