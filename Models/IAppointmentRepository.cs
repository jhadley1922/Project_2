using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }
        IQueryable<Timeslot> Timeslots { get; }

        public void SaveAppointment(Appointment a);
        public void CreateAppointment(Appointment a);
        public void DeleteAppointment(Appointment a);
        public void SaveTimeslot(Timeslot t);
    }
}
