using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.enums;

namespace Vezeeta.Dto
{
    public class DiscountCreateUpDto
    {

        [Required]
        [MinLength(4) ,MaxLength(10)]
        public string DicountCode { get; set; }
        [Required]
        public DiscountType DiscountType { get; set; }
        [Required, Range(0, 100)]
        public int Value { get; set; }
        [Required]
        public bool IsActive { get; set; }//needed to check with patient
        [Required]
        public int NuberOfCompReqs { get; set; }

    }
}
