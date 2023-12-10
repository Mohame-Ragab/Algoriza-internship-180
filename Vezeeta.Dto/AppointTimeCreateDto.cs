using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Dto
{
    public class AppointTimeCreateDto
    {
        
        [Required]
        public DateTime AppointDate { get; set; }
        [Required]
        public List<TimeSpan> Time { get; set; }
    }
}
