using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Domain
{
    public class Doctor
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public DateTime DateOfBirth { get; set; }
        public double? Price { get; set; }

        [ForeignKey("Specialization")]
        public int SpecializationId { get; set; }
        public virtual Specialization Specialization { get; set; }

        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        

        public virtual List<Appointment>? Appointments { get; set; }

        public virtual List<Request>? Requests { get; set; }
    }
}
