using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Dto
{
    public class RequestCrtDto
    {
        [Required]
        [Range(minimum:0, int.MaxValue)]
        public int TimeId { get; set; }
        public string? DiscountCode { get; set; }
    }
}
