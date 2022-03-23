using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext() {}

        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            int IdCounter = 1;
            int month = 3;
            int year = 2022;
            int day = 20;
            int hour = 8;

            while(day < 27)
            {
                while (hour < 21)
                {
                    mb.Entity<Timeslot>().HasData(
                        new Timeslot
                        {
                            TimeslotId = IdCounter,
                            DateTime = new DateTime(year, month, day, hour, 0, 0),
                            Available = true
                        }
                    );
                    IdCounter++;
                    hour++;
                }
                day++;
                hour = 8;
            }


        }

    }
}
