﻿using Microsoft.AspNetCore.Mvc;
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
        private IAppointmentRepository repo;

        public HomeController(IAppointmentRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            // I need the timeslots to be sent here so I can check if they're taken or not to display them.
            // Also, would this also need a post method to send the time selected to the New Appointment page, to be an undeditable part of the form?
            // Not trying to do your job, just walking through it for myself
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
                repo.CreateAppointment(app);

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
            var apps = repo.Appointments
                .OrderBy(x => x.GroupName)
                .ToList();

            return View(apps);
        }

        [HttpGet]
        public IActionResult Edit(int appid)
        {
            var app = repo.Appointments.Single(x => x.AppointmentId == appid);

            return View("NewAppointment", app);
        }

        [HttpPost]
        public IActionResult Edit(Appointment app)
        {
            if (ModelState.IsValid)
            {
                repo.SaveAppointment(app);

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
            var app = repo.Appointments.Single(x => x.AppointmentId == appid);

            return View(app);
        }

        [HttpPost]
        public IActionResult Delete(Appointment app)
        {
            repo.DeleteAppointment(app);

            return View("Index");
        }
    }
}
