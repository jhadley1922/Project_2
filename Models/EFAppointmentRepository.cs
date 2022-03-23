using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private AppointmentContext context { get; set; }

        public EFAppointmentRepository(AppointmentContext c)
        {
            context = c;
        }
        public IQueryable<Appointment> Appointments => context.Appointments;
        public IQueryable<Timeslot> Timeslots => context.Timeslots;

        public void CreateAppointment(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();
        }

        public void DeleteAppointment(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }

        public void SaveAppointment(Appointment a)
        {
            context.Update(a);
            context.SaveChanges();
        }
    }
}
