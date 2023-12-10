using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Domain
{
    public class Time
    {
        public int Id { get; set; }
        public bool IsBooked { get; set; }

        [ForeignKey("Appointment")]
        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
        public TimeSpan TimeOfAppointment { get; set; }

        //[ForeignKey("Request")]
        //public int? RequestId { get; set; }

        public virtual Request? Request { get; set; }
    }
}
