using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public long AppointmentId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        [Range(1, 15)]
        public int SizeOfGroup { get; set; }

        [Required]
        public int TimeslotId { get; set; }
        public Timeslot Timeslot { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
