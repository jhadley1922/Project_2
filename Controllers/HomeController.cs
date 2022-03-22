using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2.Controllers
{
    public class HomeController : Controller
    {
        private AppointmentContext appContext { get; set; }

        public HomeController(AppointmentContext name)
        {
            appContext = name;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewAppointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewAppointment(Appointment app)
        {
            if (ModelState.IsValid)
            {
                appContext.Add(app);
                appContext.SaveChanges();

                return View("Index");
            }
            else // if invalid
            {
                return View(app);
            }
        }

        public IActionResult Appointments()
        {
            return View();
        }
    }
}
