using MemoryCacheExample.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MemoryCacheExample.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            if (service == null)
            {
                throw new ArgumentNullException("Customer Controller Service");
            }
            _service = service;
        }

        // GET: Customer
        public ActionResult Index()
        {
            SetCities();
            return View();
        }

        public ActionResult GetCustomersByCity(string city)
        {
            var customers = _service.FindCustomersByCity(city);
            return Json(customers, JsonRequestBehavior.AllowGet);
        }

        private void SetCities()
        {
            List<SelectListItem> cities = new List<SelectListItem>();

            cities.Add(new SelectListItem { Text = "Cork", Value = "Cork" });
            cities.Add(new SelectListItem { Text = "Dublin", Value = "Dublin" });
            cities.Add(new SelectListItem { Text = "London", Value = "London" });

            ViewBag.Cities = cities;
            // ViewBag.CurrentCity = String.IsNullOrWhiteSpace(city) ? cities[0].Text : city;
        }
    }
}