using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.enums;

namespace Vezeeta.Domain
{
    public class Appointment
    {
        public int Id { get; set; }
        
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public Days Day { get; set; }
        
        public DateTime AppointDate { get; set; }
        public virtual List<Time>? Times { get; set; }

    }
}
