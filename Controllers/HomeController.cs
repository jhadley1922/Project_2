using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //private AppointmentContext apptContext { get; set; }

        //public HomeController(AppointmentContext context)
        //{
        //    apptContext = context;

        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            // I need the timeslots to be sent here so I can check if they're taken or not to display them.
            // Also, would this also need a post method to send the time selected to the New Appointment page, to be an undeditable part of the form?
            // Not trying to do your job, just walking through it for myself
            ViewBag.FirstDay = new DateTime(2022, 3, 20);

            var times = repo.Timeslots
                .OrderBy(x => x.TimeslotId)
                .ToList();

            return View(times);
        }

        //[HttpPost]
        //public IActionResult SignUp(int timeId)
        //{
        //    //DateTime appointmentTime = dateTime.AddHours(time);/*new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, time, 0, 0);*/


        //    //Timeslot timeId = repo.Timeslots.FirstOrDefault(x => x.TimeslotId == 4);

        //    Timeslot chosenTime = repo.Timeslots.Single(x => x.TimeslotId == timeId);
        //    ViewBag.AppointmentTime = chosenTime;

        //    return RedirectToAction("NewAppointment");
        //}

        [HttpGet]
        public IActionResult NewAppointment(int timeId)
        {
            //var chosenTime = repo.Timeslots.Single(x => x.TimeslotId == timeId);

            ViewBag.AppointmentTime = repo.Timeslots.Single(x => x.TimeslotId == timeId);

            return View(new Appointment());
        }

        [HttpPost]
        public IActionResult NewAppointment(Appointment app)
        {
            //app.Timeslot = repo.Timeslots.FirstOrDefault(x => x.TimeslotId == app.TimeslotId);
            if (ModelState.IsValid)
            {
                Timeslot time = repo.Timeslots.FirstOrDefault(x => x.TimeslotId == app.TimeslotId);
                time.Available = false;

                repo.CreateAppointment(app);
                
                repo.SaveTimeslot(time);

                return View("Index");
            }
            else // if invalid
            {
                ViewBag.AppointmentTime = repo.Timeslots.Single(x => x.TimeslotId == app.TimeslotId);
                return View(app);
            }
        }

        [HttpGet]
        public IActionResult Appointments()
        {
            var apps = repo.Appointments
                .Include(x => x.Timeslot)
                .OrderBy(x => x.TimeslotId)
                .ToList();

            return View(apps);
        }

        [HttpGet]
        public IActionResult Edit(int appid)
        {
            var app = repo.Appointments.Single(x => x.AppointmentId == appid);
            ViewBag.AppointmentTime = repo.Timeslots.Single(x => x.TimeslotId == app.TimeslotId);

            return View("NewAppointment", app);
        }

        [HttpPost]
        public IActionResult Edit(Appointment app)
        {
            if (ModelState.IsValid)
            {
                repo.SaveAppointment(app);

                return RedirectToAction("Appointments");
            }
            else // if invalid
            {
                ViewBag.AppointmentTime = repo.Timeslots.Single(x => x.TimeslotId == app.TimeslotId);
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
            Appointment appChange = repo.Appointments.Single(x => x.AppointmentId == app.AppointmentId);
            Timeslot time = repo.Timeslots.FirstOrDefault(x => x.TimeslotId == appChange.TimeslotId);
            time.Available = true;

            repo.DeleteAppointment(appChange);
            
            repo.SaveTimeslot(time);

            return View("Index");
        }
    }
}
