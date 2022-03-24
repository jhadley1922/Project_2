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

        [Required(ErrorMessage = "Please enter a group name.")]
        public string GroupName { get; set; }

        [Required(ErrorMessage = "Please enter a number between 1 & 15.")]
        [Range(1, 15)]
        public int SizeOfGroup { get; set; }

        [Required]
        public int TimeslotId { get; set; }
        public Timeslot Timeslot { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
