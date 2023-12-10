using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.enums;

namespace Vezeeta.Dto
{
    public class PatientRequestDto
    {
        public string Image { get; set; }
        public string DoctorName { get; set; }
        public string Specilization { get; set; }
        public DateTime? Day { get; set; }
        public TimeSpan? time { get; set; }
        public double Price { get; set; }
        public string? DiscountCode { get; set; }
        public double? FinalPrice { get; set; }
        public string Status { get; set; }
    }
}
