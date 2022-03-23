using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2.Models
{
    public class Timeslot
    {
        [Key]
        [Required]
        public int TimeslotId { get; set; }
        public DateTime DateTime { get; set; }
        public bool Available { get; set; }
    }
}
