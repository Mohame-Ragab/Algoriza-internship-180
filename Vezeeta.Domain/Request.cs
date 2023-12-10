using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.enums;

namespace Vezeeta.Domain
{
    public class Request
    {
        public int Id { get; set; }

        public double Price { get; set; }
        public double? FinalPrice { get; set; }

        public RequestStatus  RequestStatus { get; set; }
        public bool IsConfirmed { get; set; }

        [ForeignKey("Time")]
        public int? TimeId { get; set; }
        public virtual Time? Time { get; set; }
        
        [ForeignKey("Discount")]
        public int? DiscountId { get; set; }
        public virtual Discount? Discount { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        //[ForeignKey("Specialization")]
        //public int SpecializationId { get; set; }
        //public virtual Specialization Specialization { get; set; }



    }
}
