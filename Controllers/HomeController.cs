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

        [HttpGet]
        public IActionResult Appointments()
        {
            var apps = appContext.Appointments
                .OrderBy(x => x.GroupName)
                .ToList();

            return View(apps);
        }

        [HttpGet]
        public IActionResult Edit(int appid)
        {
            var app = appContext.Appointments.Single(x => x.AppointmentId == appid);

            return View("NewAppointment", app);
        }

        [HttpPost]
        public IActionResult Edit(Appointment app)
        {
            if (ModelState.IsValid)
            {
                appContext.Update(app);
                appContext.SaveChanges();

                return View("Index");
            }
            else // if invalid
            {
                return View("NewAppointment", app);
            }

        }

        [HttpGet]
        public IActionResult Delete(int appid)
        {
            var app = appContext.Appointments.Single(x => x.AppointmentId == appid);

            return View(app);
        }

        [HttpPost]
        public IActionResult Delete(Appointment app)
        {
            appContext.Appointments.Remove(app);
            appContext.SaveChanges();

            return View("Index");
        }
    }
}
